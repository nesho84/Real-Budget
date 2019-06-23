namespace RealBudgetUI.Categories
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.Main_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_ListView = new System.Windows.Forms.Panel();
            this.CatListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CatImageList = new System.Windows.Forms.ImageList(this.components);
            this.Top_Menu_Panel = new System.Windows.Forms.Panel();
            this.Btn_Income = new System.Windows.Forms.Button();
            this.Btn_Exp = new System.Windows.Forms.Button();
            this.lblCatListTitle = new System.Windows.Forms.Label();
            this.Menu_Bottom_Panel = new System.Windows.Forms.Panel();
            this.Btn_New = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.CatToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Main_tableLayoutPanel.SuspendLayout();
            this.Panel_ListView.SuspendLayout();
            this.Top_Menu_Panel.SuspendLayout();
            this.Menu_Bottom_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_tableLayoutPanel
            // 
            this.Main_tableLayoutPanel.ColumnCount = 1;
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_tableLayoutPanel.Controls.Add(this.Panel_ListView, 0, 1);
            this.Main_tableLayoutPanel.Controls.Add(this.Top_Menu_Panel, 0, 0);
            this.Main_tableLayoutPanel.Controls.Add(this.Menu_Bottom_Panel, 0, 2);
            this.Main_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Main_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Main_tableLayoutPanel.Name = "Main_tableLayoutPanel";
            this.Main_tableLayoutPanel.RowCount = 3;
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
            this.Panel_ListView.Controls.Add(this.CatListView);
            this.Panel_ListView.Location = new System.Drawing.Point(0, 60);
            this.Panel_ListView.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_ListView.Name = "Panel_ListView";
            this.Panel_ListView.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.Panel_ListView.Size = new System.Drawing.Size(1008, 347);
            this.Panel_ListView.TabIndex = 51;
            // 
            // CatListView
            // 
            this.CatListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.CatListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CatListView.BackColor = System.Drawing.Color.White;
            this.CatListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader5});
            this.CatListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatListView.FullRowSelect = true;
            this.CatListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CatListView.LargeImageList = this.CatImageList;
            this.CatListView.Location = new System.Drawing.Point(0, 19);
            this.CatListView.Margin = new System.Windows.Forms.Padding(0);
            this.CatListView.Name = "CatListView";
            this.CatListView.Size = new System.Drawing.Size(1008, 307);
            this.CatListView.SmallImageList = this.CatImageList;
            this.CatListView.TabIndex = 198;
            this.CatListView.Tag = "";
            this.CatListView.UseCompatibleStateImageBehavior = false;
            this.CatListView.DoubleClick += new System.EventHandler(this.CatListView_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 304;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Balance";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Currency";
            // 
            // CatImageList
            // 
            this.CatImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("CatImageList.ImageStream")));
            this.CatImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.CatImageList.Images.SetKeyName(0, "0.png");
            this.CatImageList.Images.SetKeyName(1, "1.png");
            this.CatImageList.Images.SetKeyName(2, "2.png");
            this.CatImageList.Images.SetKeyName(3, "3.png");
            this.CatImageList.Images.SetKeyName(4, "4.png");
            this.CatImageList.Images.SetKeyName(5, "5.png");
            this.CatImageList.Images.SetKeyName(6, "6.png");
            this.CatImageList.Images.SetKeyName(7, "7.png");
            this.CatImageList.Images.SetKeyName(8, "8.png");
            this.CatImageList.Images.SetKeyName(9, "9.png");
            this.CatImageList.Images.SetKeyName(10, "10.png");
            this.CatImageList.Images.SetKeyName(11, "11.png");
            this.CatImageList.Images.SetKeyName(12, "12.png");
            this.CatImageList.Images.SetKeyName(13, "13.png");
            this.CatImageList.Images.SetKeyName(14, "14.png");
            this.CatImageList.Images.SetKeyName(15, "15.png");
            // 
            // Top_Menu_Panel
            // 
            this.Top_Menu_Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Top_Menu_Panel.Controls.Add(this.Btn_Income);
            this.Top_Menu_Panel.Controls.Add(this.Btn_Exp);
            this.Top_Menu_Panel.Controls.Add(this.lblCatListTitle);
            this.Top_Menu_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top_Menu_Panel.Location = new System.Drawing.Point(0, 0);
            this.Top_Menu_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Top_Menu_Panel.Name = "Top_Menu_Panel";
            this.Top_Menu_Panel.Size = new System.Drawing.Size(1008, 60);
            this.Top_Menu_Panel.TabIndex = 39;
            // 
            // Btn_Income
            // 
            this.Btn_Income.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Income.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Btn_Income.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Income.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Income.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Btn_Income.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(183)))), ((int)(((byte)(240)))));
            this.Btn_Income.Image = global::RealBudgetUI.Properties.Resources.icons8_anzahlung_40;
            this.Btn_Income.Location = new System.Drawing.Point(841, 0);
            this.Btn_Income.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Income.Name = "Btn_Income";
            this.Btn_Income.Size = new System.Drawing.Size(167, 60);
            this.Btn_Income.TabIndex = 199;
            this.Btn_Income.Text = "    INCOME";
            this.Btn_Income.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Income.UseVisualStyleBackColor = false;
            this.Btn_Income.Click += new System.EventHandler(this.Btn_Income_Click);
            // 
            // Btn_Exp
            // 
            this.Btn_Exp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Exp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Btn_Exp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exp.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exp.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Btn_Exp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(183)))), ((int)(((byte)(240)))));
            this.Btn_Exp.Image = global::RealBudgetUI.Properties.Resources.icons8_karte_verwenden_40;
            this.Btn_Exp.Location = new System.Drawing.Point(0, 0);
            this.Btn_Exp.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Exp.Name = "Btn_Exp";
            this.Btn_Exp.Size = new System.Drawing.Size(168, 60);
            this.Btn_Exp.TabIndex = 200;
            this.Btn_Exp.Text = "   EXPENSES";
            this.Btn_Exp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Exp.UseVisualStyleBackColor = false;
            this.Btn_Exp.Click += new System.EventHandler(this.Btn_Exp_Click);
            // 
            // lblCatListTitle
            // 
            this.lblCatListTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCatListTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCatListTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCatListTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold);
            this.lblCatListTitle.ForeColor = System.Drawing.Color.White;
            this.lblCatListTitle.Location = new System.Drawing.Point(337, 8);
            this.lblCatListTitle.Name = "lblCatListTitle";
            this.lblCatListTitle.Size = new System.Drawing.Size(335, 45);
            this.lblCatListTitle.TabIndex = 198;
            this.lblCatListTitle.Text = "Expenses";
            this.lblCatListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu_Bottom_Panel
            // 
            this.Menu_Bottom_Panel.BackColor = System.Drawing.Color.SkyBlue;
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_New);
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
            // Btn_New
            // 
            this.Btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_New.BackColor = System.Drawing.Color.Transparent;
            this.Btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_New.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_New.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_New.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_New.Image = global::RealBudgetUI.Properties.Resources.icons8_plus_40;
            this.Btn_New.Location = new System.Drawing.Point(325, 6);
            this.Btn_New.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(59, 59);
            this.Btn_New.TabIndex = 45;
            this.CatToolTip.SetToolTip(this.Btn_New, "Add New");
            this.Btn_New.UseVisualStyleBackColor = false;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
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
            this.Btn_Refresh.TabIndex = 48;
            this.CatToolTip.SetToolTip(this.Btn_Refresh, "Refresh");
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
            this.Btn_Delete.Location = new System.Drawing.Point(525, 6);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(59, 59);
            this.Btn_Delete.TabIndex = 47;
            this.CatToolTip.SetToolTip(this.Btn_Delete, "Delete");
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
            this.Btn_Edit.Location = new System.Drawing.Point(425, 6);
            this.Btn_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(59, 59);
            this.Btn_Edit.TabIndex = 46;
            this.CatToolTip.SetToolTip(this.Btn_Edit, "Edit");
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 477);
            this.Controls.Add(this.Main_tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Main_tableLayoutPanel.ResumeLayout(false);
            this.Panel_ListView.ResumeLayout(false);
            this.Top_Menu_Panel.ResumeLayout(false);
            this.Menu_Bottom_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel Main_tableLayoutPanel;
        private System.Windows.Forms.Panel Menu_Bottom_Panel;
        internal System.Windows.Forms.Button Btn_New;
        internal System.Windows.Forms.Button Btn_Refresh;
        internal System.Windows.Forms.Button Btn_Delete;
        internal System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Panel Top_Menu_Panel;
        private System.Windows.Forms.ImageList CatImageList;
        private System.Windows.Forms.Label lblCatListTitle;
        public System.Windows.Forms.ListView CatListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        internal System.Windows.Forms.Button Btn_Income;
        internal System.Windows.Forms.Button Btn_Exp;
        private System.Windows.Forms.Panel Panel_ListView;
        private System.Windows.Forms.ToolTip CatToolTip;
    }
}