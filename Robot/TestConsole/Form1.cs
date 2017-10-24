using RobotCtrl;
using RobotView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestConsole
{
    public partial class Form1 : Form
    {
        RobotConsole robotConsole;


        public Form1()
        {
            InitializeComponent();
            this.robotConsole = new RobotCtrl.RobotConsole();
            this.consoleView.RobotConsole = robotConsole;
            robotConsole[Switches.Switch1].SwitchStateChanged += Form1_SwitchStateChanged;
            robotConsole[Switches.Switch2].SwitchStateChanged += Form1_SwitchStateChanged;
            robotConsole[Switches.Switch3].SwitchStateChanged += Form1_SwitchStateChanged;
            robotConsole[Switches.Switch4].SwitchStateChanged += Form1_SwitchStateChanged;
        }

        private void Form1_SwitchStateChanged(object sender, SwitchEventArgs e)
        {
            robotConsole[(Leds)(int)e.Swi].LedEnabled = e.SwitchEnabled;
                
        }

        private void label3_ParentChanged(object sender, EventArgs e)
        {

        }
    }

}
