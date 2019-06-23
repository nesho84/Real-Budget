using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RealBudgetLibrary;

namespace RealBudgetUI.Categories
{
    public partial class Categories : Form
    {
        private CategoriesModel category = new CategoriesModel();

        private List<CategoriesModel> categories = new List<CategoriesModel>();

        public Categories()
        {
            InitializeComponent();

            Load_Categories_ListView("Expenses");
        }       

        public void Load_Categories_ListView(string catType)
        {
            try
            {
                CatListView.Items.Clear();

                categories = CategoriesDataProcessor.GetAllCategories().FindAll(x => x.Type == catType);

                foreach (var cat in categories)
                {
                    ListViewItem lvi = new ListViewItem($"{ cat.Name }\n{ GlobalConfig.SetFormat(cat.Balance) } { cat.Currency }", cat.ImageIndex);
                    lvi.Tag = cat;
                    CatListView.Items.Add(lvi);

                    if (catType == "Expenses")
                    {
                        lblCatListTitle.Text = $"{ catType } ({ category.GetTotalOfExpenses(categories)}{ cat.Currency})";
                    }
                    else if (catType == "Income")
                    {
                        lblCatListTitle.Text = $"{ catType } ({ category.GetTotalOfIncome(categories)}{ category.Currency})";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void View_Edit_Category()
        {
            if (CatListView.SelectedItems.Count > 0)
            {
                category = (CategoriesModel)CatListView.SelectedItems[0].Tag;

                Categories_View frm = new Categories_View(this, category, this.CatImageList);

                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select Category", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Delete_Category()
        {
            if (CatListView.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this Category?",
                "RealBudget®", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        category = (CategoriesModel)CatListView.SelectedItems[0].Tag;

                        CategoriesDataProcessor.DeleteCategory(category);

                        MessageBox.Show("Category successfully deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Load_Categories_ListView(category.Type);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Select Category", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            //Get just first three characters of the Label lblCatListTitle (in this case Expenses=Exp and Incomes=Inc)
            string str = lblCatListTitle.Text.Substring(0, 3);

            if (str == "Exp")
            {
                Categories_Add CatAdd = new Categories_Add(this, "Expenses");
                {
                    CatAdd.ShowDialog();
                }
            }
            if (str == "Inc")
            {
                Categories_Add CatAdd = new Categories_Add(this, "Income");
                {
                    CatAdd.ShowDialog();
                }
            }
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            Load_Categories_ListView("Expenses");
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            View_Edit_Category();
        }

        private void CatListView_DoubleClick(object sender, EventArgs e)
        {
            View_Edit_Category();
        }

        private void Btn_Exp_Click(object sender, EventArgs e)
        {
            Load_Categories_ListView("Expenses");
        }

        private void Btn_Income_Click(object sender, EventArgs e)
        {
            Load_Categories_ListView("Income");
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete_Category();
        }

    }
}
