namespace RealBudgetUI.Users
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.Menu_Bottom_Panel = new System.Windows.Forms.Panel();
            this.Btn_Pass_Admin = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Block = new System.Windows.Forms.Button();
            this.UsersImageList = new System.Windows.Forms.ImageList(this.components);
            this.Panel_ListView = new System.Windows.Forms.Panel();
            this.UsersListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Main_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Menu_Bottom_Panel.SuspendLayout();
            this.Panel_ListView.SuspendLayout();
            this.Main_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Bottom_Panel
            // 
            this.Menu_Bottom_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Menu_Bottom_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Pass_Admin);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Add);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Refresh);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Edit);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Delete);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Block);
            this.Menu_Bottom_Panel.Location = new System.Drawing.Point(20, 20);
            this.Menu_Bottom_Panel.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.Menu_Bottom_Panel.Name = "Menu_Bottom_Panel";
            this.Menu_Bottom_Panel.Size = new System.Drawing.Size(191, 437);
            this.Menu_Bottom_Panel.TabIndex = 38;
            // 
            // Btn_Pass_Admin
            // 
            this.Btn_Pass_Admin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Pass_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Pass_Admin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Pass_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Pass_Admin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pass_Admin.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Pass_Admin.Image = global::RealBudgetUI.Properties.Resources.changePass2_40px;
            this.Btn_Pass_Admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Pass_Admin.Location = new System.Drawing.Point(16, 362);
            this.Btn_Pass_Admin.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Pass_Admin.Name = "Btn_Pass_Admin";
            this.Btn_Pass_Admin.Size = new System.Drawing.Size(159, 50);
            this.Btn_Pass_Admin.TabIndex = 43;
            this.Btn_Pass_Admin.Text = "  Password";
            this.Btn_Pass_Admin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Pass_Admin.UseCompatibleTextRendering = true;
            this.Btn_Pass_Admin.UseVisualStyleBackColor = false;
            this.Btn_Pass_Admin.Click += new System.EventHandler(this.Btn_Pass_Admin_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Add.Image = global::RealBudgetUI.Properties.Resources.icons8_plus_40;
            this.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Add.Location = new System.Drawing.Point(16, 18);
            this.Btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(159, 50);
            this.Btn_Add.TabIndex = 42;
            this.Btn_Add.Text = "   ADD NEW";
            this.Btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Add.UseCompatibleTextRendering = true;
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Refresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Refresh.Image = global::RealBudgetUI.Properties.Resources.icons8_aktualisieren_40;
            this.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Refresh.Location = new System.Drawing.Point(16, 293);
            this.Btn_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(159, 50);
            this.Btn_Refresh.TabIndex = 41;
            this.Btn_Refresh.Text = "   REFRESH";
            this.Btn_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Refresh.UseCompatibleTextRendering = true;
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Edit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Edit.Image = global::RealBudgetUI.Properties.Resources.icons8_bearbeiten_40;
            this.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Edit.Location = new System.Drawing.Point(16, 86);
            this.Btn_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(159, 50);
            this.Btn_Edit.TabIndex = 37;
            this.Btn_Edit.Text = "   EDIT";
            this.Btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Edit.UseCompatibleTextRendering = true;
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Delete.Image = global::RealBudgetUI.Properties.Resources.icons8_löschen_40;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.Location = new System.Drawing.Point(16, 155);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(159, 50);
            this.Btn_Delete.TabIndex = 38;
            this.Btn_Delete.Text = "   DELETE";
            this.Btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Delete.UseCompatibleTextRendering = true;
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Block
            // 
            this.Btn_Block.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Block.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Block.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Block.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Block.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Block.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Block.Image = global::RealBudgetUI.Properties.Resources.icons8_privatgelände_40;
            this.Btn_Block.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Block.Location = new System.Drawing.Point(16, 224);
            this.Btn_Block.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Block.Name = "Btn_Block";
            this.Btn_Block.Size = new System.Drawing.Size(159, 50);
            this.Btn_Block.TabIndex = 40;
            this.Btn_Block.Text = "   BLOCK";
            this.Btn_Block.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Block.UseCompatibleTextRendering = true;
            this.Btn_Block.UseVisualStyleBackColor = false;
            this.Btn_Block.Click += new System.EventHandler(this.Btn_Block_Click);
            // 
            // UsersImageList
            // 
            this.UsersImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("UsersImageList.ImageStream")));
            this.UsersImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.UsersImageList.Images.SetKeyName(0, "0.png");
            this.UsersImageList.Images.SetKeyName(1, "1.png");
            this.UsersImageList.Images.SetKeyName(2, "2.png");
            this.UsersImageList.Images.SetKeyName(3, "3.png");
            this.UsersImageList.Images.SetKeyName(4, "4.png");
            // 
            // Panel_ListView
            // 
            this.Panel_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Panel_ListView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_ListView.Controls.Add(this.UsersListView);
            this.Panel_ListView.Location = new System.Drawing.Point(232, 20);
            this.Panel_ListView.Margin = new System.Windows.Forms.Padding(20);
            this.Panel_ListView.Name = "Panel_ListView";
            this.Panel_ListView.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Panel_ListView.Size = new System.Drawing.Size(756, 437);
            this.Panel_ListView.TabIndex = 200;
            // 
            // UsersListView
            // 
            this.UsersListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.UsersListView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsersListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6});
            this.UsersListView.FullRowSelect = true;
            this.UsersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.UsersListView.LargeImageList = this.UsersImageList;
            this.UsersListView.Location = new System.Drawing.Point(4, 18);
            this.UsersListView.Margin = new System.Windows.Forms.Padding(0);
            this.UsersListView.Name = "UsersListView";
            this.UsersListView.Size = new System.Drawing.Size(753, 401);
            this.UsersListView.SmallImageList = this.UsersImageList;
            this.UsersListView.TabIndex = 197;
            this.UsersListView.Tag = "Expenses";
            this.UsersListView.UseCompatibleStateImageBehavior = false;
            this.UsersListView.DoubleClick += new System.EventHandler(this.UsersListView_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 304;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Currency";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 150;
            // 
            // Main_tableLayoutPanel
            // 
            this.Main_tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Main_tableLayoutPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Main_tableLayoutPanel.ColumnCount = 2;
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.03175F));
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.96825F));
            this.Main_tableLayoutPanel.Controls.Add(this.Panel_ListView, 1, 0);
            this.Main_tableLayoutPanel.Controls.Add(this.Menu_Bottom_Panel, 0, 0);
            this.Main_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Main_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Main_tableLayoutPanel.Name = "Main_tableLayoutPanel";
            this.Main_tableLayoutPanel.RowCount = 1;
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Main_tableLayoutPanel.Size = new System.Drawing.Size(1008, 477);
            this.Main_tableLayoutPanel.TabIndex = 201;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 477);
            this.Controls.Add(this.Main_tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Menu_Bottom_Panel.ResumeLayout(false);
            this.Panel_ListView.ResumeLayout(false);
            this.Main_tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Menu_Bottom_Panel;
        internal System.Windows.Forms.Button Btn_Refresh;
        internal System.Windows.Forms.Button Btn_Block;
        internal System.Windows.Forms.Button Btn_Delete;
        internal System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.ImageList UsersImageList;
        private System.Windows.Forms.Panel Panel_ListView;
        public System.Windows.Forms.ListView UsersListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TableLayoutPanel Main_tableLayoutPanel;
        internal System.Windows.Forms.Button Btn_Add;
        internal System.Windows.Forms.Button Btn_Pass_Admin;
    }
}