using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Drawing.Drawing2D;

namespace SeatViz
{
    public partial class History : Form
    {
        string[] files;

        bool FromReturn = false;

        double[] proximity;

        List<Button> pins;

        Graphics g;
        Pen pen;

        public History()
        {
            this.FormClosing += History_FormClosing;

            InitializeComponent();

            tpnlCanvas.BringToFront();
            proximity = new double[33];

            // Populate pins list with pin buttons of the lower and upper portions
            pins = this.tlpLower.Controls.OfType<Button>().ToList();
            pins.AddRange(this.tlpUpper.Controls.OfType<Button>().ToList());
            pins.ForEach(button => button.SendToBack());

            for (int j = 0; j < tlpColourPressure.RowCount; ++j)
            {
                // Calculate the colour % based on the number of rows
                float divv = tlpColourPressure.RowCount;
                float percent = (tlpColourPressure.RowCount - j) / divv;

                // Find the panel in the table and set the colour
                Panel cPanel = (Panel)tlpColourPressure.GetControlFromPosition(0, j);
                cPanel.BackColor = HSL2RGB(percent, 1, 0.5);

                // Find the label in the table and set the text
                Label lPanel = (Label)tlpColourPressure.GetControlFromPosition(1, j);

                // Multiple a fractional value because maximum values are out of reach and pointless to display
                // Currently set to 1 because the value is currently ¯\_(ツ)_/¯
                //double pressure = Math.Round(pressureCalc(percent), 2) * 1;
                //lPanel.Text = pressure.ToString() + " kPa"; 

            }

            // Create list of files from History directory if it exists
            if (System.IO.Directory.Exists("History"))
            {
                // Initialise the list view
                lvHistory.Columns.Add("");
                lvHistory.Columns[0].Width = -2;
                lvHistory.Columns.Add("Name");
                lvHistory.Columns[1].Width = 300;
                lvHistory.Columns.Add("Creation Date");
                lvHistory.Columns[2].Width = -2;
                lvHistory.View = View.Details;
                lvHistory.FullRowSelect = true;

                // Get all files ending in .txt from History directory
                files = System.IO.Directory.GetFiles("History", "*.txt");
                // Loop through the files and extract the name and the creation date
                // Create a list view item based on them and add it to the list view item
                foreach (var file in files)
                {
                    string name = file.ToString();
                    DateTime lastMod = System.IO.File.GetCreationTime(name);
                    int temp = name.Length - 8;
                    name = name.Substring(7 + 1, temp);
                    string date = lastMod.ToString("dd MMMM yyyy HH:mm");
                    ListViewItem item = new ListViewItem();
                    
                    item.SubItems.Add(name);
                    item.SubItems.Add(date);

                    lvHistory.Items.Add(item);
                }

                btnDisplay.Enabled = true;
                btnRename.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            //g.Clear(Color.Black);
            g.Dispose();
            pen.Dispose();
           
            if (!FromReturn)
            {
                Application.Exit();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Check if item selected
            if (lvHistory.SelectedItems.Count > 0)
            {
                // Adjust Form content by adjusting visibility
                tlpButtons.Visible = false;
                lvHistory.Visible = false;
                tlpInfoAll.Visible = true;
                tlpUpper.Visible = true;
                tlpLower.Visible = true;

                // Find the file name
                string filename = "History/" + lvHistory.SelectedItems[0].SubItems[1].Text;

                string line;
                int counter = 0;
                double colour;

                // The using statement automatically flushes AND CLOSES the stream and calls 
                // IDisposable.Dispose on the stream object.

                using (System.IO.StreamReader file = new System.IO.StreamReader(filename))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        // Update pins
                        if (counter < 33)
                        {                        
                            Double.TryParse(line, out colour);

                            // Read value and update a pin

                            proximity[counter] = colour;

                            // Update the specified pin
                            // concat the string to find the specified button bti
                            string temp = String.Concat("bt", counter.ToString());

                            var update_pin = pins.FirstOrDefault(b => b.Name == temp);
                            Button aupdate_pin = (Button)update_pin;
                            aupdate_pin.BackColor = HSL2RGB(colour, 1, 0.5);
                        }
                        // Update labels
                        else if (counter == 33)
                            lblLenN.Text = line.ToString() + " cm";
                        else
                            lblWidthN.Text = line.ToString() + " cm";

                        // Inc counter
                        counter++;
                    }
                }

                pen = new Pen(Brushes.Black);
                tpnlCanvas.Visible = true;
                g = tpnlCanvas.CreateGraphics();
                DrawGraphics(g, pen);
            }
            else
                MessageBox.Show("Please Select An Item");
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            // Create the seatviz tag
            var seatviz = (SeatViz)Tag;
            // Close this form
            FromReturn = true; // Tell close who sent the close request
            Close();
            // Show the seatviz form
            seatviz.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if item selected
            if (lvHistory.SelectedItems.Count > 0)
            {
                MessageBox.Show("Deleting Selected Item");
                // Find the file name
                string delfile = "History/" + lvHistory.SelectedItems[0].SubItems[1].Text;
                // Delete the file
                FileSystem.DeleteFile(delfile, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                //System.IO.File.Delete(delfile, );
                // Remove the item from the list view
                lvHistory.Items.Remove(lvHistory.SelectedItems[0]);
            }
            else
                MessageBox.Show("Please Select An Item");
        }

        private void btnRename_Click(object sender, EventArgs e)
        {   

            // Check if item selected
            if (lvHistory.SelectedItems.Count > 0)
            {
                string filename = Microsoft.VisualBasic.Interaction.InputBox("Enter Filename", "Rename", "default.txt", -1, -1);

                while (lvHistory.Items.ContainsKey(filename) && (filename.Length < 1)){
                    MessageBox.Show("Filename already used or invalid. Please select another");
                    filename = Microsoft.VisualBasic.Interaction.InputBox("Enter Filename", "Rename", "default.txt", -1, -1);
                }

                // Find the file name
                string oldFile = "History/" + lvHistory.SelectedItems[0].SubItems[1].Text;
                // Rename the file if the filename isn't the same
                if (!oldFile.Equals("History/" + filename))
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(oldFile, filename);
                }
                // Rename the item in the list view
                lvHistory.SelectedItems[0].SubItems[1].Text = filename;
            }
            else
                MessageBox.Show("Please Select An Item");
        }

