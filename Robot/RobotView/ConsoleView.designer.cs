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
            this.ledView1 = new RobotView.LedView();
            this.ledView2 = new RobotView.LedView();
            this.ledView3 = new RobotView.LedView();
            this.SuspendLayout();
            // 
            // ledView1
            // 
            this.ledView1.Location = new System.Drawing.Point(0, 0);
            this.ledView1.Name = "ledView1";
            this.ledView1.Size = new System.Drawing.Size(21, 22);
            this.ledView1.TabIndex = 1;
            // 
            // ledView2
            // 
            this.ledView2.Location = new System.Drawing.Point(27, 0);
            this.ledView2.Name = "ledView2";
            this.ledView2.Size = new System.Drawing.Size(21, 22);
            this.ledView2.TabIndex = 2;
            // 
            // ledView3
            // 
            this.ledView3.Location = new System.Drawing.Point(54, 0);
            this.ledView3.Name = "ledView3";
            this.ledView3.Size = new System.Drawing.Size(21, 22);
            this.ledView3.TabIndex = 3;
            // 
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.ledView3);
            this.Controls.Add(this.ledView2);
            this.Controls.Add(this.ledView1);
            this.Name = "ConsoleView";
            this.Click += new System.EventHandler(this.ConcoleView_Click);
            this.ResumeLayout(false);

        }


        #endregion
        private LedView ledView1;
        private LedView ledView2;
        private LedView ledView3;
    }
}
