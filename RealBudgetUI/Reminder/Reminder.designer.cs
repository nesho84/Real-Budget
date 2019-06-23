namespace RealBudgetUI.Reminder
{
    partial class Reminder
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTodayDateTime = new System.Windows.Forms.TextBox();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.End_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblNotesTitle = new System.Windows.Forms.Label();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.ReminderListView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.End = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRichTextBoxTitle = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.Menu_Bottom_Panel = new System.Windows.Forms.Panel();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Main_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Main_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Menu_Bottom_Panel.SuspendLayout();
            this.Main_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Today";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Title";
            // 
            // txtTodayDateTime
            // 
            this.txtTodayDateTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTodayDateTime.Location = new System.Drawing.Point(15, 29);
            this.txtTodayDateTime.Name = "txtTodayDateTime";
            this.txtTodayDateTime.ReadOnly = true;
            this.txtTodayDateTime.Size = new System.Drawing.Size(229, 25);
            this.txtTodayDateTime.TabIndex = 0;
            // 
            // txtTitel
            // 
            this.txtTitel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitel.Location = new System.Drawing.Point(15, 73);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(229, 25);
            this.txtTitel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Start";
            // 
            // Start_dateTimePicker
            // 
            this.Start_dateTimePicker.Checked = false;
            this.Start_dateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.Start_dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Start_dateTimePicker.Location = new System.Drawing.Point(15, 117);
            this.Start_dateTimePicker.Name = "Start_dateTimePicker";
            this.Start_dateTimePicker.Size = new System.Drawing.Size(229, 25);
            this.Start_dateTimePicker.TabIndex = 2;
            this.Start_dateTimePicker.Value = new System.DateTime(2019, 5, 23, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "End";
            // 
            // End_dateTimePicker
            // 
            this.End_dateTimePicker.Checked = false;
            this.End_dateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.End_dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.End_dateTimePicker.Location = new System.Drawing.Point(15, 161);
            this.End_dateTimePicker.Name = "End_dateTimePicker";
            this.End_dateTimePicker.Size = new System.Drawing.Size(229, 25);
            this.End_dateTimePicker.TabIndex = 3;
            this.End_dateTimePicker.Value = new System.DateTime(2019, 5, 23, 0, 0, 0, 0);
            // 
            // lblNotesTitle
            // 
            this.lblNotesTitle.AutoSize = true;
            this.lblNotesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotesTitle.Location = new System.Drawing.Point(12, 199);
            this.lblNotesTitle.Name = "lblNotesTitle";
            this.lblNotesTitle.Size = new System.Drawing.Size(88, 15);
            this.lblNotesTitle.TabIndex = 51;
            this.lblNotesTitle.Text = "Remind me to...";
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Main_Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Main_Panel.Controls.Add(this.ReminderListView);
            this.Main_Panel.Controls.Add(this.panel1);
            this.Main_Panel.Location = new System.Drawing.Point(20, 20);
            this.Main_Panel.Margin = new System.Windows.Forms.Padding(20);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(968, 367);
            this.Main_Panel.TabIndex = 51;
            // 
            // ReminderListView
            // 
            this.ReminderListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ReminderListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ReminderListView.BackColor = System.Drawing.SystemColors.Control;
            this.ReminderListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReminderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Start,
            this.End,
            this.Seen});
            this.ReminderListView.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ReminderListView.FullRowSelect = true;
            this.ReminderListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ReminderListView.Location = new System.Drawing.Point(264, 1);
            this.ReminderListView.Margin = new System.Windows.Forms.Padding(0);
            this.ReminderListView.Name = "ReminderListView";
            this.ReminderListView.Size = new System.Drawing.Size(703, 365);
            this.ReminderListView.TabIndex = 199;
            this.ReminderListView.Tag = "";
            this.ReminderListView.UseCompatibleStateImageBehavior = false;
            this.ReminderListView.View = System.Windows.Forms.View.Details;
            this.ReminderListView.DoubleClick += new System.EventHandler(this.ReminderListView_DoubleClick);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 189;
            // 
            // Start
            // 
            this.Start.Text = "Start";
            this.Start.Width = 169;
            // 
            // End
            // 
            this.End.Text = "End";
            this.End.Width = 169;
            // 
            // Seen
            // 
            this.Seen.Text = "Seen";
            this.Seen.Width = 145;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblRichTextBoxTitle);
            this.panel1.Controls.Add(this.Btn_Save);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTodayDateTime);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNotes);
            this.panel1.Controls.Add(this.txtTitel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Start_dateTimePicker);
            this.panel1.Controls.Add(this.lblNotesTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.End_dateTimePicker);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 365);
            this.panel1.TabIndex = 203;
            // 
            // lblRichTextBoxTitle
            // 
            this.lblRichTextBoxTitle.AutoSize = true;
            this.lblRichTextBoxTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRichTextBoxTitle.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblRichTextBoxTitle.Location = new System.Drawing.Point(18, 298);
            this.lblRichTextBoxTitle.Name = "lblRichTextBoxTitle";
            this.lblRichTextBoxTitle.Size = new System.Drawing.Size(224, 13);
            this.lblRichTextBoxTitle.TabIndex = 59;
            this.lblRichTextBoxTitle.Text = "100 Character{s) remaining [100 maximum] ";
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.White;
            this.Btn_Save.Image = global::RealBudgetUI.Properties.Resources.checkmark2_30px;
            this.Btn_Save.Location = new System.Drawing.Point(15, 317);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(229, 39);
            this.Btn_Save.TabIndex = 6;
            this.RemToolTip.SetToolTip(this.Btn_Save, "Save");
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.AutoWordSelection = true;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(15, 217);
            this.txtNotes.MaxLength = 100;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(229, 79);
            this.txtNotes.TabIndex = 5;
            this.txtNotes.Text = "";
            this.txtNotes.TextChanged += new System.EventHandler(this.TxtNotes_TextChanged);
            // 
            // Menu_Bottom_Panel
            // 
            this.Menu_Bottom_Panel.BackColor = System.Drawing.Color.SkyBlue;
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Delete);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Clear);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Refresh);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Edit);
            this.Menu_Bottom_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu_Bottom_Panel.Location = new System.Drawing.Point(0, 407);
            this.Menu_Bottom_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Menu_Bottom_Panel.Name = "Menu_Bottom_Panel";
            this.Menu_Bottom_Panel.Size = new System.Drawing.Size(1008, 70);
            this.Menu_Bottom_Panel.TabIndex = 38;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Delete.Image = global::RealBudgetUI.Properties.Resources.icons8_löschen_40;
            this.Btn_Delete.Location = new System.Drawing.Point(525, 6);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(59, 59);
            this.Btn_Delete.TabIndex = 4;
            this.RemToolTip.SetToolTip(this.Btn_Delete, "Delete");
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Clear.Image = global::RealBudgetUI.Properties.Resources.clear_formatting_40px;
            this.Btn_Clear.Location = new System.Drawing.Point(325, 6);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(59, 59);
            this.Btn_Clear.TabIndex = 0;
            this.RemToolTip.SetToolTip(this.Btn_Clear, "Reset");
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Refresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Refresh.Image = global::RealBudgetUI.Properties.Resources.icons8_aktualisieren_40;
            this.Btn_Refresh.Location = new System.Drawing.Point(625, 6);
            this.Btn_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(59, 59);
            this.Btn_Refresh.TabIndex = 3;
            this.RemToolTip.SetToolTip(this.Btn_Refresh, "Refresh");
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Edit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Edit.Image = global::RealBudgetUI.Properties.Resources.icons8_bearbeiten_40;
            this.Btn_Edit.Location = new System.Drawing.Point(425, 6);
            this.Btn_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(59, 59);
            this.Btn_Edit.TabIndex = 1;
            this.RemToolTip.SetToolTip(this.Btn_Edit, "Edit");
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Main_tableLayoutPanel
            // 
            this.Main_tableLayoutPanel.ColumnCount = 1;
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_tableLayoutPanel.Controls.Add(this.Main_Panel, 0, 0);
            this.Main_tableLayoutPanel.Controls.Add(this.Menu_Bottom_Panel, 0, 1);
            this.Main_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Main_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Main_tableLayoutPanel.Name = "Main_tableLayoutPanel";
            this.Main_tableLayoutPanel.RowCount = 2;
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Main_tableLayoutPanel.Size = new System.Drawing.Size(1008, 477);
            this.Main_tableLayoutPanel.TabIndex = 4;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 477);
            this.Controls.Add(this.Main_tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reminder";
            this.Main_Panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Menu_Bottom_Panel.ResumeLayout(false);
            this.Main_tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTodayDateTime;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Start_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker End_dateTimePicker;
        private System.Windows.Forms.Label lblNotesTitle;
        internal System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel Menu_Bottom_Panel;
        internal System.Windows.Forms.Button Btn_Clear;
        internal System.Windows.Forms.Button Btn_Edit;
        public System.Windows.Forms.TableLayoutPanel Main_tableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.RichTextBox txtNotes;
        public System.Windows.Forms.ListView ReminderListView;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Start;
        private System.Windows.Forms.ColumnHeader End;
        private System.Windows.Forms.ColumnHeader Seen;
        internal System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.ToolTip RemToolTip;
        private System.Windows.Forms.Label lblRichTextBoxTitle;
    }
}