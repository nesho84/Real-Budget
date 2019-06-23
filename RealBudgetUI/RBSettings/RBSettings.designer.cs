namespace RealBudgetUI.RBSettings
{
    partial class RBSettings
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
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Buttons_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_AutoLogin = new System.Windows.Forms.Button();
            this.Btn_Theme = new System.Windows.Forms.Button();
            this.Btn_Language = new System.Windows.Forms.Button();
            this.Btn_EmailSettings = new System.Windows.Forms.Button();
            this.Btn_Delete_Data = new System.Windows.Forms.Button();
            this.Btn_Database = new System.Windows.Forms.Button();
            this.Btn_Backup = new System.Windows.Forms.Button();
            this.Btn_Export_CSV = new System.Windows.Forms.Button();
            this.Main_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Main_Panel.SuspendLayout();
            this.Buttons_flowLayoutPanel.SuspendLayout();
            this.Main_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Main_Panel.BackColor = System.Drawing.Color.White;
            this.Main_Panel.Controls.Add(this.Buttons_flowLayoutPanel);
            this.Main_Panel.Location = new System.Drawing.Point(20, 20);
            this.Main_Panel.Margin = new System.Windows.Forms.Padding(20);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(968, 437);
            this.Main_Panel.TabIndex = 41;
            // 
            // Buttons_flowLayoutPanel
            // 
            this.Buttons_flowLayoutPanel.Controls.Add(this.Btn_AutoLogin);
            this.Buttons_flowLayoutPanel.Controls.Add(this.Btn_Theme);
            this.Buttons_flowLayoutPanel.Controls.Add(this.Btn_Language);
            this.Buttons_flowLayoutPanel.Controls.Add(this.Btn_EmailSettings);
            this.Buttons_flowLayoutPanel.Controls.Add(this.Btn_Delete_Data);
            this.Buttons_flowLayoutPanel.Controls.Add(this.Btn_Database);
            this.Buttons_flowLayoutPanel.Controls.Add(this.Btn_Backup);
            this.Buttons_flowLayoutPanel.Controls.Add(this.Btn_Export_CSV);
            this.Buttons_flowLayoutPanel.Location = new System.Drawing.Point(31, 26);
            this.Buttons_flowLayoutPanel.MaximumSize = new System.Drawing.Size(968, 437);
            this.Buttons_flowLayoutPanel.Name = "Buttons_flowLayoutPanel";
            this.Buttons_flowLayoutPanel.Size = new System.Drawing.Size(906, 385);
            this.Buttons_flowLayoutPanel.TabIndex = 45;
            // 
            // Btn_AutoLogin
            // 
            this.Btn_AutoLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_AutoLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.Btn_AutoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AutoLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_AutoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AutoLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold);
            this.Btn_AutoLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_AutoLogin.Image = global::RealBudgetUI.Properties.Resources.lock_40px;
            this.Btn_AutoLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AutoLogin.Location = new System.Drawing.Point(5, 5);
            this.Btn_AutoLogin.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Btn_AutoLogin.Name = "Btn_AutoLogin";
            this.Btn_AutoLogin.Size = new System.Drawing.Size(220, 90);
            this.Btn_AutoLogin.TabIndex = 30;
            this.Btn_AutoLogin.Text = "       Automatic Login   \r\n    (Enable and Disable)";
            this.Btn_AutoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_AutoLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_AutoLogin.UseVisualStyleBackColor = false;
            this.Btn_AutoLogin.Click += new System.EventHandler(this.Btn_AutoLogin_Click);
            // 
            // Btn_Theme
            // 
            this.Btn_Theme.BackColor = System.Drawing.Color.SkyBlue;
            this.Btn_Theme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Theme.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Theme.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Theme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Theme.Image = global::RealBudgetUI.Properties.Resources.theme_icons_40px;
            this.Btn_Theme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Theme.Location = new System.Drawing.Point(230, 5);
            this.Btn_Theme.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Btn_Theme.Name = "Btn_Theme";
            this.Btn_Theme.Size = new System.Drawing.Size(220, 90);
            this.Btn_Theme.TabIndex = 34;
            this.Btn_Theme.Text = "   Theme";
            this.Btn_Theme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Theme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Theme.UseVisualStyleBackColor = false;
            this.Btn_Theme.Click += new System.EventHandler(this.Btn_Theme_Click);
            // 
            // Btn_Language
            // 
            this.Btn_Language.BackColor = System.Drawing.Color.SkyBlue;
            this.Btn_Language.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Language.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Language.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Language.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Language.Image = global::RealBudgetUI.Properties.Resources.language_40px;
            this.Btn_Language.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Language.Location = new System.Drawing.Point(455, 5);
            this.Btn_Language.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Btn_Language.Name = "Btn_Language";
            this.Btn_Language.Size = new System.Drawing.Size(220, 90);
            this.Btn_Language.TabIndex = 29;
            this.Btn_Language.Text = "   Language";
            this.Btn_Language.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Language.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Language.UseVisualStyleBackColor = false;
            this.Btn_Language.Click += new System.EventHandler(this.Btn_Language_Click);
            // 
            // Btn_EmailSettings
            // 
            this.Btn_EmailSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_EmailSettings.BackColor = System.Drawing.Color.SkyBlue;
            this.Btn_EmailSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_EmailSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_EmailSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_EmailSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EmailSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.Btn_EmailSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_EmailSettings.Image = global::RealBudgetUI.Properties.Resources.icons8_antworten_40;
            this.Btn_EmailSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_EmailSettings.Location = new System.Drawing.Point(680, 5);
            this.Btn_EmailSettings.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Btn_EmailSettings.Name = "Btn_EmailSettings";
            this.Btn_EmailSettings.Size = new System.Drawing.Size(220, 90);
            this.Btn_EmailSettings.TabIndex = 41;
            this.Btn_EmailSettings.Text = "   Software Email";
            this.Btn_EmailSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EmailSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_EmailSettings.UseVisualStyleBackColor = false;
            this.Btn_EmailSettings.Click += new System.EventHandler(this.Btn_EmailSettings_Click);
            // 
            // Btn_Delete_Data
            // 
            this.Btn_Delete_Data.BackColor = System.Drawing.Color.SkyBlue;
            this.Btn_Delete_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete_Data.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Delete_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete_Data.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Delete_Data.Image = global::RealBudgetUI.Properties.Resources.delete_2_40px;
            this.Btn_Delete_Data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete_Data.Location = new System.Drawing.Point(5, 100);
            this.Btn_Delete_Data.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Btn_Delete_Data.Name = "Btn_Delete_Data";
            this.Btn_Delete_Data.Size = new System.Drawing.Size(220, 90);
            this.Btn_Delete_Data.TabIndex = 35;
            this.Btn_Delete_Data.Text = "   Delete data";
            this.Btn_Delete_Data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Delete_Data.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Delete_Data.UseVisualStyleBackColor = false;
            this.Btn_Delete_Data.Click += new System.EventHandler(this.Btn_Currency_Click);
            // 
            // Btn_Database
            // 
            this.Btn_Database.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Database.BackColor = System.Drawing.Color.SkyBlue;
            this.Btn_Database.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Database.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Database.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Database.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Database.Image = global::RealBudgetUI.Properties.Resources.database_configuration_40px;
            this.Btn_Database.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Database.Location = new System.Drawing.Point(230, 100);
            this.Btn_Database.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Btn_Database.Name = "Btn_Database";
            this.Btn_Database.Size = new System.Drawing.Size(220, 90);
            this.Btn_Database.TabIndex = 41;
            this.Btn_Database.Text = "   Database Location";
            this.Btn_Database.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Database.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Database.UseVisualStyleBackColor = false;
            this.Btn_Database.Click += new System.EventHandler(this.Btn_Database_Click);
            // 
            // Btn_Backup
            // 
            this.Btn_Backup.BackColor = System.Drawing.Color.SkyBlue;
            this.Btn_Backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Backup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Backup.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Backup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Backup.Image = global::RealBudgetUI.Properties.Resources.backup_storage_40px;
            this.Btn_Backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Backup.Location = new System.Drawing.Point(455, 100);
            this.Btn_Backup.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Btn_Backup.Name = "Btn_Backup";
            this.Btn_Backup.Size = new System.Drawing.Size(220, 90);
            this.Btn_Backup.TabIndex = 36;
            this.Btn_Backup.Text = "   Backup data";
            this.Btn_Backup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Backup.UseVisualStyleBackColor = false;
            this.Btn_Backup.Click += new System.EventHandler(this.Btn_Backup_Click);
            // 
            // Btn_Export_CSV
            // 
            this.Btn_Export_CSV.BackColor = System.Drawing.Color.SkyBlue;
            this.Btn_Export_CSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Export_CSV.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Export_CSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Export_CSV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Export_CSV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Export_CSV.Image = global::RealBudgetUI.Properties.Resources.export_csv_40px;
            this.Btn_Export_CSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Export_CSV.Location = new System.Drawing.Point(680, 100);
            this.Btn_Export_CSV.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Btn_Export_CSV.Name = "Btn_Export_CSV";
            this.Btn_Export_CSV.Size = new System.Drawing.Size(220, 90);
            this.Btn_Export_CSV.TabIndex = 39;
            this.Btn_Export_CSV.Text = "   Export to CSV";
            this.Btn_Export_CSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Export_CSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Export_CSV.UseVisualStyleBackColor = false;
            this.Btn_Export_CSV.Click += new System.EventHandler(this.Btn_Notifications_Click);
            // 
            // Main_tableLayoutPanel
            // 
            this.Main_tableLayoutPanel.ColumnCount = 1;
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Main_tableLayoutPanel.Controls.Add(this.Main_Panel, 0, 0);
            this.Main_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Main_tableLayoutPanel.Name = "Main_tableLayoutPanel";
            this.Main_tableLayoutPanel.RowCount = 1;
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Main_tableLayoutPanel.Size = new System.Drawing.Size(1008, 477);
            this.Main_tableLayoutPanel.TabIndex = 42;
            // 
            // RBSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.Main_tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "RBSettings";
            this.Size = new System.Drawing.Size(1008, 477);
            this.Main_Panel.ResumeLayout(false);
            this.Buttons_flowLayoutPanel.ResumeLayout(false);
            this.Main_tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Export_CSV;
        private System.Windows.Forms.Button Btn_Language;
        private System.Windows.Forms.Button Btn_Backup;
        private System.Windows.Forms.Button Btn_Delete_Data;
        private System.Windows.Forms.Button Btn_Theme;
        private System.Windows.Forms.Button Btn_AutoLogin;
        private System.Windows.Forms.Button Btn_Database;
        private System.Windows.Forms.Button Btn_EmailSettings;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.TableLayoutPanel Main_tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel Buttons_flowLayoutPanel;
    }
}