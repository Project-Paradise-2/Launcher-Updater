namespace Project_Paradise_2_Updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            CurrentProgress = new System.Windows.Forms.ProgressBar();
            CurrentState = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(-3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(130, 130);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CurrentProgress
            // 
            CurrentProgress.Location = new System.Drawing.Point(133, 107);
            CurrentProgress.Name = "CurrentProgress";
            CurrentProgress.Size = new System.Drawing.Size(330, 22);
            CurrentProgress.TabIndex = 2;
            // 
            // CurrentState
            // 
            CurrentState.AutoSize = true;
            CurrentState.BackColor = System.Drawing.Color.Transparent;
            CurrentState.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            CurrentState.Location = new System.Drawing.Point(133, 58);
            CurrentState.Name = "CurrentState";
            CurrentState.Size = new System.Drawing.Size(73, 15);
            CurrentState.TabIndex = 3;
            CurrentState.Text = "CurrentState";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            label2.Location = new System.Drawing.Point(133, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(334, 19);
            label2.TabIndex = 4;
            label2.Text = "The launcher is now updating to the latest version";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            label3.Location = new System.Drawing.Point(133, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(275, 19);
            label3.TabIndex = 5;
            label3.Text = "Please wait until the process is complete";
            // 
            // Form1
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ClientSize = new System.Drawing.Size(469, 136);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CurrentState);
            Controls.Add(CurrentProgress);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Launcher Updater";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar CurrentProgress;
        private System.Windows.Forms.Label CurrentState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
