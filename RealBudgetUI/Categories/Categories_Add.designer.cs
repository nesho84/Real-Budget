namespace RealBudgetUI.Categories
{
    partial class Categories_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories_Add));
            this.Btn_Save = new System.Windows.Forms.Button();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.panel2_TopTitel = new System.Windows.Forms.Panel();
            this.TxtCatName = new System.Windows.Forms.TextBox();
            this.Cat_AddImage_PicBox = new System.Windows.Forms.PictureBox();
            this.Btn_ChImage = new System.Windows.Forms.Button();
            this.Main_panel1 = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.Type_comboBox = new System.Windows.Forms.ComboBox();
            this.Controls_panel1 = new System.Windows.Forms.Panel();
            this.panel2_TopTitel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cat_AddImage_PicBox)).BeginInit();
            this.Main_panel1.SuspendLayout();
            this.Controls_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.White;
            this.Btn_Save.Image = global::RealBudgetUI.Properties.Resources.checkmark2_40px;
            this.Btn_Save.Location = new System.Drawing.Point(11, 10);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(246, 47);
            this.Btn_Save.TabIndex = 25;
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTitle.ForeColor = System.Drawing.Color.White;
            this.lblTopTitle.Location = new System.Drawing.Point(12, 25);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(246, 32);
            this.lblTopTitle.TabIndex = 4;
            this.lblTopTitle.Text = "Add {catName}";
            this.lblTopTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2_TopTitel
            // 
            this.panel2_TopTitel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(183)))), ((int)(((byte)(240)))));
            this.panel2_TopTitel.Controls.Add(this.lblTopTitle);
            this.panel2_TopTitel.Controls.Add(this.TxtCatName);
            this.panel2_TopTitel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2_TopTitel.Location = new System.Drawing.Point(0, 0);
            this.panel2_TopTitel.Name = "panel2_TopTitel";
            this.panel2_TopTitel.Size = new System.Drawing.Size(269, 121);
            this.panel2_TopTitel.TabIndex = 2;
            // 
            // TxtCatName
            // 
            this.TxtCatName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCatName.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCatName.Location = new System.Drawing.Point(11, 83);
            this.TxtCatName.Multiline = true;
            this.TxtCatName.Name = "TxtCatName";
            this.TxtCatName.Size = new System.Drawing.Size(246, 28);
            this.TxtCatName.TabIndex = 22;
            // 
            // Cat_AddImage_PicBox
            // 
            this.Cat_AddImage_PicBox.BackColor = System.Drawing.Color.White;
            this.Cat_AddImage_PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cat_AddImage_PicBox.Location = new System.Drawing.Point(71, 205);
            this.Cat_AddImage_PicBox.Name = "Cat_AddImage_PicBox";
            this.Cat_AddImage_PicBox.Size = new System.Drawing.Size(127, 90);
            this.Cat_AddImage_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Cat_AddImage_PicBox.TabIndex = 7;
            this.Cat_AddImage_PicBox.TabStop = false;
            // 
            // Btn_ChImage
            // 
            this.Btn_ChImage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Btn_ChImage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ChImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ChImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChImage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_ChImage.Location = new System.Drawing.Point(71, 301);
            this.Btn_ChImage.Name = "Btn_ChImage";
            this.Btn_ChImage.Size = new System.Drawing.Size(127, 32);
            this.Btn_ChImage.TabIndex = 24;
            this.Btn_ChImage.Text = "Choose Icon";
            this.Btn_ChImage.UseVisualStyleBackColor = false;
            this.Btn_ChImage.Click += new System.EventHandler(this.Btn_ChImage_Click);
            // 
            // Main_panel1
            // 
            this.Main_panel1.BackColor = System.Drawing.Color.White;
            this.Main_panel1.Controls.Add(this.lblType);
            this.Main_panel1.Controls.Add(this.Type_comboBox);
            this.Main_panel1.Controls.Add(this.Btn_ChImage);
            this.Main_panel1.Controls.Add(this.Cat_AddImage_PicBox);
            this.Main_panel1.Controls.Add(this.panel2_TopTitel);
            this.Main_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_panel1.Location = new System.Drawing.Point(0, 0);
            this.Main_panel1.Name = "Main_panel1";
            this.Main_panel1.Size = new System.Drawing.Size(269, 426);
            this.Main_panel1.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Gray;
            this.lblType.Location = new System.Drawing.Point(9, 132);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 17);
            this.lblType.TabIndex = 25;
            this.lblType.Text = "Type";
            // 
            // Type_comboBox
            // 
            this.Type_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_comboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_comboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Type_comboBox.FormattingEnabled = true;
            this.Type_comboBox.Items.AddRange(new object[] {
            "Expenses",
            "Income"});
            this.Type_comboBox.Location = new System.Drawing.Point(11, 153);
            this.Type_comboBox.Name = "Type_comboBox";
            this.Type_comboBox.Size = new System.Drawing.Size(246, 26);
            this.Type_comboBox.TabIndex = 23;
            // 
            // Controls_panel1
            // 
            this.Controls_panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls_panel1.Controls.Add(this.Btn_Save);
            this.Controls_panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Controls_panel1.Location = new System.Drawing.Point(0, 360);
            this.Controls_panel1.Name = "Controls_panel1";
            this.Controls_panel1.Size = new System.Drawing.Size(269, 66);
            this.Controls_panel1.TabIndex = 31;
            // 
            // Categories_Add
            // 
            this.AcceptButton = this.Btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 426);
            this.Controls.Add(this.Controls_panel1);
            this.Controls.Add(this.Main_panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Categories_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Category";
            this.panel2_TopTitel.ResumeLayout(false);
            this.panel2_TopTitel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cat_AddImage_PicBox)).EndInit();
            this.Main_panel1.ResumeLayout(false);
            this.Main_panel1.PerformLayout();
            this.Controls_panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label lblTopTitle;
        private System.Windows.Forms.Panel panel2_TopTitel;
        public System.Windows.Forms.PictureBox Cat_AddImage_PicBox;
        private System.Windows.Forms.Button Btn_ChImage;
        private System.Windows.Forms.TextBox TxtCatName;
        private System.Windows.Forms.Panel Main_panel1;
        private System.Windows.Forms.Panel Controls_panel1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox Type_comboBox;
    }
}