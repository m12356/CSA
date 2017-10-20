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
        private RobotCtrl.Led led;

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

        public void set()
        {
            led.LedStateChanged += MyHandler;
        }

        private void MyHandler(Object sender, RobotCtrl.LedEventArgs e)
        {
            this.State = e.LedEnabled;
        }
        {

        }
    }
}