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
    public partial class SwitchView : UserControl
    {
        public bool state;
        private RobotCtrl.Switch mySwitch;

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

        public RobotCtrl.Switch Switch
        {
            get { return mySwitch; }
            set
            {
                
                mySwitch = value;
                if (mySwitch != null)
                {
                    mySwitch.SwitchStateChanged += SwitchStateChanged;
                }
            }

        }



        private void SwitchStateChanged(Object sender, RobotCtrl.SwitchEventArgs e)
        {
            if (InvokeRequired) // Prüft ob Thread != GUI-Thread
            {
                // Synchronisierung notwendig
                Invoke(new EventHandler<SwitchEventArgs>(SwitchStateChanged), sender, e);
            }
            else
            {
                // Synchronisierung nicht notwendig
                this.State = e.SwitchEnabled;
            }
               
        }
    }
}