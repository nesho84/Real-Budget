namespace RealBudgetUI.Accounts
{
    partial class Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            this.Main_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Menu_Bottom_Panel = new System.Windows.Forms.Panel();
            this.Btn_Withdraw = new System.Windows.Forms.Button();
            this.Btn_Recharge = new System.Windows.Forms.Button();
            this.Btn_New = new System.Windows.Forms.Button();
            this.Btn_Balance = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Panel_ListView = new System.Windows.Forms.Panel();
            this.AccListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccImageList = new System.Windows.Forms.ImageList(this.components);
            this.AccToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Main_tableLayoutPanel.SuspendLayout();
            this.Menu_Bottom_Panel.SuspendLayout();
            this.Panel_ListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_tableLayoutPanel
            // 
            this.Main_tableLayoutPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Main_tableLayoutPanel.ColumnCount = 1;
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_tableLayoutPanel.Controls.Add(this.Menu_Bottom_Panel, 0, 1);
            this.Main_tableLayoutPanel.Controls.Add(this.Panel_ListView, 0, 0);
            this.Main_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Main_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Main_tableLayoutPanel.Name = "Main_tableLayoutPanel";
            this.Main_tableLayoutPanel.RowCount = 2;
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Main_tableLayoutPanel.Size = new System.Drawing.Size(1008, 477);
            this.Main_tableLayoutPanel.TabIndex = 1;
            // 
            // Menu_Bottom_Panel
            // 
            this.Menu_Bottom_Panel.BackColor = System.Drawing.Color.SkyBlue;
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Withdraw);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Recharge);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_New);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Balance);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Delete);
            this.Menu_Bottom_Panel.Controls.Add(this.Btn_Edit);
            this.Menu_Bottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Menu_Bottom_Panel.Location = new System.Drawing.Point(0, 407);
            this.Menu_Bottom_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Menu_Bottom_Panel.Name = "Menu_Bottom_Panel";
            this.Menu_Bottom_Panel.Size = new System.Drawing.Size(1008, 70);
            this.Menu_Bottom_Panel.TabIndex = 38;
            // 
            // Btn_Withdraw
            // 
            this.Btn_Withdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Withdraw.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Withdraw.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Withdraw.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Withdraw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Withdraw.Image = global::RealBudgetUI.Properties.Resources.initiate_money_transfer_40px;
            this.Btn_Withdraw.Location = new System.Drawing.Point(426, 6);
            this.Btn_Withdraw.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Withdraw.Name = "Btn_Withdraw";
            this.Btn_Withdraw.Size = new System.Drawing.Size(59, 59);
            this.Btn_Withdraw.TabIndex = 47;
            this.AccToolTip.SetToolTip(this.Btn_Withdraw, "Withdraw");
            this.Btn_Withdraw.UseVisualStyleBackColor = false;
            this.Btn_Withdraw.Click += new System.EventHandler(this.Btn_Withdraw_Click);
            // 
            // Btn_Recharge
            // 
            this.Btn_Recharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Recharge.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Recharge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Recharge.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Recharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Recharge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Recharge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Recharge.Image = global::RealBudgetUI.Properties.Resources.request_money_40px;
            this.Btn_Recharge.Location = new System.Drawing.Point(325, 6);
            this.Btn_Recharge.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Recharge.Name = "Btn_Recharge";
            this.Btn_Recharge.Size = new System.Drawing.Size(59, 59);
            this.Btn_Recharge.TabIndex = 46;
            this.AccToolTip.SetToolTip(this.Btn_Recharge, "Recharge");
            this.Btn_Recharge.UseVisualStyleBackColor = false;
            this.Btn_Recharge.Click += new System.EventHandler(this.Btn_Recharge_Click);
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
            this.Btn_New.Location = new System.Drawing.Point(525, 6);
            this.Btn_New.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(59, 59);
            this.Btn_New.TabIndex = 45;
            this.AccToolTip.SetToolTip(this.Btn_New, "Add New");
            this.Btn_New.UseVisualStyleBackColor = false;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Btn_Balance
            // 
            this.Btn_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Balance.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Balance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Balance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Balance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Balance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Balance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Balance.Image = global::RealBudgetUI.Properties.Resources.refund_2_40px;
            this.Btn_Balance.Location = new System.Drawing.Point(225, 6);
            this.Btn_Balance.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Balance.Name = "Btn_Balance";
            this.Btn_Balance.Size = new System.Drawing.Size(59, 59);
            this.Btn_Balance.TabIndex = 44;
            this.AccToolTip.SetToolTip(this.Btn_Balance, "Balance");
            this.Btn_Balance.UseVisualStyleBackColor = false;
            this.Btn_Balance.Click += new System.EventHandler(this.Btn_Balance_Click);
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
            this.Btn_Delete.Location = new System.Drawing.Point(725, 6);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(59, 59);
            this.Btn_Delete.TabIndex = 38;
            this.AccToolTip.SetToolTip(this.Btn_Delete, "Delete");
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
            this.Btn_Edit.Location = new System.Drawing.Point(625, 6);
            this.Btn_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(59, 59);
            this.Btn_Edit.TabIndex = 37;
            this.AccToolTip.SetToolTip(this.Btn_Edit, "Edit");
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Panel_ListView
            // 
            this.Panel_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Panel_ListView.BackColor = System.Drawing.Color.White;
            this.Panel_ListView.Controls.Add(this.AccListView);
            this.Panel_ListView.Location = new System.Drawing.Point(20, 20);
            this.Panel_ListView.Margin = new System.Windows.Forms.Padding(20);
            this.Panel_ListView.Name = "Panel_ListView";
            this.Panel_ListView.Size = new System.Drawing.Size(968, 367);
            this.Panel_ListView.TabIndex = 39;
            // 
            // AccListView
            // 
            this.AccListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.AccListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.AccListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AccListView.BackColor = System.Drawing.Color.White;
            this.AccListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader5});
            this.AccListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccListView.FullRowSelect = true;
            this.AccListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AccListView.LargeImageList = this.AccImageList;
            this.AccListView.Location = new System.Drawing.Point(4, 20);
            this.AccListView.Margin = new System.Windows.Forms.Padding(0);
            this.AccListView.Name = "AccListView";
            this.AccListView.Size = new System.Drawing.Size(960, 332);
            this.AccListView.SmallImageList = this.AccImageList;
            this.AccListView.TabIndex = 199;
            this.AccListView.Tag = "";
            this.AccListView.UseCompatibleStateImageBehavior = false;
            this.AccListView.DoubleClick += new System.EventHandler(this.AccListView_DoubleClick);
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
            // AccImageList
            // 
            this.AccImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("AccImageList.ImageStream")));
            this.AccImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.AccImageList.Images.SetKeyName(0, "0.png");
            this.AccImageList.Images.SetKeyName(1, "1.png");
            this.AccImageList.Images.SetKeyName(2, "2.png");
            this.AccImageList.Images.SetKeyName(3, "3.png");
            this.AccImageList.Images.SetKeyName(4, "4.png");
            this.AccImageList.Images.SetKeyName(5, "5.png");
            this.AccImageList.Images.SetKeyName(6, "6.png");
            this.AccImageList.Images.SetKeyName(7, "7.png");
            this.AccImageList.Images.SetKeyName(8, "8.png");
            this.AccImageList.Images.SetKeyName(9, "9.png");
            this.AccImageList.Images.SetKeyName(10, "10.png");
            this.AccImageList.Images.SetKeyName(11, "11.png");
            this.AccImageList.Images.SetKeyName(12, "12.png");
            this.AccImageList.Images.SetKeyName(13, "13.png");
            this.AccImageList.Images.SetKeyName(14, "14.png");
            this.AccImageList.Images.SetKeyName(15, "15.png");
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 477);
            this.Controls.Add(this.Main_tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Accounts";
            this.Text = "Accounts_List";
            this.Main_tableLayoutPanel.ResumeLayout(false);
            this.Menu_Bottom_Panel.ResumeLayout(false);
            this.Panel_ListView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel Main_tableLayoutPanel;
        private System.Windows.Forms.Panel Menu_Bottom_Panel;
        internal System.Windows.Forms.Button Btn_Delete;
        internal System.Windows.Forms.Button Btn_Edit;
        internal System.Windows.Forms.Button Btn_New;
        internal System.Windows.Forms.Button Btn_Recharge;
        internal System.Windows.Forms.Button Btn_Withdraw;
        internal System.Windows.Forms.Button Btn_Balance;
        private System.Windows.Forms.Panel Panel_ListView;
        public System.Windows.Forms.ListView AccListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList AccImageList;
        private System.Windows.Forms.ToolTip AccToolTip;
    }
}