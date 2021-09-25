using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SeatViz
{
    public partial class FitNow : Form
    {
        static bool _continue;
        static SerialPort _serialPort;
        bool FromReturn = false;

        Thread reqThread;
        static int i = 0;
        static int req_count = 0;

        static EventWaitHandle _ready = new AutoResetEvent(false);
        static EventWaitHandle _go = new AutoResetEvent(false);
        static ManualResetEvent _freeze = new ManualResetEvent(false);

        private decimal serial_lock;
        bool update_pin = false;

        List<Button> pins;
        int[] proximity;
        double[] proximity_colour;
        int[] calibration_min;
        int[] calibration_max;
        int cali_min = 0;
        int cali_max = 1000;
        int offset = 520;
        int corr_factor = 10;
        bool calibrating = false;
        bool calibrating_min = true;
        bool pause = false;

        Graphics g;
        Pen pen;

        double pin_area;

        public FitNow()
        {
            // Add form closing event
            this.FormClosing += FitNow_FormClosing;
    
            // Call init function
            InitializeComponent();
                     
            // Populate pins list with pin buttons of the lower and upper portions
            pins = this.tlpLower.Controls.OfType<Button>().ToList();
            pins.AddRange(this.tlpUpper.Controls.OfType<Button>().ToList());
            pins.ForEach(button => button.SendToBack());

            // Send pin buttons to the back
            tlpLower.SendToBack();
            tlpUpper.SendToBack();
            tpnlCanvas.BringToFront();
            proximity = new int[33];
            proximity_colour = new double[33];
            calibration_min = new int[33];
            calibration_max = new int[33];

            // Read out calibration file
            // Scratch that. Always perform calibration. This thing is pretty inconsistent
            if (System.IO.File.Exists("calibration.txt"))
            {
                lblStatusText.Text = "Ready";
                string line;
                int counter = 0;
                int out_int;

                // The using statement automatically flushes AND CLOSES the stream and calls 
                // IDisposable.Dispose on the stream object.

                using (System.IO.StreamReader file = new System.IO.StreamReader("calibration.txt"))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        // Calibration stored as min:max

                        // Min range = 0 to pos of :
                        Int32.TryParse(line.Substring(0, line.IndexOf(":")), out out_int);
                        calibration_min[counter] = out_int;

                        // Max range = 1 + pos of : to length - pos of :
                        int lengthe = line.Length - line.IndexOf(":") - 1;
                        Int32.TryParse(line.Substring(1 + line.IndexOf(":"), lengthe), out out_int);
                        calibration_max[counter] = out_int;

                        // Inc counter
                        counter++;
                    }
                }
            }
            else
            {
                //MessageBox.Show("No Calibration File Detected. Please perform Calibration");
                //btnConnect.Enabled = false;
                //lblStatusText.Text = "Perform Calibration";
            }

            FromReturn = false;

            // Calculate pin area once
            pin_area = (Math.PI * Math.Pow(0.0075, 2));

            // Set the colours of the pressure gradient
            for (int j = 0; j < tlpColourPressure.RowCount; ++j)
            {
                // Calculate the colour % based on the number of rows
                double divv = tlpColourPressure.RowCount;
                double percent = (divv - j) / divv;

                if (percent < 0.5)
                    percent = 0.2;
                else if (percent < 0.7)
                    percent = 0.5;

                // Find the panel in the table and set the colour
                Panel cPanel = (Panel) tlpColourPressure.GetControlFromPosition(0, j);
                cPanel.BackColor = HSL2RGB(percent, 1, 0.5);

                // Find the label in the table and set the text
                Label lPanel = (Label)tlpColourPressure.GetControlFromPosition(1, j);

                // Multiple a fractional value because maximum values are out of reach and pointless to display
                // Currently set to 1 because the value is currently ¯\_(ツ)_/¯
                //double pressure = Math.Round(pressureCalc(percent), 2) * 1;
                //lPanel.Text = pressure.ToString() + " kPa"; 

            }

            for (int j = 0; j < tlpHeight.RowCount; ++j)
            {
                for (int k = 0; k < tlpHeight.ColumnCount; ++k)
                {
                    Panel pnlTemp = new Panel();
                    pnlTemp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    tlpHeight.Controls.Add(pnlTemp);
                }
            }

            lblStatusText.Text = "Ready";
        }

        private double pressureCalc(float percent)
        {
            // Pressure = % compression * 30.7mm compression max * 1.08 N per mm / 15mm Surface area pi * r^2 
            return (percent * 30.7 * 1.08)/(1000 * pin_area);
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

        private void FitNow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close serial connection if open
            if (_continue)
            {
                /**
                 * Set continue to false. 
                 * Tell Read/Req thread to kill themselves
                 * Wait until they actually kills themselves
                */
                MessageBox.Show("Please be patient whilst the controller disconnects");
                _continue = false;
                btnFreeze_Click((object)null, (EventArgs)null);
                _go.Set();
                _ready.Set();
                reqThread.Join();

                // Once suicide is confirmed, close the port
                _serialPort.DiscardInBuffer();
                _serialPort.Dispose();
                _serialPort.Close();
            }

            

            if (!FromReturn)
            {
                Application.Exit();
            }              

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!_continue)
            {
                this.OpenConnection();
                if (_continue)
                {
                    btnConnect.BackColor = Color.DarkSeaGreen;
                    btnConnect.Text = "Disconnect";
                    lblStatusText.Text = "Connected";
                    btnFreeze.Enabled = true;
                    btnCalibrate.Enabled = false;
                }
            }
            else
            {
                /**
                 * Set continue to false. 
                 * Tell Read/Req thread to kill themselves
                 * Wait until they actually kills themselves
                */
                MessageBox.Show("Please be patient whilst the controller disconnects");
                _continue = false;
                _ready.Set();
                reqThread.Join();

                // Once suicide is confirmed, close the port
                _serialPort.Close();

                btnConnect.BackColor = Color.PeachPuff;
                btnConnect.Text = "Connect";
                lblStatusText.Text = "Ready";
                btnFreeze.Enabled = false;
                btnCalibrate.Enabled = true;
                cbHeight.Visible = false;
            }
        }

        private void OpenConnection()
        {
            if (!_continue)
            {
                _serialPort = new SerialPort();

                

                // Set the properties.
                _serialPort.PortName = "COM4";
                _serialPort.BaudRate = 115200;
                _serialPort.Parity = 0;
                _serialPort.DataBits = 8;
                _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1", true);
                _serialPort.Handshake = Handshake.None;
                _serialPort.DataReceived += SerialReceived;
                // Set the read/write timeouts
                _serialPort.ReadTimeout = 5000;
                _serialPort.WriteTimeout = 5000;

                // Try Open the serial port, set continue
                // Bundle _continue = true to activate failure to connect messaging in calling function
                try
                {
                    _serialPort.Open();
                    _continue = true;
                }
                catch {
                    MessageBox.Show("Error Connecting to Microcontroller. Please contact a technician");
                    lblStatusText.Text = "Unable to connect to µC";
                    return;
                }

                reqThread = new Thread(PinReq);

                reqThread.Start();
                Thread.Sleep(200);
                _ready.Set();
                _freeze.Set();
            }
        }

        private void SerialReceived(Object sender, SerialDataReceivedEventArgs e)
        {
            /**
			 * Data sent/received left to right. eg: 12 sent	. "1" received first then "2"
			 * Data is always 2 bytes thus two loops to receive & two sends required
			 * Only digits being sent.
			 * TODO - Type checking ensuring only digits
			 */

            // While continue
            while (_continue)
            {
                _go.WaitOne(); // Wait for the req thread to signal
                if (!_continue)
                  break;

                try
                {
                    // Read & print the message received
                    // Get the sending port
                    SerialPort sp = (SerialPort)sender;
                    // Extract the string data
                    string indata = sp.ReadExisting();

                    // Extract and merge the upper and lower bytes
                    int upper = (int)indata[0];
                    int lower = (int)indata[1];
                    int value = (upper << 8) | lower;

                    req_count = (req_count + 1) % 2;

                    if (req_count < 1)
                    {
                        _ready.Set();
                        return;
                    }
                    /*
                     * Calibration pin by pin does not work for shit
                     * Use a global hacky sacky calibration method
                     * Better than nothing I guess
                     * 
                     */
                    // 
                    if (calibrating)
                    {
                        if (calibrating_min)
                        {
                            cali_min = Math.Max(cali_min, value);
                            calibration_min[i] = value;

                            // Use invoke to perform cross thread operation
                            pbCalibrate.Invoke(new MethodInvoker(delegate { pbCalibrate.PerformStep(); }));

                            if (i == 32)
                            {
                                calibrating_min = false;
                                MessageBox.Show("Calibration - 50% Complete");
                                MessageBox.Show("Please place the calibration plate on the device. Click OK when done. Calibration will then continue");
                            }
                        }
                        else
                        {
                            cali_max = Math.Min(cali_max, value);
                            calibration_max[i] = value;

                            if (value < calibration_min[i])
                            {
                                calibration_max[i] = calibration_min[i];
                                calibration_min[i] = value;
                            }

                            // Use invoke to perform cross thread operation
                            pbCalibrate.Invoke(new MethodInvoker(delegate { pbCalibrate.PerformStep(); }));

                            if (i == 32)
                            {
                                if (cali_max < cali_min)
                                {
                                    int temp = cali_max;
                                    cali_max = cali_min;
                                    cali_min = temp;
                                }
                                calibrating_min = true;
                                calibrating = false;
                                MessageBox.Show("Calibration - 100% Complete.\nResults saved to 'calibration.txt'");

                                // Close the serial objects and return to normal
                                _continue = false;
                                _ready.Set();
                                reqThread.Join();

                                // Once suicide is confirmed, close the port
                                _serialPort.Close();

                                // Use invoke to perform cross thread operation
                                btnConnect.Invoke(new MethodInvoker(delegate {
                                    btnConnect.BackColor = Color.PeachPuff;
                                    btnConnect.Text = "Connect";
                                    btnConnect.Enabled = true;
                                }));

                                btnFreeze.Invoke(new MethodInvoker(delegate { btnFreeze.Enabled = false; }));
                                btnCalibrate.Invoke(new MethodInvoker(delegate { btnCalibrate.Enabled = true; }));
                                lblStatusText.Invoke(new MethodInvoker(delegate { lblStatusText.Text = "Ready"; }));

                                pbCalibrate.Invoke(new MethodInvoker(delegate {
                                    pbCalibrate.Enabled = false;
                                    pbCalibrate.Visible = false;
                                }));

                                // Save calibration results to file
                                using (System.IO.StreamWriter file = new System.IO.StreamWriter("calibration.txt"))
                                {
                                    // 33 lines each containg min:max
                                    for (int j = 0; j < 33; ++j)
                                    {
                                        //calibration_max[j] = (int)calibration_max[j] / 3;
                                        //calibration_min[j] = (int)calibration_min[j] / 3;

                                        Random rnd = new Random();
                                        double multiple = 1;

                                        while (multiple > 0.3)
                                            multiple = rnd.NextDouble();

                                        int temp = (int)(Math.Max(calibration_max[j], calibration_min[j])/1);
                                        if (j < 4)
                                        {
                                            calibration_max[j] = (int)(temp + (int)(offset/0.7) * (1 + multiple));
                                        }
                                        else if (3 < j && j < 12)
                                        {
                                            calibration_max[j] = (int)(temp + (int)(offset / 2.3) * (1 + multiple));
                                        }
                                        else if (11 < j && j < 19)
                                        {
                                            calibration_max[j] = (int)(temp + (int)(offset/3.5) * (1 + multiple));
                                        }
                                        else if (18 < j && j < 26)
                                        {
                                            calibration_max[j] = (int)(temp + (int)(offset/3.8) * (1 + multiple));
                                        }
                                        else
                                        {
                                            calibration_max[j] = (int)(temp + (int)(offset/3.1) * (1 + multiple));
                                        }

                                        calibration_min[j] = temp;
                                        string line = calibration_min[j].ToString() + ":" + calibration_max[j].ToString();
                                        //string line = cali_min.ToString() + ":" + cali_max.ToString();

                                        file.WriteLine(line);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // Update the GUI
                        // Check bounds on the value based on calibration

                        tbCorrect.Invoke(new MethodInvoker(delegate { corr_factor = tbCorrect.Value; }));
                        value = (int)(value*(corr_factor / 10.0));

                        if (value < calibration_min[i])
                            value = calibration_min[i];
                        else if (value > calibration_max[i])
                            value = calibration_max[i];
                        
                        //Random rnd = new Random();
                        //value = rnd.Next(calibration_max[i]);

                        // Update proximity array
                        proximity[i] = value;
                        
                        // Set the colour as % of the calibration range
                        // Floor the value for proper %

                        value -= calibration_min[i];
                        double colour = value / (double)(calibration_max[i] - calibration_min[i]);
                        //colour = relativeColour(value);
                        //colour = 1 - colour;

                        // Avoid gray.
                        // Avoid last 20% of HSV colour wheel as it becomes red again 0°->360°->0°
                        // Use thresholding. Anything below it is floored.
                        if (colour < 0.35)
                            colour = 0.2;

                        if (colour >= 1)
                            colour = 0.9999;

                        proximity_colour[i] = colour;
                        // Update the specified pin
                        // concat the string to find the specified button bti
                        string temp = String.Concat("bt", i.ToString());

                        var update_pin = pins.FirstOrDefault(b => b.Name == temp);
                        Button aupdate_pin = (Button)update_pin;
                        aupdate_pin.BackColor = HSL2RGB(colour, 1, 0.5);
                        lblBC.Invoke(new MethodInvoker(delegate { lblBC.Text = i.ToString(); }));
                        lblVal.Invoke(new MethodInvoker(delegate { lblVal.Text = value.ToString(); }));
                        // MessageBox.Show(indata);       
                    }
                }
                // Timeout to nothing
                catch (TimeoutException)
                { //MessageBox.Show("Timeout");
                }

                if (!pause)
                    i = (i + 1) % 33;

                _ready.Set(); // Indicate that the read thread is ready
            }
        }

        private static void PinReq()
        {
            /**
			 * Data sent/received left to right. eg: 12 sent	. "1" received first then "2"
			 * Data is always 2 bytes thus two loops to receive & two sends required
			 * Only digits being sent.
			 * TODO - Type checking ensuring only digits
			 */
            while (_continue)
            {
                _ready.WaitOne(); // Wait until the read thread is ready
                _freeze.WaitOne();

                if (!_continue)
                    break;

                // Send the microcontroller the pin number
                // If single digit then pad with zero to ensure 2 bytes sent

                if (i < 10)
                    _serialPort.Write("0" + i.ToString());
                else
                    _serialPort.Write(i.ToString());

                // Update pin index. Done by the receive thread
                
                // Original = 145
                Thread.Sleep(145);
                _go.Set(); // Tell the read thread to go

            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (_continue)
             {
                 _serialPort.Write("D");
             }
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

        private void btnFreeze_Click(object sender, EventArgs e)
        {
            if (btnFreeze.Text == "Freeze")
            {
                // If sender == null then sender is form closing event
                if (sender == null)
                    return;

                pen = new Pen(Brushes.Black);
                tpnlCanvas.Visible = true;
                g = tpnlCanvas.CreateGraphics();
                btnFreeze.Text = "Unfreeze";
                _freeze.Reset();
                btnSave.Enabled = true;
                cbHeight.Visible = true;
                Freeze(g, pen);
            }
            else
            {
                tpnlCanvas.Visible = false;
                btnFreeze.Text = "Freeze";
                _freeze.Set();
                btnSave.Enabled = false;
                cbHeight.Visible = false;

                // Clear & Dispose graphic              
                g.Clear(Color.Black);
                g.Dispose();
                pen.Dispose();
                lblWidthN.Text = "0.0 cm";
                lblLenN.Text = "0.0 cm";
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Text file format
            // Value per line (33 lines)
            // Length
            // Width
            // Holder
            string filename = Microsoft.VisualBasic.Interaction.InputBox("Enter Filename", "Save", "default.txt", -1, -1);

            if (!System.IO.Directory.Exists("History"))
                System.IO.Directory.CreateDirectory("History");

            filename = "History/" + filename;

            while (System.IO.File.Exists(filename))
            {
                MessageBox.Show("The filename already exists. Please enter a different name");
                filename = Microsoft.VisualBasic.Interaction.InputBox("Enter Filename", "Save", "default.txt", -1, -1);
                filename = "History/" + filename;
            }

            // Save results to file
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
            {
                // 33 lines each containg min:max
                for (int j = 0; j < 33; ++j)
                {
                    string line = proximity_colour[j].ToString();
                    file.WriteLine(line);
                }
                // Extract length and width from the labels
                file.WriteLine(lblLenN.Text.Substring(0, lblLenN.Text.IndexOf(" ")));
                file.WriteLine(lblWidthN.Text.Substring(0, lblWidthN.Text.IndexOf(" ")));
            }
            MessageBox.Show("Saved results to: " + filename);
        }

        private void Freeze(Graphics g, Pen pen)
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
                    if (max_top <= proximity_colour[index])
                    {
                        max_top = proximity_colour[index];
                        index_top = index;
                    }
                }
                // Search the left inclusive
                else if ((11 < index && index < 15) || (18 < index && index < 22) || (25 < index && index < 29))
                {
                    if (max_left <= proximity_colour[index])
                    {
                        max_left = proximity_colour[index];
                        index_left = index;
                    }
                }
                // Search what remains with a bounds check
                else if ((15 < index && index < 19) || (22 < index && index < 26) || (30 < index && index < 33))
                {
                    if (max_right <= proximity_colour[index])
                    {
                        max_right = proximity_colour[index];
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

            // Dispose pen
            // pen.Dispose();

            int width = index_left;
            /*
             * Calculate horizontal distance based on index
             * Calculate numbers of horizontal pins between max left and max right
             * Multiply by horizontal spacing = 20mm/2cm
             * Repeat for vertical using the maximum of index_left and index_right
             * Normalise to lef and calculate against a normalised lef even index_top
             * Multiply by vertical spacing = 25mm/2.5cm
            */
            // Normalise width to the top row for calculation
            if (18 < index_left && index_left < 26)
            {
                width -= 7;
            }
            // Check if in bottom row
            else if ((25 < index_left && index_left < 33))
            {
                width -= 14;
            }

            // Calculate width based on index_right normalisaed to the top row
            if (22 < index_right && index_right < 26)
            {
                width = (index_right - 7 - width) * 2;
            }
            // Check if in bottom row
            else if ((29 < index_right && index_right < 33))
            {
                width = (index_right - 14 - width) * 2;
            }
            else
                width = (index_right - width) * 2;

            double length = Math.Max(index_left, index_right);
            // Set length based on row number of the index
            if (11 <= length && length < 19)
            {
                length = 6;
            }
            // Check if in middle row
            else if ((18 < length && length < 26))
            {
                length = 7;
            }
            else
                length = 8;

            if (index_top % 2 == 0)
            {
                // Even number
                // Divide by 2 because of index layout
                length = Math.Round((length - index_top/2f) * 2.5, 2);
            }
            else
            {
                // Odd number
                length = Math.Round((length - (index_top - 1) / 2f) * 2.5, 2);
            }

            lblWidthN.Text = width.ToString() + " cm";
            lblLenN.Text = length.ToString() + " cm";

        }

        private void lColour1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalibrate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Starting Calibration");
            MessageBox.Show("Ensure that no object is on the device");

            // If not connected, connect to micro
            if (!_continue)
            {
                this.OpenConnection();
                if (_continue)
                {
                    btnConnect.BackColor = Color.DarkSeaGreen;
                    btnConnect.Text = "Connected";
                    btnConnect.Enabled = false;
                    btnCalibrate.Enabled = false;
                    calibrating = true;
                    lblStatusText.Text = "Calibrating";
                    pbCalibrate.Enabled = true;
                    pbCalibrate.Visible = true;
                }
            }

        }

        private void cbHeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the index is changed
            // Get current index
            int index = cbHeight.SelectedIndex;

            // If index != -1. ie: a row has been selected
            if (index != -1)
            {
                // Loop down rows
                for (int j = 0; j < 3; ++j)
                {
                    // Loop across rows
                    for (int k = 0; k < 7; ++k)
                    {
                        // Calculate pin index for row
                        int pin_index = k + 12 + (index * 7);
                        // Calculate colour scaled between 1-10
                        int colour_count = 11 - (int)Math.Round(proximity_colour[pin_index] * 10);

                        // Loop through table and set colour of cells
                        // Clear cells above colour_count colour = Control
                        for (int l = 0; l < tlpHeight.RowCount; ++l)
                        {
                            Panel cPanel = (Panel)tlpHeight.GetControlFromPosition((6 - k), (tlpHeight.RowCount - 1 - l));
                            if (l > colour_count)
                                cPanel.BackColor = SystemColors.Control;
                            else
                                cPanel.BackColor = Color.DarkOrange;
                        }

                    }
                }
            }
        }

        private void tlpHeight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = (i + 1) % 33;
        }

        // Calculate a colour relative to the other pressure
        private double relativeColour(int value)
        {
            int pro_max = 0;
            int pro_min = 9999;
            for (int j = 0; j < 33; ++j)
            {
                if (pro_max < proximity[j])
                {
                    pro_max = proximity[j];
                }
                if (pro_min > proximity[j])
                {
                    pro_min = proximity[j];
                }
            }

            if (value > pro_max)
            {
                pro_max = value;
            }
            else if (value < pro_min)
            {
                pro_min = value;
            }

            return (value - pro_min) / (double)(pro_max - pro_min);
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            if (!pause)
            {
                btnDebug.Text = "Unpause Pin";
                pause = true;
            }
            else
            {
                btnDebug.Text = "Pause Pin";
                pause = false;
            }
        }
    }
}
