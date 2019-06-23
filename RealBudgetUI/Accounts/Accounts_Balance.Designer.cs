namespace RealBudgetUI.Accounts
{
    partial class Accounts_Balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts_Balance));
            this.lblTitleBalance = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Panel_Currency = new System.Windows.Forms.Panel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.Main_FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.Panel_Currency.SuspendLayout();
            this.Main_FlowLayoutPanel.SuspendLayout();
            this.Panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleBalance
            // 
            this.lblTitleBalance.AutoSize = true;
            this.lblTitleBalance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBalance.ForeColor = System.Drawing.Color.White;
            this.lblTitleBalance.Location = new System.Drawing.Point(159, 25);
            this.lblTitleBalance.Name = "lblTitleBalance";
            this.lblTitleBalance.Size = new System.Drawing.Size(119, 20);
            this.lblTitleBalance.TabIndex = 1;
            this.lblTitleBalance.Text = "Account Balance";
            this.lblTitleBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Image = global::RealBudgetUI.Properties.Resources.checkmark2_48px;
            this.Btn_Save.Location = new System.Drawing.Point(6, 181);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(438, 61);
            this.Btn_Save.TabIndex = 2;
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Panel_Currency
            // 
            this.Panel_Currency.BackColor = System.Drawing.Color.White;
            this.Panel_Currency.Controls.Add(this.txtAmount);
            this.Panel_Currency.Controls.Add(this.txtCurrency);
            this.Panel_Currency.Location = new System.Drawing.Point(3, 94);
            this.Panel_Currency.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Currency.Name = "Panel_Currency";
            this.Panel_Currency.Size = new System.Drawing.Size(444, 84);
            this.Panel_Currency.TabIndex = 45;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.Location = new System.Drawing.Point(3, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(334, 78);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.Leave += new System.EventHandler(this.TxtAmount_Leave);
            // 
            // txtCurrency
            // 
            this.txtCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrency.Enabled = false;
            this.txtCurrency.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.txtCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurrency.Location = new System.Drawing.Point(336, 3);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(105, 78);
            this.txtCurrency.TabIndex = 7;
            this.txtCurrency.TabStop = false;
            this.txtCurrency.Text = "?";
            this.txtCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main_FlowLayoutPanel
            // 
            this.Main_FlowLayoutPanel.Controls.Add(this.Panel_Header);
            this.Main_FlowLayoutPanel.Controls.Add(this.Panel_Currency);
            this.Main_FlowLayoutPanel.Controls.Add(this.Btn_Save);
            this.Main_FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_FlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Main_FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Main_FlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Main_FlowLayoutPanel.Name = "Main_FlowLayoutPanel";
            this.Main_FlowLayoutPanel.Padding = new System.Windows.Forms.Padding(3);
            this.Main_FlowLayoutPanel.Size = new System.Drawing.Size(450, 249);
            this.Main_FlowLayoutPanel.TabIndex = 47;
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Header.Controls.Add(this.lblBalance);
            this.Panel_Header.Controls.Add(this.lblTitleBalance);
            this.Panel_Header.Controls.Add(this.lblAccountName);
            this.Panel_Header.Location = new System.Drawing.Point(6, 6);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(438, 85);
            this.Panel_Header.TabIndex = 1;
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(79, 43);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(278, 31);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "{Balance}";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.ForeColor = System.Drawing.Color.White;
            this.lblAccountName.Location = new System.Drawing.Point(9, 9);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(128, 21);
            this.lblAccountName.TabIndex = 2;
            this.lblAccountName.Text = "{Account Name}";
            // 
            // Accounts_Balance
            // 
            this.AcceptButton = this.Btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 249);
            this.Controls.Add(this.Main_FlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Accounts_Balance";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Balance";
            this.Panel_Currency.ResumeLayout(false);
            this.Panel_Currency.PerformLayout();
            this.Main_FlowLayoutPanel.ResumeLayout(false);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitleBalance;
        private System.Windows.Forms.FlowLayoutPanel Main_FlowLayoutPanel;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Panel Panel_Currency;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtCurrency;
    }
}