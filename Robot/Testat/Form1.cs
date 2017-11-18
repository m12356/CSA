using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotView;
using RobotCtrl;

namespace Testat
{
    public partial class Form1 : Form
    {
        private Drive drive;
        RobotConsole robotConsole;

        public Form1()
        {
            InitializeComponent();
            this.robotConsole = new RobotCtrl.RobotConsole();
            this.consoleView.RobotConsole = robotConsole;
            robotConsole[Switches.Switch1].SwitchStateChanged += Form1_SwitchStateChanged;
            robotConsole[Switches.Switch1].SwitchStateChanged += MyRunArc;
            robotConsole[Switches.Switch2].SwitchStateChanged += Form1_SwitchStateChanged;
            robotConsole[Switches.Switch2].SwitchStateChanged += MyRunTurn;
            robotConsole[Switches.Switch3].SwitchStateChanged += Form1_SwitchStateChanged;
            robotConsole[Switches.Switch3].SwitchStateChanged += MyRunLine;
            robotConsole[Switches.Switch4].SwitchStateChanged += Form1_SwitchStateChanged;
            this.commonRunParameters.SpeedChanged += CommonRunParameters1_SpeedChanged;
            this.commonRunParameters.AccelerationChanged += CommonRunParameters1_AccelerationChanged;
            this.drive = new Drive();
            this.drive.Power = true;
            this.driveView.Drive = drive;
            this.runLine.Drive = drive;
            this.runArc.Drive = drive;
            this.runTurn.Drive = drive;

            CommonRunParameters1_AccelerationChanged(null, EventArgs.Empty);
            CommonRunParameters1_SpeedChanged(null, EventArgs.Empty);
        }
        private void CommonRunParameters1_AccelerationChanged(object sender, EventArgs e)
        {
            this.runLine.Acceleration = this.commonRunParameters.Acceleration;
            this.runArc.Acceleration = this.commonRunParameters.Acceleration;
            this.runTurn.Acceleration = this.commonRunParameters.Acceleration;
        }

        private void CommonRunParameters1_SpeedChanged(object sender, EventArgs e)
        {
            this.runLine.Speed = this.commonRunParameters.Speed;
            this.runArc.Speed = this.commonRunParameters.Speed;
            this.runTurn.Speed = this.commonRunParameters.Speed;
        }


        private void MyRunLine(object sender, EventArgs e)
        {
            runLine.Start();
        }

        private void MyRunArc(object sender, EventArgs e)
        {
            runArc.Start();
        }

        private void MyRunTurn(object sender, EventArgs e)
        {
            runTurn.Start();
        }


        private void Form1_SwitchStateChanged(object sender, SwitchEventArgs e)
        {
            robotConsole[(Leds)(int)e.Swi].LedEnabled = e.SwitchEnabled;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            drive.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drive.Halt();
        }
    }
}
