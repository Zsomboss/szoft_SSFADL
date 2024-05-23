namespace MemoriaJaték
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblStatus = new Label();
            lblTimeLeft = new Label();
            btnRestart = new Button();
            GameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(380, 101);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(112, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Találat / Nem találat";
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.AutoSize = true;
            lblTimeLeft.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTimeLeft.Location = new Point(380, 141);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new Size(120, 21);
            lblTimeLeft.TabIndex = 1;
            lblTimeLeft.Text = "Idő maradt: 30";
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(352, 23);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(174, 61);
            btnRestart.TabIndex = 2;
            btnRestart.Text = "Újrakezdés";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += RestartGame;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += TimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 450);
            Controls.Add(btnRestart);
            Controls.Add(lblTimeLeft);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Label lblTimeLeft;
        private Button btnRestart;
        private System.Windows.Forms.Timer GameTimer;
    }
}
