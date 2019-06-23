namespace RealBudgetUI
{
    partial class SplashScreen
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
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Splash_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo_PictureBox
            // 
            this.Logo_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo_PictureBox.Image = global::RealBudgetUI.Properties.Resources.RealBudget_SplashScreen_2_BG;
            this.Logo_PictureBox.Location = new System.Drawing.Point(11, 9);
            this.Logo_PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(578, 261);
            this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo_PictureBox.TabIndex = 0;
            this.Logo_PictureBox.TabStop = false;
            // 
            // Splash_ProgressBar
            // 
            this.Splash_ProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Splash_ProgressBar.Location = new System.Drawing.Point(25, 280);
            this.Splash_ProgressBar.MarqueeAnimationSpeed = 40;
            this.Splash_ProgressBar.Name = "Splash_ProgressBar";
            this.Splash_ProgressBar.Size = new System.Drawing.Size(551, 29);
            this.Splash_ProgressBar.Step = 1;
            this.Splash_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Splash_ProgressBar.TabIndex = 10;
            this.Splash_ProgressBar.UseWaitCursor = true;
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Interval = 15;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(600, 330);
            this.Controls.Add(this.Splash_ProgressBar);
            this.Controls.Add(this.Logo_PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private System.Windows.Forms.ProgressBar Splash_ProgressBar;
        private System.Windows.Forms.Timer LoadingTimer;
    }
}