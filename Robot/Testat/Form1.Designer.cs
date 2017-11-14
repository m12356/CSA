using RobotView;

namespace Testat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.driveView = new RobotView.DriveView();
            this.consoleView = new RobotView.ConsoleView();
            this.commonRunParameters = new RobotView.CommonRunParameters();
            this.runLine = new RobotView.RunLine();
            this.runTurn = new RobotView.RunTurn();
            this.runArc = new RobotView.RunArc();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Halt";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            // 
            // driveView
            // 
            this.driveView.Drive = null;
            this.driveView.Location = new System.Drawing.Point(4, 4);
            this.driveView.Name = "driveView";
            this.driveView.Size = new System.Drawing.Size(365, 361);
            this.driveView.TabIndex = 0;
            // 
            // consoleView
            // 
            this.consoleView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.consoleView.Location = new System.Drawing.Point(13, 419);
            this.consoleView.Name = "consoleView";
            this.consoleView.RobotConsole = null;
            this.consoleView.Size = new System.Drawing.Size(282, 79);
            this.consoleView.TabIndex = 0;
            // 
            // commonRunParameters
            // 
            this.commonRunParameters.Acceleration = 0.3F;
            this.commonRunParameters.Location = new System.Drawing.Point(451, 14);
            this.commonRunParameters.Name = "commonRunParameters";
            this.commonRunParameters.Size = new System.Drawing.Size(439, 114);
            this.commonRunParameters.Speed = 0.5F;
            this.commonRunParameters.TabIndex = 0;
            // 
            // runLine
            // 
            this.runLine.Acceleration = 0F;
            this.runLine.Drive = null;
            this.runLine.Length = 1F;
            this.runLine.Location = new System.Drawing.Point(451, 155);
            this.runLine.Name = "runLine";
            this.runLine.Size = new System.Drawing.Size(439, 58);
            this.runLine.Speed = 0F;
            this.runLine.TabIndex = 0;
            // 
            // runTurn
            // 
            this.runTurn.Acceleration = 0F;
            this.runTurn.Drive = null;
            this.runTurn.Location = new System.Drawing.Point(451, 251);
            this.runTurn.Name = "runTurn";
            this.runTurn.Size = new System.Drawing.Size(441, 56);
            this.runTurn.Speed = 0F;
            this.runTurn.TabIndex = 0;
            // 
            // runArc
            // 
            this.runArc.Acceleration = 0F;
            this.runArc.Drive = null;
            this.runArc.Location = new System.Drawing.Point(451, 333);
            this.runArc.Name = "runArc";
            this.runArc.Size = new System.Drawing.Size(439, 112);
            this.runArc.Speed = 0F;
            this.runArc.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(933, 573);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.consoleView);
            this.Controls.Add(this.driveView);
            this.Controls.Add(this.commonRunParameters);
            this.Controls.Add(this.runLine);
            this.Controls.Add(this.runTurn);
            this.Controls.Add(this.runArc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ConsoleView consoleView;
        private DriveView driveView;
        private CommonRunParameters commonRunParameters;
        private RunLine runLine;
        private RunTurn runTurn;
        private RunArc runArc;
        private System.Windows.Forms.Button button2;
    }
}

