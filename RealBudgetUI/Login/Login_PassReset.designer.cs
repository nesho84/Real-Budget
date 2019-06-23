namespace RealBudgetUI.Login
{
    partial class Login_PassReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_PassReset));
            this.lblUnderTitle = new System.Windows.Forms.Label();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.TxtToEmail = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUnderTitle
            // 
            this.lblUnderTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnderTitle.AutoSize = true;
            this.lblUnderTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblUnderTitle.Location = new System.Drawing.Point(23, 48);
            this.lblUnderTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblUnderTitle.Name = "lblUnderTitle";
            this.lblUnderTitle.Size = new System.Drawing.Size(269, 13);
            this.lblUnderTitle.TabIndex = 11;
            this.lblUnderTitle.Text = "Enter your E-mail you used to create  your Account.";
            this.lblUnderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Send.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Send.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Send.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Send.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Send.Location = new System.Drawing.Point(21, 108);
            this.Btn_Send.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Send.MinimumSize = new System.Drawing.Size(272, 29);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(272, 31);
            this.Btn_Send.TabIndex = 9;
            this.Btn_Send.Text = "SEND";
            this.Btn_Send.UseVisualStyleBackColor = false;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // TxtToEmail
            // 
            this.TxtToEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtToEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtToEmail.Location = new System.Drawing.Point(21, 74);
            this.TxtToEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtToEmail.Multiline = true;
            this.TxtToEmail.Name = "TxtToEmail";
            this.TxtToEmail.Size = new System.Drawing.Size(272, 27);
            this.TxtToEmail.TabIndex = 8;
            this.TxtToEmail.TextChanged += new System.EventHandler(this.Email_txt_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(331, 165);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblUnderTitle);
            this.panel1.Controls.Add(this.Btn_Send);
            this.panel1.Controls.Add(this.TxtToEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 149);
            this.panel1.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(21, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 29);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Password Reset";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_PassReset
            // 
            this.AcceptButton = this.Btn_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(340, 172);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Login_PassReset";
            this.Padding = new System.Windows.Forms.Padding(14, 49, 14, 13);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password reset";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUnderTitle;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.TextBox TxtToEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
    }
}