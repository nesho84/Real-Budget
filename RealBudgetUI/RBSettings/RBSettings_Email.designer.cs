namespace RealBudgetUI.RBSettings
{
    partial class RBSettings_Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RBSettings_Email));
            this.Main_tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Search_panel1 = new System.Windows.Forms.Panel();
            this.Lbl_info = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.InsideTable_panel1 = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Main_tableLayoutPanel1.SuspendLayout();
            this.Search_panel1.SuspendLayout();
            this.InsideTable_panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.Main_tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.Main_tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.Main_tableLayoutPanel1.Name = "Main_tableLayoutPanel1";
            this.Main_tableLayoutPanel1.RowCount = 4;
            this.Main_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.Main_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.83F));
            this.Main_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.17F));
            this.Main_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.Main_tableLayoutPanel1.Size = new System.Drawing.Size(400, 148);
            this.Main_tableLayoutPanel1.TabIndex = 199;
            // 
            // Search_panel1
            // 
            this.Search_panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search_panel1.Controls.Add(this.Lbl_info);
            this.Search_panel1.Controls.Add(this.TxtEmail);
            this.Search_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search_panel1.Location = new System.Drawing.Point(4, 4);
            this.Search_panel1.Margin = new System.Windows.Forms.Padding(0);
            this.Search_panel1.Name = "Search_panel1";
            this.Search_panel1.Size = new System.Drawing.Size(392, 90);
            this.Search_panel1.TabIndex = 197;
            // 
            // Lbl_info
            // 
            this.Lbl_info.Location = new System.Drawing.Point(2, 7);
            this.Lbl_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_info.Name = "Lbl_info";
            this.Lbl_info.Size = new System.Drawing.Size(381, 29);
            this.Lbl_info.TabIndex = 1;
            this.Lbl_info.Text = "Note(ex. Gmail): Turn on Allow less secure apps. (Note: If your administrator has" +
    " locked less secure app account access, this setting is hidden.)";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(3, 42);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtEmail.Size = new System.Drawing.Size(382, 23);
            this.TxtEmail.TabIndex = 0;
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
            this.Btn_Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            // RBSettings_Email
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
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(416, 180);
            this.Name = "RBSettings_Email";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Email for Password Reset";
            this.Main_tableLayoutPanel1.ResumeLayout(false);
            this.Search_panel1.ResumeLayout(false);
            this.Search_panel1.PerformLayout();
            this.InsideTable_panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Main_tableLayoutPanel1;
        private System.Windows.Forms.Panel Search_panel1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Panel InsideTable_panel1;
        public System.Windows.Forms.Button Btn_Save;
        public System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label Lbl_info;
    }
}