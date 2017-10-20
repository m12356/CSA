using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class ConsoleView : UserControl
    {
        RobotCtrl.RobotConsole robotConsole;

        public ConsoleView()
        {
            InitializeComponent();
        }

        public void set()
        {
            ledView1.setLed(robotConsole[RobotCtrl.Leds.Led1]);
            ledView2.setLed(robotConsole[RobotCtrl.Leds.Led2]);
            ledView3.setLed(robotConsole[RobotCtrl.Leds.Led3]);
            ledView4.setLed(robotConsole[RobotCtrl.Leds.Led4]);

            switchView1.setSwitch(robotConsole[RobotCtrl.Switches.Switch1]);
            switchView2.setSwitch(robotConsole[RobotCtrl.Switches.Switch2]);
            switchView3.setSwitch(robotConsole[RobotCtrl.Switches.Switch3]);
            switchView4.setSwitch(robotConsole[RobotCtrl.Switches.Switch4]);

        }

        public void setRobotConsole(RobotCtrl.RobotConsole robotConsole)
        {
            this.robotConsole = robotConsole;
        }


    }
}