        private void DrawGraphics(Graphics g, Pen pen)
        {
            // Variables to find the max
            double max_left = 0;
            double max_right = 0;
            double max_top = 0;

            // Variables to hold the index of the max
            int index_left = 0;
            int index_right = 0;
            int index_top = 0;
            int index = 0;

            // Find the indexes of the max values
            for (index = 0; index < 33; ++index)
            {
                // Search the top pins for the max value
                if (0 <= index && index < 12)
                {
                    if (max_top < proximity[index])
                    {
                        max_top = proximity[index];
                        index_top = index;
                    }
                }
                // Search the left inclusive
                else if ((11 < index && index < 16) || (18 < index && index < 23) || (25 < index && index < 30))
                {
                    if (max_left < proximity[index])
                    {
                        max_left = proximity[index];
                        index_left = index;
                    }
                }
                // Search what remains with a bounds check
                else if (index < 33)
                {
                    if (max_right < proximity[index])
                    {
                        max_right = proximity[index];
                        index_right = index;
                    }
                }
                else MessageBox.Show("Index out of range");
            }

            // Draw some pretty pictures
            // Draw the right circle
            string temp = String.Concat("bt", index_right.ToString());

            var update_pin = pins.FirstOrDefault(b => b.Name == temp);
            Button draw_info = (Button)update_pin;
            // Take into account location offset of the table panel layout that the buttons are in
            Point point_right = draw_info.Location;
            point_right.X += tlpLower.Location.X - tpnlCanvas.Location.X;
            point_right.Y += tlpLower.Location.Y - tpnlCanvas.Location.Y;

            g.FillEllipse(pen.Brush, new Rectangle(point_right, draw_info.Size));

            // Draw the left circle
            temp = String.Concat("bt", index_left.ToString());

            update_pin = pins.FirstOrDefault(b => b.Name == temp);
            draw_info = (Button)update_pin;
            // Take into account location offset of the table panel layout that the buttons are in
            Point point_left = draw_info.Location;
            point_left.X += tlpLower.Location.X - tpnlCanvas.Location.X;
            point_left.Y += tlpLower.Location.Y - tpnlCanvas.Location.Y;

            g.FillEllipse(pen.Brush, new Rectangle(point_left, draw_info.Size));

            // Draw the top circle
            temp = String.Concat("bt", index_top.ToString());

            update_pin = pins.FirstOrDefault(b => b.Name == temp);
            draw_info = (Button)update_pin;
            // Take into account location offset of the table panel layout that the buttons are in
            Point point_top = draw_info.Location;
            point_top.X += tlpUpper.Location.X - tpnlCanvas.Location.X;
            point_top.Y += tlpUpper.Location.Y - tpnlCanvas.Location.Y;

            g.FillEllipse(pen.Brush, new Rectangle(point_top, draw_info.Size));

            // Draw the line connecting the circles
            pen.Width = 5;
            g.DrawLine(pen, point_right, point_left);
            g.DrawLine(pen, point_right, point_top);
            g.DrawLine(pen, point_left, point_top);
        }

        public struct ColorRGB
        {
            public byte R;
            public byte G;
            public byte B;

            public ColorRGB(Color value)
            {
                this.R = value.R;
                this.G = value.G;
                this.B = value.B;
            }

            public static implicit operator Color(ColorRGB rgb)
            {
                Color c = Color.FromArgb(rgb.R, rgb.G, rgb.B);
                return c;
            }

            public static explicit operator ColorRGB(Color c)
            {
                return new ColorRGB(c);
            }

        }

        // Given H,S,L in range of 0-1

        // Returns a Color (RGB struct) in range of 0-255

        public static ColorRGB HSL2RGB(double h, double sl, double l)
        {
            double v;
            double r, g, b;

            h = 1 - h; // Done to inverse the calculation. Want Red 0° to actually be 360°
            r = l;   // default to gray
            g = l;
            b = l;
            v = (l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl);

            if (v > 0)
            {
                double m;
                double sv;
                int sextant;
                double fract, vsf, mid1, mid2;

                m = l + l - v;
                sv = (v - m) / v;
                h *= 6.0;
                sextant = (int)h;
                fract = h - sextant;
                vsf = v * sv * fract;
                mid1 = m + vsf;
                mid2 = v - vsf;

                switch (sextant)
                {
                    case 0:
                        r = v;
                        g = mid1;
                        b = m;
                        break;
                    case 1:
                        r = mid2;
                        g = v;
                        b = m;
                        break;
                    case 2:
                        r = m;
                        g = v;
                        b = mid1;
                        break;
                    case 3:
                        r = m;
                        g = mid2;
                        b = v;
                        break;
                    case 4:
                        r = mid1;
                        g = m;
                        b = v;
                        break;
                    case 5:
                        r = v;
                        g = m;
                        b = mid2;
                        break;
                }
            }

            ColorRGB rgb;

            rgb.R = Convert.ToByte(r * 255.0f);

            rgb.G = Convert.ToByte(g * 255.0f);

            rgb.B = Convert.ToByte(b * 255.0f);

            return rgb;

        }
    }
}
