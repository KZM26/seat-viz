using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SeatViz
{
    public partial class SeatViz : Form
    {
        public SeatViz()
        {
            InitializeComponent();
        }

        private void btFitNow_Click(object sender, EventArgs e)
        {
            FitNow fitnow = new FitNow();
            fitnow.Tag = this;
            fitnow.Show(this);
            Hide();
        }

        private void btHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Tag = this;
            history.Show(this);
            Hide();
        }

        public class TransparentPanel : Panel
        {
            protected override CreateParams CreateParams
            {
                get
                {
                    CreateParams cp = base.CreateParams;
                    cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                    return cp;
                }
            }
            protected override void OnPaintBackground(PaintEventArgs e)
            {
                //base.OnPaintBackground(e);
            }
        }

        private void btHelp_Click(object sender, EventArgs e)
        {
            string Help = "Help.pdf";
            System.Diagnostics.Process.Start(Help);
            MessageBox.Show("Opening the help document");
        }
    }

    
}
