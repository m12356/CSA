using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

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

        public RobotCtrl.Led Led
        {
            get { return led; }
            set
            {
                led = value;
                if (led != null)
                {
                    led.LedStateChanged += LedStateChanged;
                }
            }

        }



        private void LedStateChanged(object sender, LedEventArgs e)
        {
            if (InvokeRequired) // Prüft ob Thread != GUI-Thread
            {
                // Synchronisierung notwendig
                Invoke(new EventHandler<LedEventArgs>(LedStateChanged), sender, e);

            }
            else
            {
                // Synchronisierung nicht notwendig
                this.State = e.LedEnabled;
            }
        }



    }
}