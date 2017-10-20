using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class SwitchView : UserControl
    {
        public bool state;
        public SwitchView()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }

        public Boolean State
        {
            get { return state; }
            set
            {
                state = value;
                pictureBox1.Image = state ? Resource1.SwitchOn : Resource1.SwitchOff;

            }
        }
    }
}