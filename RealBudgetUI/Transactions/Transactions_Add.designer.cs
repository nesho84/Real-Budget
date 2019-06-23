namespace RealBudgetUI.Transactions
{
    partial class Transactions_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions_Add));
            this.Panel_TopMenu = new System.Windows.Forms.Panel();
            this.Btn_Trans = new System.Windows.Forms.Button();
            this.Btn_Exp = new System.Windows.Forms.Button();
            this.Btn_Income = new System.Windows.Forms.Button();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Trans_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblTitleComment = new System.Windows.Forms.Label();
            this.lblRichTextBoxTitle = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.Panel_To = new System.Windows.Forms.Panel();
            this.lblTo = new System.Windows.Forms.Label();
            this.To_comboBox = new System.Windows.Forms.ComboBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Panel_From = new System.Windows.Forms.Panel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.From_comboBox = new System.Windows.Forms.ComboBox();
            this.RichTxtNotes = new System.Windows.Forms.RichTextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.Panel_TopMenu.SuspendLayout();
            this.Main_Panel.SuspendLayout();
            this.Panel_To.SuspendLayout();
            this.Panel_From.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_TopMenu
            // 
            this.Panel_TopMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Panel_TopMenu.Controls.Add(this.Btn_Trans);
            this.Panel_TopMenu.Controls.Add(this.Btn_Exp);
            this.Panel_TopMenu.Controls.Add(this.Btn_Income);
            this.Panel_TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_TopMenu.Location = new System.Drawing.Point(0, 0);
            this.Panel_TopMenu.Name = "Panel_TopMenu";
            this.Panel_TopMenu.Size = new System.Drawing.Size(401, 108);
            this.Panel_TopMenu.TabIndex = 42;
            // 
            // Btn_Trans
            // 
            this.Btn_Trans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Trans.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Trans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Trans.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Trans.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Trans.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_Trans.Image = global::RealBudgetUI.Properties.Resources.icons8_cashflow_30;
            this.Btn_Trans.Location = new System.Drawing.Point(274, 10);
            this.Btn_Trans.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Trans.Name = "Btn_Trans";
            this.Btn_Trans.Size = new System.Drawing.Size(115, 88);
            this.Btn_Trans.TabIndex = 41;
            this.Btn_Trans.TabStop = false;
            this.Btn_Trans.Text = "TRANSFER";
            this.Btn_Trans.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_Trans.UseVisualStyleBackColor = false;
            this.Btn_Trans.Click += new System.EventHandler(this.Btn_Trans_Click);
            // 
            // Btn_Exp
            // 
            this.Btn_Exp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Exp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Exp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exp.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_Exp.Image = global::RealBudgetUI.Properties.Resources.icons8_karte_verwenden_30;
            this.Btn_Exp.Location = new System.Drawing.Point(143, 10);
            this.Btn_Exp.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Exp.Name = "Btn_Exp";
            this.Btn_Exp.Size = new System.Drawing.Size(115, 88);
            this.Btn_Exp.TabIndex = 40;
            this.Btn_Exp.TabStop = false;
            this.Btn_Exp.Text = "EXPENSE";
            this.Btn_Exp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_Exp.UseVisualStyleBackColor = false;
            this.Btn_Exp.Click += new System.EventHandler(this.Btn_Exp_Click);
            // 
            // Btn_Income
            // 
            this.Btn_Income.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Income.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Income.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Income.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Income.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Income.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_Income.Image = global::RealBudgetUI.Properties.Resources.icons8_anzahlung_30;
            this.Btn_Income.Location = new System.Drawing.Point(12, 10);
            this.Btn_Income.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Income.Name = "Btn_Income";
            this.Btn_Income.Size = new System.Drawing.Size(115, 88);
            this.Btn_Income.TabIndex = 39;
            this.Btn_Income.TabStop = false;
            this.Btn_Income.Text = "INCOME";
            this.Btn_Income.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_Income.UseVisualStyleBackColor = false;
            this.Btn_Income.Click += new System.EventHandler(this.Btn_Income_Click);
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.White;
            this.Main_Panel.Controls.Add(this.Trans_DateTimePicker);
            this.Main_Panel.Controls.Add(this.lblTitleComment);
            this.Main_Panel.Controls.Add(this.lblRichTextBoxTitle);
            this.Main_Panel.Controls.Add(this.txtCurrency);
            this.Main_Panel.Controls.Add(this.Panel_To);
            this.Main_Panel.Controls.Add(this.Btn_Save);
            this.Main_Panel.Controls.Add(this.Panel_From);
            this.Main_Panel.Controls.Add(this.RichTxtNotes);
            this.Main_Panel.Controls.Add(this.txtAmount);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 108);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(401, 408);
            this.Main_Panel.TabIndex = 7;
            // 
            // Trans_DateTimePicker
            // 
            this.Trans_DateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trans_DateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.Trans_DateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Trans_DateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Trans_DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trans_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Trans_DateTimePicker.Location = new System.Drawing.Point(5, 308);
            this.Trans_DateTimePicker.Name = "Trans_DateTimePicker";
            this.Trans_DateTimePicker.Size = new System.Drawing.Size(390, 27);
            this.Trans_DateTimePicker.TabIndex = 10;
            this.Trans_DateTimePicker.TabStop = false;
            // 
            // lblTitleComment
            // 
            this.lblTitleComment.AutoSize = true;
            this.lblTitleComment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleComment.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitleComment.Location = new System.Drawing.Point(3, 199);
            this.lblTitleComment.Name = "lblTitleComment";
            this.lblTitleComment.Size = new System.Drawing.Size(59, 13);
            this.lblTitleComment.TabIndex = 9;
            this.lblTitleComment.Text = "Comment:";
            // 
            // lblRichTextBoxTitle
            // 
            this.lblRichTextBoxTitle.AutoSize = true;
            this.lblRichTextBoxTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRichTextBoxTitle.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblRichTextBoxTitle.Location = new System.Drawing.Point(173, 199);
            this.lblRichTextBoxTitle.Name = "lblRichTextBoxTitle";
            this.lblRichTextBoxTitle.Size = new System.Drawing.Size(224, 13);
            this.lblRichTextBoxTitle.TabIndex = 8;
            this.lblRichTextBoxTitle.Text = "100 Character{s) remaining [100 maximum] ";
            // 
            // txtCurrency
            // 
            this.txtCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrency.Enabled = false;
            this.txtCurrency.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.txtCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurrency.Location = new System.Drawing.Point(289, 112);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(106, 78);
            this.txtCurrency.TabIndex = 7;
            this.txtCurrency.Text = "?";
            this.txtCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Panel_To
            // 
            this.Panel_To.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_To.Controls.Add(this.lblTo);
            this.Panel_To.Controls.Add(this.To_comboBox);
            this.Panel_To.Location = new System.Drawing.Point(202, 6);
            this.Panel_To.Name = "Panel_To";
            this.Panel_To.Size = new System.Drawing.Size(193, 100);
            this.Panel_To.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(9, 6);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 20);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To";
            // 
            // To_comboBox
            // 
            this.To_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.To_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.To_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.To_comboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_comboBox.FormattingEnabled = true;
            this.To_comboBox.Location = new System.Drawing.Point(13, 56);
            this.To_comboBox.Name = "To_comboBox";
            this.To_comboBox.Size = new System.Drawing.Size(165, 28);
            this.To_comboBox.TabIndex = 1;
            this.To_comboBox.TabStop = false;
            this.To_comboBox.SelectedIndexChanged += new System.EventHandler(this.To_comboBox_SelectedIndexChanged);
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Image = global::RealBudgetUI.Properties.Resources.checkmark2_48px;
            this.Btn_Save.Location = new System.Drawing.Point(5, 341);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(390, 61);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Panel_From
            // 
            this.Panel_From.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Panel_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_From.Controls.Add(this.lblFrom);
            this.Panel_From.Controls.Add(this.From_comboBox);
            this.Panel_From.Location = new System.Drawing.Point(5, 6);
            this.Panel_From.Name = "Panel_From";
            this.Panel_From.Size = new System.Drawing.Size(193, 100);
            this.Panel_From.TabIndex = 0;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(9, 6);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(43, 20);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From";
            // 
            // From_comboBox
            // 
            this.From_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.From_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.From_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.From_comboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_comboBox.FormattingEnabled = true;
            this.From_comboBox.Location = new System.Drawing.Point(13, 56);
            this.From_comboBox.Name = "From_comboBox";
            this.From_comboBox.Size = new System.Drawing.Size(165, 28);
            this.From_comboBox.TabIndex = 0;
            this.From_comboBox.TabStop = false;
            this.From_comboBox.SelectedIndexChanged += new System.EventHandler(this.From_comboBox_SelectedIndexChanged);
            // 
            // RichTxtNotes
            // 
            this.RichTxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTxtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RichTxtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RichTxtNotes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RichTxtNotes.Location = new System.Drawing.Point(5, 215);
            this.RichTxtNotes.MaxLength = 100;
            this.RichTxtNotes.Name = "RichTxtNotes";
            this.RichTxtNotes.Size = new System.Drawing.Size(390, 87);
            this.RichTxtNotes.TabIndex = 1;
            this.RichTxtNotes.Tag = "";
            this.RichTxtNotes.Text = "";
            this.RichTxtNotes.TextChanged += new System.EventHandler(this.RichTxtNotes_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.Location = new System.Drawing.Point(5, 112);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(286, 78);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAmount_KeyPress);
            this.txtAmount.Leave += new System.EventHandler(this.TxtAmount_Leave);
            // 
            // Transactions_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 516);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.Panel_TopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Transactions_Add";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Transactions";
            this.Panel_TopMenu.ResumeLayout(false);
            this.Main_Panel.ResumeLayout(false);
            this.Main_Panel.PerformLayout();
            this.Panel_To.ResumeLayout(false);
            this.Panel_To.PerformLayout();
            this.Panel_From.ResumeLayout(false);
            this.Panel_From.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button Btn_Income;
        internal System.Windows.Forms.Button Btn_Exp;
        internal System.Windows.Forms.Button Btn_Trans;
        private System.Windows.Forms.Panel Panel_TopMenu;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel Panel_To;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox To_comboBox;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Panel Panel_From;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox From_comboBox;
        private System.Windows.Forms.RichTextBox RichTxtNotes;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblRichTextBoxTitle;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label lblTitleComment;
        private System.Windows.Forms.DateTimePicker Trans_DateTimePicker;
    }
}