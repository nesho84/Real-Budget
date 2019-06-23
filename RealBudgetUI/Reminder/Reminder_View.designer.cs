namespace RealBudgetUI.Reminder
{
    partial class Reminder_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminder_View));
            this.lblTitel = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.Notes_richTextBox = new System.Windows.Forms.RichTextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.ButtonsBottom_Panel = new System.Windows.Forms.Panel();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.Status_Panel = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Btn_Done = new System.Windows.Forms.Button();
            this.Btn_Missed = new System.Windows.Forms.Button();
            this.Btn_Present = new System.Windows.Forms.Button();
            this.txtSeen = new System.Windows.Forms.TextBox();
            this.lblSeen = new System.Windows.Forms.Label();
            this.RemToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonsBottom_Panel.SuspendLayout();
            this.Status_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(9, 107);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(30, 15);
            this.lblTitel.TabIndex = 47;
            this.lblTitel.Text = "Titel";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(12, 125);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.ReadOnly = true;
            this.txtTitel.Size = new System.Drawing.Size(267, 23);
            this.txtTitel.TabIndex = 39;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(10, 288);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 15);
            this.lblNotes.TabIndex = 44;
            this.lblNotes.Text = "Notes";
            // 
            // Notes_richTextBox
            // 
            this.Notes_richTextBox.AutoWordSelection = true;
            this.Notes_richTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Notes_richTextBox.Location = new System.Drawing.Point(12, 307);
            this.Notes_richTextBox.MaxLength = 100;
            this.Notes_richTextBox.Name = "Notes_richTextBox";
            this.Notes_richTextBox.ReadOnly = true;
            this.Notes_richTextBox.Size = new System.Drawing.Size(267, 76);
            this.Notes_richTextBox.TabIndex = 43;
            this.Notes_richTextBox.Text = "";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(9, 195);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(27, 15);
            this.lblEnd.TabIndex = 46;
            this.lblEnd.Text = "End";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(9, 151);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(31, 15);
            this.lblStart.TabIndex = 45;
            this.lblStart.Text = "Start";
            // 
            // ButtonsBottom_Panel
            // 
            this.ButtonsBottom_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ButtonsBottom_Panel.Controls.Add(this.Btn_Cancel);
            this.ButtonsBottom_Panel.Controls.Add(this.Btn_Ok);
            this.ButtonsBottom_Panel.Controls.Add(this.Btn_Delete);
            this.ButtonsBottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsBottom_Panel.Location = new System.Drawing.Point(0, 389);
            this.ButtonsBottom_Panel.Name = "ButtonsBottom_Panel";
            this.ButtonsBottom_Panel.Size = new System.Drawing.Size(291, 62);
            this.ButtonsBottom_Panel.TabIndex = 49;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Cancel.Image = global::RealBudgetUI.Properties.Resources.cancel_2_16px;
            this.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cancel.Location = new System.Drawing.Point(102, 12);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(85, 39);
            this.Btn_Cancel.TabIndex = 36;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemToolTip.SetToolTip(this.Btn_Cancel, "Ignore");
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Ok.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Ok.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ok.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Ok.Image = global::RealBudgetUI.Properties.Resources.seen_16px;
            this.Btn_Ok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Ok.Location = new System.Drawing.Point(195, 12);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(85, 39);
            this.Btn_Ok.TabIndex = 35;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemToolTip.SetToolTip(this.Btn_Ok, "Mark as Seen");
            this.Btn_Ok.UseVisualStyleBackColor = false;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Delete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Delete.Image = global::RealBudgetUI.Properties.Resources.delete_sign_16px;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Delete.Location = new System.Drawing.Point(10, 12);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(85, 39);
            this.Btn_Delete.TabIndex = 34;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemToolTip.SetToolTip(this.Btn_Delete, "Delete Reminder");
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(12, 169);
            this.txtStart.Name = "txtStart";
            this.txtStart.ReadOnly = true;
            this.txtStart.Size = new System.Drawing.Size(267, 23);
            this.txtStart.TabIndex = 50;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(12, 213);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.ReadOnly = true;
            this.txtEnd.Size = new System.Drawing.Size(267, 23);
            this.txtEnd.TabIndex = 51;
            // 
            // Status_Panel
            // 
            this.Status_Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Status_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Status_Panel.Controls.Add(this.lblStatus);
            this.Status_Panel.Location = new System.Drawing.Point(12, 12);
            this.Status_Panel.Name = "Status_Panel";
            this.Status_Panel.Size = new System.Drawing.Size(267, 51);
            this.Status_Panel.TabIndex = 52;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(263, 47);
            this.lblStatus.TabIndex = 54;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Done
            // 
            this.Btn_Done.Location = new System.Drawing.Point(11, 66);
            this.Btn_Done.Name = "Btn_Done";
            this.Btn_Done.Size = new System.Drawing.Size(83, 27);
            this.Btn_Done.TabIndex = 53;
            this.Btn_Done.Text = "Done";
            this.RemToolTip.SetToolTip(this.Btn_Done, "Mark as done");
            this.Btn_Done.UseVisualStyleBackColor = true;
            this.Btn_Done.Click += new System.EventHandler(this.Btn_Done_Click);
            // 
            // Btn_Missed
            // 
            this.Btn_Missed.Location = new System.Drawing.Point(103, 66);
            this.Btn_Missed.Name = "Btn_Missed";
            this.Btn_Missed.Size = new System.Drawing.Size(83, 27);
            this.Btn_Missed.TabIndex = 54;
            this.Btn_Missed.Text = "Missed";
            this.RemToolTip.SetToolTip(this.Btn_Missed, "Mark as missed");
            this.Btn_Missed.UseVisualStyleBackColor = true;
            this.Btn_Missed.Click += new System.EventHandler(this.Btn_Missed_Click);
            // 
            // Btn_Present
            // 
            this.Btn_Present.Location = new System.Drawing.Point(196, 66);
            this.Btn_Present.Name = "Btn_Present";
            this.Btn_Present.Size = new System.Drawing.Size(83, 27);
            this.Btn_Present.TabIndex = 55;
            this.Btn_Present.Text = "Present";
            this.RemToolTip.SetToolTip(this.Btn_Present, "Mark as present");
            this.Btn_Present.UseVisualStyleBackColor = true;
            this.Btn_Present.Click += new System.EventHandler(this.Btn_Present_Click);
            // 
            // txtSeen
            // 
            this.txtSeen.Location = new System.Drawing.Point(12, 257);
            this.txtSeen.Name = "txtSeen";
            this.txtSeen.ReadOnly = true;
            this.txtSeen.Size = new System.Drawing.Size(267, 23);
            this.txtSeen.TabIndex = 57;
            // 
            // lblSeen
            // 
            this.lblSeen.AutoSize = true;
            this.lblSeen.Location = new System.Drawing.Point(10, 239);
            this.lblSeen.Name = "lblSeen";
            this.lblSeen.Size = new System.Drawing.Size(32, 15);
            this.lblSeen.TabIndex = 56;
            this.lblSeen.Text = "Seen";
            // 
            // Reminder_View
            // 
            this.AcceptButton = this.Btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.Btn_Cancel;
            this.ClientSize = new System.Drawing.Size(291, 451);
            this.Controls.Add(this.txtSeen);
            this.Controls.Add(this.lblSeen);
            this.Controls.Add(this.Btn_Present);
            this.Controls.Add(this.Btn_Missed);
            this.Controls.Add(this.Btn_Done);
            this.Controls.Add(this.Status_Panel);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.Notes_richTextBox);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.ButtonsBottom_Panel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Reminder_View";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder View";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Reminder_View_KeyPress);
            this.ButtonsBottom_Panel.ResumeLayout(false);
            this.Status_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        public System.Windows.Forms.TextBox txtTitel;
        public System.Windows.Forms.RichTextBox Notes_richTextBox;
        public System.Windows.Forms.Panel ButtonsBottom_Panel;
        public System.Windows.Forms.TextBox txtStart;
        public System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Panel Status_Panel;
        public System.Windows.Forms.Button Btn_Done;
        public System.Windows.Forms.Button Btn_Missed;
        public System.Windows.Forms.Button Btn_Present;
        private System.Windows.Forms.Button Btn_Ok;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.TextBox txtSeen;
        private System.Windows.Forms.Label lblSeen;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.ToolTip RemToolTip;
    }
}