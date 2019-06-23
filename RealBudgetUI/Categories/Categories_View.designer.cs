namespace RealBudgetUI.Categories
{
    partial class Categories_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories_View));
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.Btn_ChangeImage = new System.Windows.Forms.Button();
            this.panel2_TopTitel = new System.Windows.Forms.Panel();
            this.TxtCatName = new System.Windows.Forms.TextBox();
            this.Main_panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Type_comboBox = new System.Windows.Forms.ComboBox();
            this.Controls_panel1 = new System.Windows.Forms.Panel();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Cat_ViewImage_PicBox = new System.Windows.Forms.PictureBox();
            this.panel2_TopTitel.SuspendLayout();
            this.Main_panel1.SuspendLayout();
            this.Controls_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cat_ViewImage_PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTitle.ForeColor = System.Drawing.Color.White;
            this.lblTopTitle.Location = new System.Drawing.Point(12, 25);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(246, 30);
            this.lblTopTitle.TabIndex = 4;
            this.lblTopTitle.Text = "View/Edit Category";
            this.lblTopTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_ChangeImage
            // 
            this.Btn_ChangeImage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Btn_ChangeImage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ChangeImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChangeImage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_ChangeImage.Location = new System.Drawing.Point(71, 301);
            this.Btn_ChangeImage.Name = "Btn_ChangeImage";
            this.Btn_ChangeImage.Size = new System.Drawing.Size(127, 32);
            this.Btn_ChangeImage.TabIndex = 24;
            this.Btn_ChangeImage.Text = "Change Icon";
            this.Btn_ChangeImage.UseVisualStyleBackColor = false;
            this.Btn_ChangeImage.Click += new System.EventHandler(this.Btn_ChangeImage_Click);
            // 
            // panel2_TopTitel
            // 
            this.panel2_TopTitel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(224)))), ((int)(((byte)(189)))));
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
            this.TxtCatName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TxtCatName.Location = new System.Drawing.Point(11, 83);
            this.TxtCatName.Multiline = true;
            this.TxtCatName.Name = "TxtCatName";
            this.TxtCatName.Size = new System.Drawing.Size(246, 28);
            this.TxtCatName.TabIndex = 22;
            this.TxtCatName.Text = "Name";
            // 
            // Main_panel1
            // 
            this.Main_panel1.BackColor = System.Drawing.Color.White;
            this.Main_panel1.Controls.Add(this.label2);
            this.Main_panel1.Controls.Add(this.Type_comboBox);
            this.Main_panel1.Controls.Add(this.Controls_panel1);
            this.Main_panel1.Controls.Add(this.Btn_ChangeImage);
            this.Main_panel1.Controls.Add(this.Cat_ViewImage_PicBox);
            this.Main_panel1.Controls.Add(this.panel2_TopTitel);
            this.Main_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_panel1.Location = new System.Drawing.Point(0, 0);
            this.Main_panel1.Name = "Main_panel1";
            this.Main_panel1.Size = new System.Drawing.Size(269, 426);
            this.Main_panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(9, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Type";
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
            this.Controls_panel1.Controls.Add(this.Btn_Edit);
            this.Controls_panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Controls_panel1.Location = new System.Drawing.Point(0, 360);
            this.Controls_panel1.Name = "Controls_panel1";
            this.Controls_panel1.Size = new System.Drawing.Size(269, 66);
            this.Controls_panel1.TabIndex = 32;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.White;
            this.Btn_Edit.Image = global::RealBudgetUI.Properties.Resources.checkmark2_40px;
            this.Btn_Edit.Location = new System.Drawing.Point(11, 10);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(246, 47);
            this.Btn_Edit.TabIndex = 25;
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Cat_View_Image_PicBox
            // 
            this.Cat_ViewImage_PicBox.BackColor = System.Drawing.Color.White;
            this.Cat_ViewImage_PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cat_ViewImage_PicBox.Location = new System.Drawing.Point(71, 205);
            this.Cat_ViewImage_PicBox.Name = "Cat_View_Image_PicBox";
            this.Cat_ViewImage_PicBox.Size = new System.Drawing.Size(127, 90);
            this.Cat_ViewImage_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Cat_ViewImage_PicBox.TabIndex = 7;
            this.Cat_ViewImage_PicBox.TabStop = false;
            // 
            // Categories_View
            // 
            this.AcceptButton = this.Btn_Edit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 426);
            this.Controls.Add(this.Main_panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Categories_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View/Edit Category";
            this.panel2_TopTitel.ResumeLayout(false);
            this.panel2_TopTitel.PerformLayout();
            this.Main_panel1.ResumeLayout(false);
            this.Main_panel1.PerformLayout();
            this.Controls_panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cat_ViewImage_PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTopTitle;
        private System.Windows.Forms.Button Btn_ChangeImage;
        private System.Windows.Forms.Panel panel2_TopTitel;
        private System.Windows.Forms.Panel Main_panel1;
        public System.Windows.Forms.PictureBox Cat_ViewImage_PicBox;
        private System.Windows.Forms.Button Btn_Edit;
        public System.Windows.Forms.TextBox TxtCatName;
        private System.Windows.Forms.Panel Controls_panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Type_comboBox;
    }
}