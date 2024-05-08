namespace Square_Chaser
{
    partial class squarechaser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(squarechaser));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.p1scoreLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.p2scoreLabel = new System.Windows.Forms.Label();
            this.p2boostTimer = new System.Windows.Forms.Timer(this.components);
            this.p1boostTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // p1scoreLabel
            // 
            this.p1scoreLabel.AutoSize = true;
            this.p1scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p1scoreLabel.ForeColor = System.Drawing.Color.White;
            this.p1scoreLabel.Location = new System.Drawing.Point(200, 10);
            this.p1scoreLabel.Name = "p1scoreLabel";
            this.p1scoreLabel.Size = new System.Drawing.Size(13, 13);
            this.p1scoreLabel.TabIndex = 0;
            this.p1scoreLabel.Text = "0";
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(219, 10);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(75, 13);
            this.winLabel.TabIndex = 1;
            this.winLabel.Text = "...";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p2scoreLabel
            // 
            this.p2scoreLabel.AutoSize = true;
            this.p2scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p2scoreLabel.ForeColor = System.Drawing.Color.White;
            this.p2scoreLabel.Location = new System.Drawing.Point(300, 10);
            this.p2scoreLabel.Name = "p2scoreLabel";
            this.p2scoreLabel.Size = new System.Drawing.Size(13, 13);
            this.p2scoreLabel.TabIndex = 2;
            this.p2scoreLabel.Text = "0";
            // 
            // p2boostTimer
            // 
            this.p2boostTimer.Interval = 2500;
            this.p2boostTimer.Tick += new System.EventHandler(this.p2boostTimer_Tick);
            // 
            // p1boostTimer
            // 
            this.p1boostTimer.Interval = 2500;
            this.p1boostTimer.Tick += new System.EventHandler(this.p1boostTimer_Tick);
            // 
            // squarechaser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.p2scoreLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.p1scoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "squarechaser";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.squarechaser_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.squarechaser_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label p1scoreLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label p2scoreLabel;
        private System.Windows.Forms.Timer p2boostTimer;
        private System.Windows.Forms.Timer p1boostTimer;
    }
}

