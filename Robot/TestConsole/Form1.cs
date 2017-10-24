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
        RobotCtrl.RobotConsole robotConsole;


        public Form1()
        {
            InitializeComponent();
            this.robotConsole = new RobotCtrl.RobotConsole();
            this.consoleView.RobotConsole = robotConsole;
        }

        private void label3_ParentChanged(object sender, EventArgs e)
        {

        }
    }

}
