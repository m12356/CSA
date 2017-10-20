using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class LedView : UserControl
    {
        private bool state;

        public LedView()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        { }

        public Boolean State
        {
            get { return state; }
            set
            {
                state = value;
                pictureBox2.Image = state ? Resource1.LedOn : Resource1.LedOff;

            }


        }
    }
}