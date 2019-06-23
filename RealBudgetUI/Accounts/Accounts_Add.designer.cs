namespace RealBudgetUI.Accounts
{
    partial class Accounts_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts_Add));
            this.Main_panel1 = new System.Windows.Forms.Panel();
            this.Type_comboBox = new System.Windows.Forms.ComboBox();
            this.Buttons_Panel = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.Include_Total_checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2_TopTitel = new System.Windows.Forms.Panel();
            this.Accounts_AddImage_PicBox = new System.Windows.Forms.PictureBox();
            this.Btn_ChImage = new System.Windows.Forms.Button();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.Main_panel1.SuspendLayout();
            this.Buttons_Panel.SuspendLayout();
            this.panel2_TopTitel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accounts_AddImage_PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_panel1
            // 
            this.Main_panel1.BackColor = System.Drawing.Color.White;
            this.Main_panel1.Controls.Add(this.Type_comboBox);
            this.Main_panel1.Controls.Add(this.Buttons_Panel);
            this.Main_panel1.Controls.Add(this.txtGoal);
            this.Main_panel1.Controls.Add(this.Include_Total_checkBox1);
            this.Main_panel1.Controls.Add(this.txtCreditLimit);
            this.Main_panel1.Controls.Add(this.label7);
            this.Main_panel1.Controls.Add(this.txtBalance);
            this.Main_panel1.Controls.Add(this.label6);
            this.Main_panel1.Controls.Add(this.txtNotes);
            this.Main_panel1.Controls.Add(this.label5);
            this.Main_panel1.Controls.Add(this.label4);
            this.Main_panel1.Controls.Add(this.label2);
            this.Main_panel1.Controls.Add(this.panel2_TopTitel);
            this.Main_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_panel1.Location = new System.Drawing.Point(0, 0);
            this.Main_panel1.Name = "Main_panel1";
            this.Main_panel1.Size = new System.Drawing.Size(269, 480);
            this.Main_panel1.TabIndex = 2;
            // 
            // Type_comboBox
            // 
            this.Type_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_comboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_comboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Type_comboBox.FormattingEnabled = true;
            this.Type_comboBox.Items.AddRange(new object[] {
            "Regular",
            "Savings",
            "Credit"});
            this.Type_comboBox.Location = new System.Drawing.Point(12, 155);
            this.Type_comboBox.Name = "Type_comboBox";
            this.Type_comboBox.Size = new System.Drawing.Size(246, 26);
            this.Type_comboBox.TabIndex = 23;
            // 
            // Buttons_Panel
            // 
            this.Buttons_Panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Buttons_Panel.Controls.Add(this.Btn_Save);
            this.Buttons_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Buttons_Panel.Location = new System.Drawing.Point(0, 414);
            this.Buttons_Panel.Name = "Buttons_Panel";
            this.Buttons_Panel.Size = new System.Drawing.Size(269, 66);
            this.Buttons_Panel.TabIndex = 30;
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.White;
            this.Btn_Save.Image = global::RealBudgetUI.Properties.Resources.checkmark2_40px;
            this.Btn_Save.Location = new System.Drawing.Point(12, 10);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(246, 47);
            this.Btn_Save.TabIndex = 29;
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // txtGoal
            // 
            this.txtGoal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtGoal.Location = new System.Drawing.Point(12, 202);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(246, 22);
            this.txtGoal.TabIndex = 24;
            this.txtGoal.Text = "0";
            this.txtGoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Include_Total_checkBox1
            // 
            this.Include_Total_checkBox1.AutoSize = true;
            this.Include_Total_checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Include_Total_checkBox1.Location = new System.Drawing.Point(59, 383);
            this.Include_Total_checkBox1.Name = "Include_Total_checkBox1";
            this.Include_Total_checkBox1.Size = new System.Drawing.Size(151, 19);
            this.Include_Total_checkBox1.TabIndex = 28;
            this.Include_Total_checkBox1.Text = "Include in Total Balance";
            this.Include_Total_checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditLimit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCreditLimit.Location = new System.Drawing.Point(12, 346);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(246, 22);
            this.txtCreditLimit.TabIndex = 27;
            this.txtCreditLimit.Text = "0";
            this.txtCreditLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(11, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Credit Limit";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBalance.Location = new System.Drawing.Point(12, 303);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(246, 22);
            this.txtBalance.TabIndex = 26;
            this.txtBalance.Text = "0";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBalance.Leave += new System.EventHandler(this.TxtBalance_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(11, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Account Balance";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNotes.Location = new System.Drawing.Point(12, 245);
            this.txtNotes.MaxLength = 100;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(246, 37);
            this.txtNotes.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(11, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Notes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(11, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Account Goal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(11, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // panel2_TopTitel
            // 
            this.panel2_TopTitel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2_TopTitel.Controls.Add(this.Accounts_AddImage_PicBox);
            this.panel2_TopTitel.Controls.Add(this.Btn_ChImage);
            this.panel2_TopTitel.Controls.Add(this.lblTopTitle);
            this.panel2_TopTitel.Controls.Add(this.txtAccName);
            this.panel2_TopTitel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2_TopTitel.Location = new System.Drawing.Point(0, 0);
            this.panel2_TopTitel.Name = "panel2_TopTitel";
            this.panel2_TopTitel.Size = new System.Drawing.Size(269, 121);
            this.panel2_TopTitel.TabIndex = 2;
            // 
            // Accounts_AddImage_PicBox
            // 
            this.Accounts_AddImage_PicBox.BackColor = System.Drawing.Color.White;
            this.Accounts_AddImage_PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Accounts_AddImage_PicBox.Location = new System.Drawing.Point(12, 14);
            this.Accounts_AddImage_PicBox.Name = "Accounts_AddImage_PicBox";
            this.Accounts_AddImage_PicBox.Size = new System.Drawing.Size(63, 60);
            this.Accounts_AddImage_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Accounts_AddImage_PicBox.TabIndex = 7;
            this.Accounts_AddImage_PicBox.TabStop = false;
            // 
            // Btn_ChImage
            // 
            this.Btn_ChImage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Btn_ChImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_ChImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ChImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChImage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_ChImage.Location = new System.Drawing.Point(88, 49);
            this.Btn_ChImage.Name = "Btn_ChImage";
            this.Btn_ChImage.Size = new System.Drawing.Size(170, 25);
            this.Btn_ChImage.TabIndex = 9;
            this.Btn_ChImage.TabStop = false;
            this.Btn_ChImage.Text = "Choose Icon";
            this.Btn_ChImage.UseVisualStyleBackColor = false;
            this.Btn_ChImage.Click += new System.EventHandler(this.Btn_ChImage_Click);
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.AutoSize = true;
            this.lblTopTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTitle.ForeColor = System.Drawing.Color.White;
            this.lblTopTitle.Location = new System.Drawing.Point(86, 7);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(168, 32);
            this.lblTopTitle.TabIndex = 4;
            this.lblTopTitle.Text = "New Account";
            // 
            // txtAccName
            // 
            this.txtAccName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtAccName.Location = new System.Drawing.Point(12, 83);
            this.txtAccName.Multiline = true;
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(246, 28);
            this.txtAccName.TabIndex = 22;
            // 
            // Accounts_Add
            // 
            this.AcceptButton = this.Btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 480);
            this.Controls.Add(this.Main_panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Accounts_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Account";
            this.Main_panel1.ResumeLayout(false);
            this.Main_panel1.PerformLayout();
            this.Buttons_Panel.ResumeLayout(false);
            this.panel2_TopTitel.ResumeLayout(false);
            this.panel2_TopTitel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accounts_AddImage_PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_panel1;
        private System.Windows.Forms.CheckBox Include_Total_checkBox1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2_TopTitel;
        private System.Windows.Forms.Label lblTopTitle;
        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.Button Btn_ChImage;
        public System.Windows.Forms.PictureBox Accounts_AddImage_PicBox;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Panel Buttons_Panel;
        private System.Windows.Forms.ComboBox Type_comboBox;
    }
}