using RealBudgetLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RealBudgetUI.Reports
{
    public partial class Reports : UserControl
    {
        private readonly List<CategoriesModel> categories = CategoriesDataProcessor.GetAllCategories();

        private readonly List<AccountsModel> accounts = AccountsDataProcessor.GetAllAccounts();

        public Reports()
        {
            InitializeComponent();

            //Load Chart
            Load_Reports_Charts();

            //Fill CatListView
            Load_Reports_ListView();
        }

        private void Load_Reports_Charts()
        {
            //Accounts Chart     
            chartFirst.DataSource = accounts;

            foreach (var item in accounts)
            {
                chartFirst.Series["Accounts"].Points.AddXY(item.Name, item.Balance);
            }
            //Change the Items Color
            if (chartFirst.Series["Accounts"].Points.Count > 0)
            {
                if (chartFirst.Series["Accounts"].Points[0] != null)
                {
                    chartFirst.Series["Accounts"].Points[0].Color = Color.LimeGreen;
                }
                if (chartFirst.Series["Accounts"].Points[1] != null)
                {
                    chartFirst.Series["Accounts"].Points[1].Color = Color.Green;
                }
                if (chartFirst.Series["Accounts"].Points[2] != null)
                {
                    chartFirst.Series["Accounts"].Points[2].Color = Color.GreenYellow;
                }
                if (chartFirst.Series["Accounts"].Points[3] != null)
                {
                    chartFirst.Series["Accounts"].Points[3].Color = Color.LightGreen;
                }
                else
                {
                    chartFirst.Series["Accounts"].Color = Color.SkyBlue;
                }
            }

            //Categories Chart
            chartSecond.DataSource = categories;
            chartSecond.Series["Categories"].XValueMember = "Name";
            chartSecond.Series["Categories"].YValueMembers = "Balance";
        }

        public void Load_Reports_ListView()
        {
            try
            {
                ReportsListView.Items.Clear();

                foreach (var cat in categories)
                {
                    ListViewItem lvi = new ListViewItem($"{ cat.Name }", cat.ImageIndex);
                    //Cast Model to Item.Tag
                    lvi.Tag = cat;
                    lvi.SubItems.Add($"{ GlobalConfig.SetFormat(cat.Balance) } { GlobalConfig.GetUserCurrency() }");
                    ReportsListView.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void View_Edit_Report()
        {
            var cat = (CategoriesModel)ReportsListView.SelectedItems[0].Tag;

            MessageBox.Show($"{cat.Name} { GlobalConfig.GetUserCurrency() } {cat.Balance.ToString()}");
        }

        private void ReportsListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            //Preventing users to resize the column header
            e.Cancel = true;
            e.NewWidth = ReportsListView.Columns[e.ColumnIndex].Width;
        }

        private void ReportsListView_DoubleClick(object sender, EventArgs e)
        {
            View_Edit_Report();
        }
    }
}
