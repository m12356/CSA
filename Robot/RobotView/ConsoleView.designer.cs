namespace RobotView
{
    partial class ConsoleView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ledView4 = new RobotView.LedView();
            this.switchView4 = new RobotView.SwitchView();
            this.switchView3 = new RobotView.SwitchView();
            this.switchView2 = new RobotView.SwitchView();
            this.ledView3 = new RobotView.LedView();
            this.ledView2 = new RobotView.LedView();
            this.ledView1 = new RobotView.LedView();
            this.switchView1 = new RobotView.SwitchView();
            this.SuspendLayout();
            // 
            // ledView4
            // 
            this.ledView4.Location = new System.Drawing.Point(81, 3);
            this.ledView4.Name = "ledView4";
            this.ledView4.Size = new System.Drawing.Size(21, 22);
            this.ledView4.TabIndex = 8;
            // 
            // switchView4
            // 
            this.switchView4.Location = new System.Drawing.Point(186, 3);
            this.switchView4.Name = "switchView4";
            this.switchView4.Size = new System.Drawing.Size(20, 40);
            this.switchView4.TabIndex = 7;
            // 
            // switchView3
            // 
            this.switchView3.Location = new System.Drawing.Point(160, 3);
            this.switchView3.Name = "switchView3";
            this.switchView3.Size = new System.Drawing.Size(20, 40);
            this.switchView3.TabIndex = 6;
            // 
            // switchView2
            // 
            this.switchView2.Location = new System.Drawing.Point(134, 3);
            this.switchView2.Name = "switchView2";
            this.switchView2.Size = new System.Drawing.Size(20, 40);
            this.switchView2.TabIndex = 5;
            // 
            // ledView3
            // 
            this.ledView3.Location = new System.Drawing.Point(54, 3);
            this.ledView3.Name = "ledView3";
            this.ledView3.Size = new System.Drawing.Size(21, 22);
            this.ledView3.TabIndex = 3;
            // 
            // ledView2
            // 
            this.ledView2.Location = new System.Drawing.Point(27, 3);
            this.ledView2.Name = "ledView2";
            this.ledView2.Size = new System.Drawing.Size(21, 22);
            this.ledView2.TabIndex = 2;
            // 
            // ledView1
            // 
            this.ledView1.Location = new System.Drawing.Point(0, 3);
            this.ledView1.Name = "ledView1";
            this.ledView1.Size = new System.Drawing.Size(21, 22);
            this.ledView1.TabIndex = 1;
            // 
            // switchView1
            // 
            this.switchView1.Location = new System.Drawing.Point(108, 3);
            this.switchView1.Name = "switchView1";
            this.switchView1.Size = new System.Drawing.Size(20, 40);
            this.switchView1.TabIndex = 4;
            // 
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.ledView4);
            this.Controls.Add(this.switchView4);
            this.Controls.Add(this.switchView3);
            this.Controls.Add(this.switchView2);
            this.Controls.Add(this.ledView3);
            this.Controls.Add(this.ledView2);
            this.Controls.Add(this.ledView1);
            this.Controls.Add(this.switchView1);
            this.Name = "ConsoleView";
            this.Size = new System.Drawing.Size(299, 117);
            this.ResumeLayout(false);

        }


        #endregion
        private LedView ledView1;
        private LedView ledView2;
        private LedView ledView3;
        private SwitchView switchView1;
        private SwitchView switchView2;
        private SwitchView switchView3;
        private SwitchView switchView4;
        private LedView ledView4;
    }
}
