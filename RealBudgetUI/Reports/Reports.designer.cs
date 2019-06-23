namespace RealBudgetUI.Reports
{
    partial class Reports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.Main_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.chartFirst = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSecond = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Panel_ListView = new System.Windows.Forms.Panel();
            this.ReportsListView = new System.Windows.Forms.ListView();
            this._Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReportsImageList = new System.Windows.Forms.ImageList(this.components);
            this.Main_tableLayoutPanel.SuspendLayout();
            this.Main_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSecond)).BeginInit();
            this.Panel_ListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_tableLayoutPanel
            // 
            this.Main_tableLayoutPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Main_tableLayoutPanel.ColumnCount = 1;
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_tableLayoutPanel.Controls.Add(this.Main_Panel, 0, 0);
            this.Main_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Main_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Main_tableLayoutPanel.Name = "Main_tableLayoutPanel";
            this.Main_tableLayoutPanel.RowCount = 1;
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 477F));
            this.Main_tableLayoutPanel.Size = new System.Drawing.Size(1008, 477);
            this.Main_tableLayoutPanel.TabIndex = 3;
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Main_Panel.BackColor = System.Drawing.Color.White;
            this.Main_Panel.Controls.Add(this.chartFirst);
            this.Main_Panel.Controls.Add(this.chartSecond);
            this.Main_Panel.Controls.Add(this.Panel_ListView);
            this.Main_Panel.Location = new System.Drawing.Point(10, 10);
            this.Main_Panel.Margin = new System.Windows.Forms.Padding(10);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(988, 457);
            this.Main_Panel.TabIndex = 40;
            // 
            // chartFirst
            // 
            this.chartFirst.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chartFirst.BorderSkin.PageColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chartFirst.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            chartArea1.Name = "ChartArea1";
            this.chartFirst.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFirst.Legends.Add(legend1);
            this.chartFirst.Location = new System.Drawing.Point(0, 0);
            this.chartFirst.Margin = new System.Windows.Forms.Padding(0);
            this.chartFirst.Name = "chartFirst";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Accounts";
            this.chartFirst.Series.Add(series1);
            this.chartFirst.Size = new System.Drawing.Size(525, 261);
            this.chartFirst.TabIndex = 54;
            this.chartFirst.Text = "Accounts";
            title1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.DimGray;
            title1.Name = "chartFirstTitle";
            title1.Text = "Accounts";
            this.chartFirst.Titles.Add(title1);
            // 
            // chartSecond
            // 
            this.chartSecond.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chartSecond.BorderlineColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chartSecond.BorderSkin.PageColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chartSecond.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            chartArea2.Name = "ChartArea1";
            this.chartSecond.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSecond.Legends.Add(legend2);
            this.chartSecond.Location = new System.Drawing.Point(525, 0);
            this.chartSecond.Margin = new System.Windows.Forms.Padding(0);
            this.chartSecond.Name = "chartSecond";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.LabelForeColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Categories";
            this.chartSecond.Series.Add(series2);
            this.chartSecond.Size = new System.Drawing.Size(463, 261);
            this.chartSecond.TabIndex = 53;
            this.chartSecond.Text = "Categories by Type";
            title2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            title2.ForeColor = System.Drawing.Color.DimGray;
            title2.Name = "chartSecondTitle";
            title2.Text = "Categories";
            this.chartSecond.Titles.Add(title2);
            // 
            // Panel_ListView
            // 
            this.Panel_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Panel_ListView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Panel_ListView.Controls.Add(this.ReportsListView);
            this.Panel_ListView.Location = new System.Drawing.Point(0, 262);
            this.Panel_ListView.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_ListView.Name = "Panel_ListView";
            this.Panel_ListView.Size = new System.Drawing.Size(988, 197);
            this.Panel_ListView.TabIndex = 52;
            // 
            // ReportsListView
            // 
            this.ReportsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ReportsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ReportsListView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ReportsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._Name,
            this._Balance});
            this.ReportsListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsListView.FullRowSelect = true;
            this.ReportsListView.GridLines = true;
            this.ReportsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ReportsListView.LargeImageList = this.ReportsImageList;
            this.ReportsListView.Location = new System.Drawing.Point(14, 12);
            this.ReportsListView.Margin = new System.Windows.Forms.Padding(0);
            this.ReportsListView.Name = "ReportsListView";
            this.ReportsListView.Size = new System.Drawing.Size(961, 172);
            this.ReportsListView.SmallImageList = this.ReportsImageList;
            this.ReportsListView.TabIndex = 198;
            this.ReportsListView.Tag = "Expenses";
            this.ReportsListView.UseCompatibleStateImageBehavior = false;
            this.ReportsListView.View = System.Windows.Forms.View.Details;
            this.ReportsListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ReportsListView_ColumnWidthChanging);
            this.ReportsListView.DoubleClick += new System.EventHandler(this.ReportsListView_DoubleClick);
            // 
            // _Name
            // 
            this._Name.Text = "Name";
            this._Name.Width = 550;
            // 
            // _Balance
            // 
            this._Balance.Text = "Balance";
            this._Balance.Width = 390;
            // 
            // ReportsImageList
            // 
            this.ReportsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ReportsImageList.ImageStream")));
            this.ReportsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ReportsImageList.Images.SetKeyName(0, "0.png");
            this.ReportsImageList.Images.SetKeyName(1, "1.png");
            this.ReportsImageList.Images.SetKeyName(2, "2.png");
            this.ReportsImageList.Images.SetKeyName(3, "3.png");
            this.ReportsImageList.Images.SetKeyName(4, "4.png");
            this.ReportsImageList.Images.SetKeyName(5, "5.png");
            this.ReportsImageList.Images.SetKeyName(6, "6.png");
            this.ReportsImageList.Images.SetKeyName(7, "7.png");
            this.ReportsImageList.Images.SetKeyName(8, "8.png");
            this.ReportsImageList.Images.SetKeyName(9, "9.png");
            this.ReportsImageList.Images.SetKeyName(10, "10.png");
            this.ReportsImageList.Images.SetKeyName(11, "11.png");
            this.ReportsImageList.Images.SetKeyName(12, "12.png");
            this.ReportsImageList.Images.SetKeyName(13, "13.png");
            this.ReportsImageList.Images.SetKeyName(14, "14.png");
            this.ReportsImageList.Images.SetKeyName(15, "15.png");
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.Main_tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1008, 477);
            this.Main_tableLayoutPanel.ResumeLayout(false);
            this.Main_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSecond)).EndInit();
            this.Panel_ListView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel Main_tableLayoutPanel;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel Panel_ListView;
        public System.Windows.Forms.ListView ReportsListView;
        private System.Windows.Forms.ColumnHeader _Name;
        private System.Windows.Forms.ColumnHeader _Balance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSecond;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFirst;
        private System.Windows.Forms.ImageList ReportsImageList;
    }
}