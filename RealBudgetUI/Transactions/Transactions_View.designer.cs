namespace RealBudgetUI.Transactions
{
    partial class Transactions_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions_View));
            this.lblFrom = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Panel_From = new System.Windows.Forms.Panel();
            this.Trans_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblTitleNotes = new System.Windows.Forms.Label();
            this.Panel_To = new System.Windows.Forms.Panel();
            this.lblTo = new System.Windows.Forms.Label();
            this.RichTxtNotes = new System.Windows.Forms.RichTextBox();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Panel_TopMenu = new System.Windows.Forms.Panel();
            this.lblTitleAmount = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTransType = new System.Windows.Forms.Label();
            this.lblRichTextBoxTitle = new System.Windows.Forms.Label();
            this.Panel_From.SuspendLayout();
            this.Panel_To.SuspendLayout();
            this.Main_Panel.SuspendLayout();
            this.Panel_TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(14, 19);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(43, 20);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From";
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Image = global::RealBudgetUI.Properties.Resources.checkmark2_48px;
            this.Btn_Save.Location = new System.Drawing.Point(5, 232);
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
            this.Panel_From.Location = new System.Drawing.Point(5, 6);
            this.Panel_From.Name = "Panel_From";
            this.Panel_From.Size = new System.Drawing.Size(193, 80);
            this.Panel_From.TabIndex = 0;
            // 
            // Trans_DateTimePicker
            // 
            this.Trans_DateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trans_DateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.Trans_DateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Trans_DateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Trans_DateTimePicker.Enabled = false;
            this.Trans_DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trans_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Trans_DateTimePicker.Location = new System.Drawing.Point(5, 199);
            this.Trans_DateTimePicker.Name = "Trans_DateTimePicker";
            this.Trans_DateTimePicker.Size = new System.Drawing.Size(390, 27);
            this.Trans_DateTimePicker.TabIndex = 10;
            this.Trans_DateTimePicker.TabStop = false;
            // 
            // lblTitleNotes
            // 
            this.lblTitleNotes.AutoSize = true;
            this.lblTitleNotes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleNotes.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitleNotes.Location = new System.Drawing.Point(3, 90);
            this.lblTitleNotes.Name = "lblTitleNotes";
            this.lblTitleNotes.Size = new System.Drawing.Size(40, 13);
            this.lblTitleNotes.TabIndex = 9;
            this.lblTitleNotes.Text = "Notes:";
            // 
            // Panel_To
            // 
            this.Panel_To.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_To.Controls.Add(this.lblTo);
            this.Panel_To.Location = new System.Drawing.Point(202, 6);
            this.Panel_To.Name = "Panel_To";
            this.Panel_To.Size = new System.Drawing.Size(193, 80);
            this.Panel_To.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(14, 19);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 20);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To";
            // 
            // RichTxtNotes
            // 
            this.RichTxtNotes.BackColor = System.Drawing.Color.White;
            this.RichTxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTxtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RichTxtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RichTxtNotes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RichTxtNotes.Location = new System.Drawing.Point(5, 106);
            this.RichTxtNotes.MaxLength = 100;
            this.RichTxtNotes.Name = "RichTxtNotes";
            this.RichTxtNotes.Size = new System.Drawing.Size(390, 87);
            this.RichTxtNotes.TabIndex = 1;
            this.RichTxtNotes.TabStop = false;
            this.RichTxtNotes.Tag = "";
            this.RichTxtNotes.Text = "";
            this.RichTxtNotes.TextChanged += new System.EventHandler(this.RichTxtNotes_TextChanged);
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.White;
            this.Main_Panel.Controls.Add(this.lblRichTextBoxTitle);
            this.Main_Panel.Controls.Add(this.Trans_DateTimePicker);
            this.Main_Panel.Controls.Add(this.lblTitleNotes);
            this.Main_Panel.Controls.Add(this.Panel_To);
            this.Main_Panel.Controls.Add(this.Btn_Save);
            this.Main_Panel.Controls.Add(this.Panel_From);
            this.Main_Panel.Controls.Add(this.RichTxtNotes);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 108);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(401, 299);
            this.Main_Panel.TabIndex = 43;
            // 
            // Panel_TopMenu
            // 
            this.Panel_TopMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Panel_TopMenu.Controls.Add(this.lblTitleAmount);
            this.Panel_TopMenu.Controls.Add(this.lblAmount);
            this.Panel_TopMenu.Controls.Add(this.lblTransType);
            this.Panel_TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_TopMenu.Location = new System.Drawing.Point(0, 0);
            this.Panel_TopMenu.Name = "Panel_TopMenu";
            this.Panel_TopMenu.Size = new System.Drawing.Size(401, 108);
            this.Panel_TopMenu.TabIndex = 44;
            // 
            // lblTitleAmount
            // 
            this.lblTitleAmount.AutoSize = true;
            this.lblTitleAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblTitleAmount.ForeColor = System.Drawing.Color.White;
            this.lblTitleAmount.Location = new System.Drawing.Point(153, 23);
            this.lblTitleAmount.Name = "lblTitleAmount";
            this.lblTitleAmount.Size = new System.Drawing.Size(94, 30);
            this.lblTitleAmount.TabIndex = 21;
            this.lblTitleAmount.Text = "Amount";
            this.lblTitleAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(66, 53);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(268, 41);
            this.lblAmount.TabIndex = 19;
            this.lblAmount.Text = "{Amount}";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransType
            // 
            this.lblTransType.AutoSize = true;
            this.lblTransType.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTransType.ForeColor = System.Drawing.Color.White;
            this.lblTransType.Location = new System.Drawing.Point(12, 9);
            this.lblTransType.Name = "lblTransType";
            this.lblTransType.Size = new System.Drawing.Size(64, 25);
            this.lblTransType.TabIndex = 20;
            this.lblTransType.Text = "{Type}";
            this.lblTransType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRichTextBoxTitle
            // 
            this.lblRichTextBoxTitle.AutoSize = true;
            this.lblRichTextBoxTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRichTextBoxTitle.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblRichTextBoxTitle.Location = new System.Drawing.Point(171, 90);
            this.lblRichTextBoxTitle.Name = "lblRichTextBoxTitle";
            this.lblRichTextBoxTitle.Size = new System.Drawing.Size(224, 13);
            this.lblRichTextBoxTitle.TabIndex = 24;
            this.lblRichTextBoxTitle.Text = "100 Character{s) remaining [100 maximum] ";
            // 
            // Transactions_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 407);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.Panel_TopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Transactions_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Transaction";
            this.Panel_From.ResumeLayout(false);
            this.Panel_From.PerformLayout();
            this.Panel_To.ResumeLayout(false);
            this.Panel_To.PerformLayout();
            this.Main_Panel.ResumeLayout(false);
            this.Main_Panel.PerformLayout();
            this.Panel_TopMenu.ResumeLayout(false);
            this.Panel_TopMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Panel Panel_From;
        private System.Windows.Forms.DateTimePicker Trans_DateTimePicker;
        private System.Windows.Forms.Label lblTitleNotes;
        private System.Windows.Forms.Panel Panel_To;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.RichTextBox RichTxtNotes;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel Panel_TopMenu;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTransType;
        private System.Windows.Forms.Label lblTitleAmount;
        private System.Windows.Forms.Label lblRichTextBoxTitle;
    }
}