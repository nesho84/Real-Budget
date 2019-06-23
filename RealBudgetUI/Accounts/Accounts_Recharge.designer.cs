namespace RealBudgetUI.Accounts
{
    partial class Accounts_Recharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts_Recharge));
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.Panel_from = new System.Windows.Forms.Panel();
            this.lblTitleFrom = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTitleBalance = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Panel_To = new System.Windows.Forms.Panel();
            this.lblTitleTo = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.Acc_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Panel_MainFromTo = new System.Windows.Forms.Panel();
            this.chargeListBox = new System.Windows.Forms.ListBox();
            this.Panel_Currency = new System.Windows.Forms.Panel();
            this.Main_FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.Panel_Top_Buttons = new System.Windows.Forms.Panel();
            this.Btn_FromAccount = new System.Windows.Forms.Button();
            this.Btn_Income = new System.Windows.Forms.Button();
            this.Panel_Comment = new System.Windows.Forms.Panel();
            this.RichTxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblTitleNotes = new System.Windows.Forms.Label();
            this.lblRichTextBoxTitle = new System.Windows.Forms.Label();
            this.Panel_from.SuspendLayout();
            this.Panel_To.SuspendLayout();
            this.Panel_MainFromTo.SuspendLayout();
            this.Panel_Currency.SuspendLayout();
            this.Main_FlowLayoutPanel.SuspendLayout();
            this.Panel_Header.SuspendLayout();
            this.Panel_Top_Buttons.SuspendLayout();
            this.Panel_Comment.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.Location = new System.Drawing.Point(3, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(334, 71);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.Leave += new System.EventHandler(this.TxtAmount_Leave);
            // 
            // Panel_from
            // 
            this.Panel_from.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Panel_from.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_from.Controls.Add(this.lblTitleFrom);
            this.Panel_from.Controls.Add(this.lblFrom);
            this.Panel_from.Location = new System.Drawing.Point(3, 98);
            this.Panel_from.Name = "Panel_from";
            this.Panel_from.Size = new System.Drawing.Size(218, 65);
            this.Panel_from.TabIndex = 1;
            // 
            // lblTitleFrom
            // 
            this.lblTitleFrom.AutoSize = true;
            this.lblTitleFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTitleFrom.ForeColor = System.Drawing.Color.White;
            this.lblTitleFrom.Location = new System.Drawing.Point(12, 4);
            this.lblTitleFrom.Name = "lblTitleFrom";
            this.lblTitleFrom.Size = new System.Drawing.Size(41, 19);
            this.lblTitleFrom.TabIndex = 2;
            this.lblTitleFrom.Text = "From";
            this.lblTitleFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(12, 29);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(56, 21);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "{from}";
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleBalance
            // 
            this.lblTitleBalance.AutoSize = true;
            this.lblTitleBalance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBalance.ForeColor = System.Drawing.Color.White;
            this.lblTitleBalance.Location = new System.Drawing.Point(159, 25);
            this.lblTitleBalance.Name = "lblTitleBalance";
            this.lblTitleBalance.Size = new System.Drawing.Size(119, 20);
            this.lblTitleBalance.TabIndex = 4;
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
            this.Btn_Save.Location = new System.Drawing.Point(6, 515);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(438, 61);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Panel_To
            // 
            this.Panel_To.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_To.Controls.Add(this.lblTitleTo);
            this.Panel_To.Controls.Add(this.lblTo);
            this.Panel_To.Location = new System.Drawing.Point(223, 98);
            this.Panel_To.Name = "Panel_To";
            this.Panel_To.Size = new System.Drawing.Size(218, 65);
            this.Panel_To.TabIndex = 7;
            // 
            // lblTitleTo
            // 
            this.lblTitleTo.AutoSize = true;
            this.lblTitleTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTitleTo.ForeColor = System.Drawing.Color.White;
            this.lblTitleTo.Location = new System.Drawing.Point(13, 4);
            this.lblTitleTo.Name = "lblTitleTo";
            this.lblTitleTo.Size = new System.Drawing.Size(23, 19);
            this.lblTitleTo.TabIndex = 8;
            this.lblTitleTo.Text = "To";
            this.lblTitleTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(13, 29);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(37, 21);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "{To}";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrency
            // 
            this.txtCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrency.Enabled = false;
            this.txtCurrency.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurrency.Location = new System.Drawing.Point(336, 3);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(105, 71);
            this.txtCurrency.TabIndex = 10;
            this.txtCurrency.TabStop = false;
            this.txtCurrency.Text = "?";
            this.txtCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Acc_DateTimePicker
            // 
            this.Acc_DateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc_DateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.Acc_DateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Acc_DateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Acc_DateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.Acc_DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Acc_DateTimePicker.Location = new System.Drawing.Point(6, 482);
            this.Acc_DateTimePicker.Name = "Acc_DateTimePicker";
            this.Acc_DateTimePicker.Size = new System.Drawing.Size(438, 27);
            this.Acc_DateTimePicker.TabIndex = 2;
            this.Acc_DateTimePicker.TabStop = false;
            // 
            // Panel_MainFromTo
            // 
            this.Panel_MainFromTo.BackColor = System.Drawing.Color.White;
            this.Panel_MainFromTo.Controls.Add(this.chargeListBox);
            this.Panel_MainFromTo.Controls.Add(this.Panel_To);
            this.Panel_MainFromTo.Controls.Add(this.Panel_from);
            this.Panel_MainFromTo.Location = new System.Drawing.Point(3, 147);
            this.Panel_MainFromTo.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_MainFromTo.Name = "Panel_MainFromTo";
            this.Panel_MainFromTo.Size = new System.Drawing.Size(444, 167);
            this.Panel_MainFromTo.TabIndex = 12;
            // 
            // chargeListBox
            // 
            this.chargeListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chargeListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargeListBox.FormattingEnabled = true;
            this.chargeListBox.ItemHeight = 21;
            this.chargeListBox.Location = new System.Drawing.Point(3, 3);
            this.chargeListBox.Name = "chargeListBox";
            this.chargeListBox.ScrollAlwaysVisible = true;
            this.chargeListBox.Size = new System.Drawing.Size(438, 88);
            this.chargeListBox.TabIndex = 8;
            this.chargeListBox.SelectedIndexChanged += new System.EventHandler(this.ChargeListBox_SelectedIndexChanged);
            // 
            // Panel_Currency
            // 
            this.Panel_Currency.BackColor = System.Drawing.Color.White;
            this.Panel_Currency.Controls.Add(this.txtAmount);
            this.Panel_Currency.Controls.Add(this.txtCurrency);
            this.Panel_Currency.Location = new System.Drawing.Point(3, 314);
            this.Panel_Currency.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Currency.Name = "Panel_Currency";
            this.Panel_Currency.Size = new System.Drawing.Size(444, 77);
            this.Panel_Currency.TabIndex = 13;
            // 
            // Main_FlowLayoutPanel
            // 
            this.Main_FlowLayoutPanel.AutoSize = true;
            this.Main_FlowLayoutPanel.Controls.Add(this.Panel_Header);
            this.Main_FlowLayoutPanel.Controls.Add(this.Panel_Top_Buttons);
            this.Main_FlowLayoutPanel.Controls.Add(this.Panel_MainFromTo);
            this.Main_FlowLayoutPanel.Controls.Add(this.Panel_Currency);
            this.Main_FlowLayoutPanel.Controls.Add(this.Panel_Comment);
            this.Main_FlowLayoutPanel.Controls.Add(this.Acc_DateTimePicker);
            this.Main_FlowLayoutPanel.Controls.Add(this.Btn_Save);
            this.Main_FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_FlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Main_FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Main_FlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Main_FlowLayoutPanel.Name = "Main_FlowLayoutPanel";
            this.Main_FlowLayoutPanel.Padding = new System.Windows.Forms.Padding(3);
            this.Main_FlowLayoutPanel.Size = new System.Drawing.Size(451, 582);
            this.Main_FlowLayoutPanel.TabIndex = 14;
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
            this.Panel_Header.Size = new System.Drawing.Size(439, 85);
            this.Panel_Header.TabIndex = 15;
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(79, 43);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(278, 31);
            this.lblBalance.TabIndex = 16;
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
            this.lblAccountName.Size = new System.Drawing.Size(63, 21);
            this.lblAccountName.TabIndex = 17;
            this.lblAccountName.Text = "{Name}";
            // 
            // Panel_Top_Buttons
            // 
            this.Panel_Top_Buttons.BackColor = System.Drawing.Color.White;
            this.Panel_Top_Buttons.Controls.Add(this.Btn_FromAccount);
            this.Panel_Top_Buttons.Controls.Add(this.Btn_Income);
            this.Panel_Top_Buttons.Location = new System.Drawing.Point(3, 94);
            this.Panel_Top_Buttons.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Top_Buttons.Name = "Panel_Top_Buttons";
            this.Panel_Top_Buttons.Size = new System.Drawing.Size(444, 53);
            this.Panel_Top_Buttons.TabIndex = 18;
            // 
            // Btn_FromAccount
            // 
            this.Btn_FromAccount.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_FromAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_FromAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FromAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F, System.Drawing.FontStyle.Bold);
            this.Btn_FromAccount.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_FromAccount.Location = new System.Drawing.Point(223, 3);
            this.Btn_FromAccount.Name = "Btn_FromAccount";
            this.Btn_FromAccount.Size = new System.Drawing.Size(218, 47);
            this.Btn_FromAccount.TabIndex = 19;
            this.Btn_FromAccount.TabStop = false;
            this.Btn_FromAccount.Text = "FROM ACCOUNT";
            this.Btn_FromAccount.UseVisualStyleBackColor = false;
            this.Btn_FromAccount.Click += new System.EventHandler(this.Btn_FromAccount_Click);
            // 
            // Btn_Income
            // 
            this.Btn_Income.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Income.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Income.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Income.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Income.Location = new System.Drawing.Point(3, 3);
            this.Btn_Income.Name = "Btn_Income";
            this.Btn_Income.Size = new System.Drawing.Size(218, 47);
            this.Btn_Income.TabIndex = 20;
            this.Btn_Income.TabStop = false;
            this.Btn_Income.Text = "INCOME";
            this.Btn_Income.UseVisualStyleBackColor = false;
            this.Btn_Income.Click += new System.EventHandler(this.Btn_Income_Click);
            // 
            // Panel_Comment
            // 
            this.Panel_Comment.BackColor = System.Drawing.Color.White;
            this.Panel_Comment.Controls.Add(this.RichTxtNotes);
            this.Panel_Comment.Controls.Add(this.lblTitleNotes);
            this.Panel_Comment.Controls.Add(this.lblRichTextBoxTitle);
            this.Panel_Comment.Location = new System.Drawing.Point(3, 391);
            this.Panel_Comment.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Comment.Name = "Panel_Comment";
            this.Panel_Comment.Size = new System.Drawing.Size(444, 88);
            this.Panel_Comment.TabIndex = 21;
            // 
            // RichTxtNotes
            // 
            this.RichTxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTxtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RichTxtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RichTxtNotes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RichTxtNotes.Location = new System.Drawing.Point(3, 21);
            this.RichTxtNotes.MaxLength = 100;
            this.RichTxtNotes.Name = "RichTxtNotes";
            this.RichTxtNotes.Size = new System.Drawing.Size(438, 64);
            this.RichTxtNotes.TabIndex = 24;
            this.RichTxtNotes.Tag = "";
            this.RichTxtNotes.Text = "";
            this.RichTxtNotes.TextChanged += new System.EventHandler(this.RichTxtNotes_TextChanged);
            // 
            // lblTitleNotes
            // 
            this.lblTitleNotes.AutoSize = true;
            this.lblTitleNotes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleNotes.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitleNotes.Location = new System.Drawing.Point(3, 5);
            this.lblTitleNotes.Name = "lblTitleNotes";
            this.lblTitleNotes.Size = new System.Drawing.Size(40, 13);
            this.lblTitleNotes.TabIndex = 22;
            this.lblTitleNotes.Text = "Notes:";
            // 
            // lblRichTextBoxTitle
            // 
            this.lblRichTextBoxTitle.AutoSize = true;
            this.lblRichTextBoxTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRichTextBoxTitle.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblRichTextBoxTitle.Location = new System.Drawing.Point(217, 5);
            this.lblRichTextBoxTitle.Name = "lblRichTextBoxTitle";
            this.lblRichTextBoxTitle.Size = new System.Drawing.Size(224, 13);
            this.lblRichTextBoxTitle.TabIndex = 23;
            this.lblRichTextBoxTitle.Text = "100 Character{s) remaining [100 maximum] ";
            // 
            // Accounts_Recharge
            // 
            this.AcceptButton = this.Btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 582);
            this.Controls.Add(this.Main_FlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Accounts_Recharge";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Recharge";
            this.Panel_from.ResumeLayout(false);
            this.Panel_from.PerformLayout();
            this.Panel_To.ResumeLayout(false);
            this.Panel_To.PerformLayout();
            this.Panel_MainFromTo.ResumeLayout(false);
            this.Panel_Currency.ResumeLayout(false);
            this.Panel_Currency.PerformLayout();
            this.Main_FlowLayoutPanel.ResumeLayout(false);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.Panel_Top_Buttons.ResumeLayout(false);
            this.Panel_Comment.ResumeLayout(false);
            this.Panel_Comment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Panel_from;
        private System.Windows.Forms.Label lblTitleBalance;
        private System.Windows.Forms.Panel Panel_To;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.FlowLayoutPanel Main_FlowLayoutPanel;
        private System.Windows.Forms.Button Btn_FromAccount;
        private System.Windows.Forms.Button Btn_Income;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.DateTimePicker Acc_DateTimePicker;
        private System.Windows.Forms.Panel Panel_MainFromTo;
        private System.Windows.Forms.Panel Panel_Currency;
        private System.Windows.Forms.Panel Panel_Top_Buttons;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblTitleFrom;
        private System.Windows.Forms.Label lblTitleTo;
        private System.Windows.Forms.Panel Panel_Comment;
        private System.Windows.Forms.Label lblTitleNotes;
        private System.Windows.Forms.Label lblRichTextBoxTitle;
        private System.Windows.Forms.ListBox chargeListBox;
        private System.Windows.Forms.RichTextBox RichTxtNotes;
    }
}