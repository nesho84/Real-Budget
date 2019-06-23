namespace RealBudgetUI.RBSettings
{
    partial class RBSettings_DBLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RBSettings_DBLocation));
            this.TextBoxFolderPath = new System.Windows.Forms.TextBox();
            this.Main_tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Search_panel1 = new System.Windows.Forms.Panel();
            this.ButtonFolder = new System.Windows.Forms.Button();
            this.InsideTable_panel1 = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Main_tableLayoutPanel1.SuspendLayout();
            this.Search_panel1.SuspendLayout();
            this.InsideTable_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxFolderPath
            // 
            this.TextBoxFolderPath.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TextBoxFolderPath.Location = new System.Drawing.Point(5, 4);
            this.TextBoxFolderPath.Name = "TextBoxFolderPath";
            this.TextBoxFolderPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxFolderPath.Size = new System.Drawing.Size(382, 22);
            this.TextBoxFolderPath.TabIndex = 0;
            // 
            // Main_tableLayoutPanel1
            // 
            this.Main_tableLayoutPanel1.ColumnCount = 3;
            this.Main_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.Main_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.Main_tableLayoutPanel1.Controls.Add(this.Search_panel1, 1, 1);
            this.Main_tableLayoutPanel1.Controls.Add(this.InsideTable_panel1, 1, 2);
            this.Main_tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Main_tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.Main_tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.Main_tableLayoutPanel1.Name = "Main_tableLayoutPanel1";
            this.Main_tableLayoutPanel1.RowCount = 4;
            this.Main_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.Main_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.82979F));
            this.Main_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.17021F));
            this.Main_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.Main_tableLayoutPanel1.Size = new System.Drawing.Size(400, 148);
            this.Main_tableLayoutPanel1.TabIndex = 198;
            // 
            // Search_panel1
            // 
            this.Search_panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search_panel1.Controls.Add(this.ButtonFolder);
            this.Search_panel1.Controls.Add(this.TextBoxFolderPath);
            this.Search_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search_panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Search_panel1.Location = new System.Drawing.Point(4, 4);
            this.Search_panel1.Margin = new System.Windows.Forms.Padding(0);
            this.Search_panel1.Name = "Search_panel1";
            this.Search_panel1.Size = new System.Drawing.Size(392, 90);
            this.Search_panel1.TabIndex = 197;
            // 
            // ButtonFolder
            // 
            this.ButtonFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFolder.Image = global::RealBudgetUI.Properties.Resources.icons8_suche_30;
            this.ButtonFolder.Location = new System.Drawing.Point(5, 31);
            this.ButtonFolder.Name = "ButtonFolder";
            this.ButtonFolder.Size = new System.Drawing.Size(382, 40);
            this.ButtonFolder.TabIndex = 1;
            this.ButtonFolder.Text = "   Browse";
            this.ButtonFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonFolder.UseCompatibleTextRendering = true;
            this.ButtonFolder.UseVisualStyleBackColor = true;
            this.ButtonFolder.Click += new System.EventHandler(this.ButtonFolder_Click);
            // 
            // InsideTable_panel1
            // 
            this.InsideTable_panel1.Controls.Add(this.Btn_Save);
            this.InsideTable_panel1.Controls.Add(this.Btn_Cancel);
            this.InsideTable_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InsideTable_panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.InsideTable_panel1.Location = new System.Drawing.Point(6, 96);
            this.InsideTable_panel1.Margin = new System.Windows.Forms.Padding(2);
            this.InsideTable_panel1.Name = "InsideTable_panel1";
            this.InsideTable_panel1.Size = new System.Drawing.Size(388, 47);
            this.InsideTable_panel1.TabIndex = 198;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Save.Image = global::RealBudgetUI.Properties.Resources.icons8_speichern_30;
            this.Btn_Save.Location = new System.Drawing.Point(3, 4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(139, 39);
            this.Btn_Save.TabIndex = 0;
            this.Btn_Save.Text = "     Save";
            this.Btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_Cancel.Image = global::RealBudgetUI.Properties.Resources.icons8_abbrechen_2_30;
            this.Btn_Cancel.Location = new System.Drawing.Point(246, 4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(139, 39);
            this.Btn_Cancel.TabIndex = 1;
            this.Btn_Cancel.Text = "     Cancel";
            this.Btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // RBSettings_DBLocation
            // 
            this.AcceptButton = this.Btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancel;
            this.ClientSize = new System.Drawing.Size(400, 148);
            this.Controls.Add(this.Main_tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(416, 193);
            this.MinimizeBox = false;
            this.Name = "RBSettings_DBLocation";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Location";
            this.Main_tableLayoutPanel1.ResumeLayout(false);
            this.Search_panel1.ResumeLayout(false);
            this.Search_panel1.PerformLayout();
            this.InsideTable_panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button ButtonFolder;
        private System.Windows.Forms.TextBox TextBoxFolderPath;
        private System.Windows.Forms.TableLayoutPanel Main_tableLayoutPanel1;
        private System.Windows.Forms.Panel InsideTable_panel1;
        public System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Panel Search_panel1;
    }
}