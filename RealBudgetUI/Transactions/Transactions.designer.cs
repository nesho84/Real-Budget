namespace RealBudgetUI.Transactions
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this.Main_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_ListView = new System.Windows.Forms.Panel();
            this.TransListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransImageList = new System.Windows.Forms.ImageList(this.components);
            this.Menu_Bottom_Panel = new System.Windows.Forms.Panel();
            this.Btn_DateTime = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Top_Menu_Panel = new System.Windows.Forms.Panel();
            this.Btn_NextDate = new System.Windows.Forms.Button();
            this.Btn_PreviousDate = new System.Windows.Forms.Button();
            this.Filter_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TransToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Main_tableLayoutPanel.SuspendLayout();
            this.Panel_ListView.SuspendLayout();
            this.Menu_Bottom_Panel.SuspendLayout();
            this.Top_Menu_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_tableLayoutPanel
            // 
            this.Main_tableLayoutPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Main_tableLayoutPanel.ColumnCount = 1;
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_tableLayoutPanel.Controls.Add(this.Panel_ListView, 0, 1);
            this.Main_tableLayoutPanel.Controls.Add(this.Menu_Bottom_Panel, 0, 2);
            this.Main_tableLayoutPanel.Controls.Add(this.Top_Menu_Panel, 0, 0);
            this.Main_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Main_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Main_tableLayoutPanel.Name = "Main_tableLayoutPanel";
            this.Main_tableLayoutPanel.RowCount = 2;
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Main_tableLayoutPanel.Size = new System.Drawing.Size(1008, 477);
            this.Main_tableLayoutPanel.TabIndex = 2;
            // 
            // Panel_ListView
            // 
            this.Panel_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Panel_ListView.BackColor = System.Drawing.Color.White;
            this.Panel_ListView.Controls.Add(this.TransListView);
            this.Panel_ListView.Location = new System.Drawing.Point(0, 60);
            this.Panel_ListView.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_ListView.Name = "Panel_ListView";
            this.Panel_ListView.Size = new System.Drawing.Size(1008, 347);
            this.Panel_ListView.TabIndex = 52;
            // 
            // TransListView
            // 
            this.TransListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.TransListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.TransListView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TransListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader7});
            this.TransListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransListView.FullRowSelect = true;
            this.TransListView.GridLines = true;
            this.TransListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TransListView.LargeImageList = this.TransImageList;
            this.TransListView.Location = new System.Drawing.Point(0, 0);
            this.TransListView.Margin = new System.Windows.Forms.Padding(0);
            this.TransListView.Name = "TransListView";
            this.TransListView.Size = new System.Drawing.Size(1008, 347);
            this.TransListView.SmallImageList = this.TransImageList;
            this.TransListView.TabIndex = 200;
            this.TransListView.Tag = "";
            this.TransListView.UseCompatibleStateImageBehavior = false;
            this.TransListView.View = System.Windows.Forms.View.Details;
            this.TransListView.DoubleClick += new System.EventHandler(this.TransListView_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.Width = 266;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 234;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date";
            this.columnHeader7.Width = 476;
            // 
            // TransImageList
            // 
            this.TransImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TransImageList.ImageStream")));
            this.TransImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TransImageList.Images.SetKeyName(0, "default.png");
            this.TransImageList.Images.SetKeyName(1, "1.png");
            this.TransImageList.Images.SetKeyName(2, "2.png");
            this.TransImageList.Images.SetKeyName(3, "3.png");
            // 
            // Menu_Bottom_Panel
            // 
            this.Menu_Bottom_Panel.BackColor = System.Drawing.Color.SkyBlue;
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_DateTime);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Add);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Refresh);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Delete);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Edit);
            this.Menu_Bottom_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu_Bottom_Panel.Location = new System.Drawing.Point(0, 407);
            this.Menu_Bottom_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Menu_Bottom_Panel.Name = "Menu_Bottom_Panel";
            this.Menu_Bottom_Panel.Size = new System.Drawing.Size(1008, 70);
            this.Menu_Bottom_Panel.TabIndex = 38;
            // 
            // Btn_DateTime
            // 
            this.Btn_DateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_DateTime.BackColor = System.Drawing.Color.Transparent;
            this.Btn_DateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DateTime.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_DateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DateTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DateTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_DateTime.Image = global::RealBudgetUI.Properties.Resources.DateTime_40px;
            this.Btn_DateTime.Location = new System.Drawing.Point(275, 6);
            this.Btn_DateTime.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_DateTime.Name = "Btn_DateTime";
            this.Btn_DateTime.Size = new System.Drawing.Size(59, 59);
            this.Btn_DateTime.TabIndex = 51;
            this.TransToolTip.SetToolTip(this.Btn_DateTime, "Popup Calendar");
            this.Btn_DateTime.UseVisualStyleBackColor = false;
            this.Btn_DateTime.Click += new System.EventHandler(this.Btn_DateTime_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Add.Image = global::RealBudgetUI.Properties.Resources.icons8_plus_40;
            this.Btn_Add.Location = new System.Drawing.Point(375, 6);
            this.Btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(59, 59);
            this.Btn_Add.TabIndex = 45;
            this.TransToolTip.SetToolTip(this.Btn_Add, "Add New");
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
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
            this.Btn_Refresh.Location = new System.Drawing.Point(675, 6);
            this.Btn_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(59, 59);
            this.Btn_Refresh.TabIndex = 44;
            this.TransToolTip.SetToolTip(this.Btn_Refresh, "Refresh");
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
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
            this.Btn_Delete.Location = new System.Drawing.Point(575, 6);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(59, 59);
            this.Btn_Delete.TabIndex = 38;
            this.TransToolTip.SetToolTip(this.Btn_Delete, "Delete");
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
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
            this.Btn_Edit.Location = new System.Drawing.Point(475, 6);
            this.Btn_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(59, 59);
            this.Btn_Edit.TabIndex = 37;
            this.TransToolTip.SetToolTip(this.Btn_Edit, "Edit");
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Top_Menu_Panel
            // 
            this.Top_Menu_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Top_Menu_Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Top_Menu_Panel.Controls.Add(this.Btn_NextDate);
            this.Top_Menu_Panel.Controls.Add(this.Btn_PreviousDate);
            this.Top_Menu_Panel.Controls.Add(this.Filter_dateTimePicker);
            this.Top_Menu_Panel.Location = new System.Drawing.Point(0, 0);
            this.Top_Menu_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Top_Menu_Panel.Name = "Top_Menu_Panel";
            this.Top_Menu_Panel.Size = new System.Drawing.Size(1008, 60);
            this.Top_Menu_Panel.TabIndex = 39;
            // 
            // Btn_NextDate
            // 
            this.Btn_NextDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NextDate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_NextDate.FlatAppearance.BorderSize = 0;
            this.Btn_NextDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_NextDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_NextDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NextDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NextDate.Image = global::RealBudgetUI.Properties.Resources.forward_30px;
            this.Btn_NextDate.Location = new System.Drawing.Point(656, 0);
            this.Btn_NextDate.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_NextDate.Name = "Btn_NextDate";
            this.Btn_NextDate.Size = new System.Drawing.Size(129, 60);
            this.Btn_NextDate.TabIndex = 2;
            this.TransToolTip.SetToolTip(this.Btn_NextDate, "Next Date");
            this.Btn_NextDate.UseVisualStyleBackColor = true;
            this.Btn_NextDate.Click += new System.EventHandler(this.Btn_NextDate_Click);
            // 
            // Btn_PreviousDate
            // 
            this.Btn_PreviousDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PreviousDate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_PreviousDate.FlatAppearance.BorderSize = 0;
            this.Btn_PreviousDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_PreviousDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_PreviousDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PreviousDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PreviousDate.Image = global::RealBudgetUI.Properties.Resources.back_30px;
            this.Btn_PreviousDate.Location = new System.Drawing.Point(224, 0);
            this.Btn_PreviousDate.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_PreviousDate.Name = "Btn_PreviousDate";
            this.Btn_PreviousDate.Size = new System.Drawing.Size(129, 60);
            this.Btn_PreviousDate.TabIndex = 1;
            this.TransToolTip.SetToolTip(this.Btn_PreviousDate, "Previous Date");
            this.Btn_PreviousDate.UseVisualStyleBackColor = true;
            this.Btn_PreviousDate.Click += new System.EventHandler(this.Btn_PreviousDate_Click);
            // 
            // Filter_dateTimePicker
            // 
            this.Filter_dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_dateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Filter_dateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.Filter_dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Filter_dateTimePicker.Location = new System.Drawing.Point(375, 16);
            this.Filter_dateTimePicker.Name = "Filter_dateTimePicker";
            this.Filter_dateTimePicker.Size = new System.Drawing.Size(259, 29);
            this.Filter_dateTimePicker.TabIndex = 0;
            this.Filter_dateTimePicker.ValueChanged += new System.EventHandler(this.Filter_dateTimePicker_ValueChanged);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 477);
            this.Controls.Add(this.Main_tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Main_tableLayoutPanel.ResumeLayout(false);
            this.Panel_ListView.ResumeLayout(false);
            this.Menu_Bottom_Panel.ResumeLayout(false);
            this.Top_Menu_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TableLayoutPanel Main_tableLayoutPanel;
        private System.Windows.Forms.Panel Menu_Bottom_Panel;
        internal System.Windows.Forms.Button Btn_Add;
        internal System.Windows.Forms.Button Btn_Refresh;
        internal System.Windows.Forms.Button Btn_Delete;
        internal System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Panel Top_Menu_Panel;
        internal System.Windows.Forms.Button Btn_DateTime;
        private System.Windows.Forms.Panel Panel_ListView;
        private System.Windows.Forms.ImageList TransImageList;
        private System.Windows.Forms.Button Btn_NextDate;
        private System.Windows.Forms.Button Btn_PreviousDate;
        private System.Windows.Forms.DateTimePicker Filter_dateTimePicker;
        public System.Windows.Forms.ListView TransListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolTip TransToolTip;
    }
}