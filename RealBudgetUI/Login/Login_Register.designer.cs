namespace RealBudgetUI.Login
{
    partial class Login_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Register));
            this.lblCurrency = new System.Windows.Forms.Label();
            this.Currency_comboBox = new System.Windows.Forms.ComboBox();
            this.HorizontalTop_panel1 = new System.Windows.Forms.Panel();
            this.InputsflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.lblPass1 = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.TxtPass2 = new System.Windows.Forms.TextBox();
            this.ContainertableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Top_panel = new System.Windows.Forms.Panel();
            this.ImgWarning = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.Buttons_panel2 = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.HorizontalBottom_panel1 = new System.Windows.Forms.Panel();
            this.InputsflowLayoutPanel.SuspendLayout();
            this.ContainertableLayoutPanel.SuspendLayout();
            this.Top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWarning)).BeginInit();
            this.Buttons_panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrency
            // 
            this.lblCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCurrency.Location = new System.Drawing.Point(7, 246);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(86, 21);
            this.lblCurrency.TabIndex = 8;
            this.lblCurrency.Text = "Currency *";
            // 
            // Currency_comboBox
            // 
            this.Currency_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Currency_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Currency_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Currency_comboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currency_comboBox.FormattingEnabled = true;
            this.Currency_comboBox.Items.AddRange(new object[] {
            "€",
            "CHF",
            "$",
            "£"});
            this.Currency_comboBox.Location = new System.Drawing.Point(11, 269);
            this.Currency_comboBox.Margin = new System.Windows.Forms.Padding(4, 2, 0, 8);
            this.Currency_comboBox.Name = "Currency_comboBox";
            this.Currency_comboBox.Size = new System.Drawing.Size(708, 29);
            this.Currency_comboBox.TabIndex = 4;
            // 
            // HorizontalTop_panel1
            // 
            this.HorizontalTop_panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.HorizontalTop_panel1.Location = new System.Drawing.Point(11, 49);
            this.HorizontalTop_panel1.Margin = new System.Windows.Forms.Padding(0);
            this.HorizontalTop_panel1.Name = "HorizontalTop_panel1";
            this.HorizontalTop_panel1.Size = new System.Drawing.Size(708, 2);
            this.HorizontalTop_panel1.TabIndex = 11;
            // 
            // InputsflowLayoutPanel
            // 
            this.InputsflowLayoutPanel.Controls.Add(this.lblEmail);
            this.InputsflowLayoutPanel.Controls.Add(this.TxtEmail);
            this.InputsflowLayoutPanel.Controls.Add(this.lblUsername);
            this.InputsflowLayoutPanel.Controls.Add(this.TxtUsername);
            this.InputsflowLayoutPanel.Controls.Add(this.lblPass1);
            this.InputsflowLayoutPanel.Controls.Add(this.TxtPass);
            this.InputsflowLayoutPanel.Controls.Add(this.lblPass2);
            this.InputsflowLayoutPanel.Controls.Add(this.TxtPass2);
            this.InputsflowLayoutPanel.Controls.Add(this.lblCurrency);
            this.InputsflowLayoutPanel.Controls.Add(this.Currency_comboBox);
            this.InputsflowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputsflowLayoutPanel.Location = new System.Drawing.Point(2, 60);
            this.InputsflowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.InputsflowLayoutPanel.Name = "InputsflowLayoutPanel";
            this.InputsflowLayoutPanel.Padding = new System.Windows.Forms.Padding(7, 6, 0, 0);
            this.InputsflowLayoutPanel.Size = new System.Drawing.Size(727, 307);
            this.InputsflowLayoutPanel.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblEmail.Location = new System.Drawing.Point(7, 6);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 21);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email: *";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(11, 29);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 2, 0, 8);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(708, 29);
            this.TxtEmail.TabIndex = 0;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblUsername.Location = new System.Drawing.Point(7, 66);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(98, 21);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username: *";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(11, 89);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4, 2, 0, 8);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(708, 29);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // lblPass1
            // 
            this.lblPass1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPass1.AutoSize = true;
            this.lblPass1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblPass1.Location = new System.Drawing.Point(7, 126);
            this.lblPass1.Margin = new System.Windows.Forms.Padding(0);
            this.lblPass1.Name = "lblPass1";
            this.lblPass1.Size = new System.Drawing.Size(94, 21);
            this.lblPass1.TabIndex = 4;
            this.lblPass1.Text = "Password: *";
            // 
            // TxtPass
            // 
            this.TxtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(11, 149);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(4, 2, 0, 8);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(708, 29);
            this.TxtPass.TabIndex = 2;
            this.TxtPass.TextChanged += new System.EventHandler(this.TxtPass_TextChanged);
            // 
            // lblPass2
            // 
            this.lblPass2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPass2.AutoSize = true;
            this.lblPass2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblPass2.Location = new System.Drawing.Point(7, 186);
            this.lblPass2.Margin = new System.Windows.Forms.Padding(0);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(157, 21);
            this.lblPass2.TabIndex = 6;
            this.lblPass2.Text = "Confirm Password: *";
            // 
            // TxtPass2
            // 
            this.TxtPass2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPass2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass2.Location = new System.Drawing.Point(11, 209);
            this.TxtPass2.Margin = new System.Windows.Forms.Padding(4, 2, 0, 8);
            this.TxtPass2.Name = "TxtPass2";
            this.TxtPass2.Size = new System.Drawing.Size(708, 29);
            this.TxtPass2.TabIndex = 3;
            this.TxtPass2.TextChanged += new System.EventHandler(this.TxtPass2_TextChanged);
            // 
            // ContainertableLayoutPanel
            // 
            this.ContainertableLayoutPanel.ColumnCount = 1;
            this.ContainertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContainertableLayoutPanel.Controls.Add(this.Top_panel, 0, 0);
            this.ContainertableLayoutPanel.Controls.Add(this.InputsflowLayoutPanel, 0, 1);
            this.ContainertableLayoutPanel.Controls.Add(this.Buttons_panel2, 0, 2);
            this.ContainertableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainertableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ContainertableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ContainertableLayoutPanel.Name = "ContainertableLayoutPanel";
            this.ContainertableLayoutPanel.RowCount = 3;
            this.ContainertableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.ContainertableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContainertableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.ContainertableLayoutPanel.Size = new System.Drawing.Size(731, 435);
            this.ContainertableLayoutPanel.TabIndex = 5;
            // 
            // Top_panel
            // 
            this.Top_panel.Controls.Add(this.HorizontalTop_panel1);
            this.Top_panel.Controls.Add(this.ImgWarning);
            this.Top_panel.Controls.Add(this.lblInfo);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top_panel.Location = new System.Drawing.Point(2, 2);
            this.Top_panel.Margin = new System.Windows.Forms.Padding(2);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(727, 54);
            this.Top_panel.TabIndex = 13;
            // 
            // ImgWarning
            // 
            this.ImgWarning.Image = global::RealBudgetUI.Properties.Resources.icons8_verlassen_40;
            this.ImgWarning.Location = new System.Drawing.Point(8, 2);
            this.ImgWarning.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ImgWarning.Name = "ImgWarning";
            this.ImgWarning.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ImgWarning.Size = new System.Drawing.Size(47, 43);
            this.ImgWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgWarning.TabIndex = 4;
            this.ImgWarning.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInfo.Location = new System.Drawing.Point(61, 15);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(220, 17);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Fields marked with an * are required";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Buttons_panel2
            // 
            this.Buttons_panel2.Controls.Add(this.Btn_Save);
            this.Buttons_panel2.Controls.Add(this.HorizontalBottom_panel1);
            this.Buttons_panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Buttons_panel2.Location = new System.Drawing.Point(2, 372);
            this.Buttons_panel2.Margin = new System.Windows.Forms.Padding(2);
            this.Buttons_panel2.Name = "Buttons_panel2";
            this.Buttons_panel2.Size = new System.Drawing.Size(727, 61);
            this.Buttons_panel2.TabIndex = 14;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Save.Image = global::RealBudgetUI.Properties.Resources.checkmark2_30px;
            this.Btn_Save.Location = new System.Drawing.Point(9, 10);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(710, 43);
            this.Btn_Save.TabIndex = 12;
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // HorizontalBottom_panel1
            // 
            this.HorizontalBottom_panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.HorizontalBottom_panel1.Location = new System.Drawing.Point(11, 2);
            this.HorizontalBottom_panel1.Margin = new System.Windows.Forms.Padding(0);
            this.HorizontalBottom_panel1.Name = "HorizontalBottom_panel1";
            this.HorizontalBottom_panel1.Size = new System.Drawing.Size(708, 2);
            this.HorizontalBottom_panel1.TabIndex = 11;
            // 
            // Login_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(731, 435);
            this.Controls.Add(this.ContainertableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Login_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.InputsflowLayoutPanel.ResumeLayout(false);
            this.InputsflowLayoutPanel.PerformLayout();
            this.ContainertableLayoutPanel.ResumeLayout(false);
            this.Top_panel.ResumeLayout(false);
            this.Top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWarning)).EndInit();
            this.Buttons_panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.ComboBox Currency_comboBox;
        private System.Windows.Forms.Panel HorizontalTop_panel1;
        private System.Windows.Forms.FlowLayoutPanel InputsflowLayoutPanel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label lblPass1;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.TextBox TxtPass2;
        private System.Windows.Forms.TableLayoutPanel ContainertableLayoutPanel;
        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.PictureBox ImgWarning;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel Buttons_panel2;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Panel HorizontalBottom_panel1;
    }
}