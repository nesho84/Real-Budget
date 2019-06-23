using RealBudgetLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealBudgetUI.Categories
{
    public partial class Categories_Add : Form
    {
        //Getting the category type
        private readonly string categoryType;

        //Instance of the Form
        private readonly Categories frmCategories = null;

        public Categories_Add(Form frm, string catType)
        {
            frmCategories = frm as Categories;

            InitializeComponent();

            //Get Category Type as string(ex. expenses or income)
            categoryType = catType;

            //Load Title and Type
            lblTopTitle.Text = $"Add { categoryType }";
            Type_comboBox.Text = categoryType;
        }

        private void Add_Category()
        {
            if (string.IsNullOrWhiteSpace(TxtCatName.Text))
            {
                MessageBox.Show("Please enter Category name.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Cat_AddImage_PicBox.Image == null)
            {
                MessageBox.Show("Please Choose Icon.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    CategoriesModel category = new CategoriesModel();

                    category.User_Id = GlobalConfig.GetUID();
                    category.Name = TxtCatName.Text;
                    category.Type = Type_comboBox.Text;
                    category.Currency = GlobalConfig.GetUserCurrency();
                    //Image.Tag as number passed from Categories_ImagePicker to this PictureBox
                    category.ImageIndex = Convert.ToInt32(Cat_AddImage_PicBox.Image.Tag);

                    CategoriesDataProcessor.InsertCategory(category);

                    MessageBox.Show($"Category successfully created.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Close();

                    this.frmCategories.Load_Categories_ListView(categoryType);
                }
            }           
        }

        private void Btn_ChImage_Click(object sender, EventArgs e)
        {
            //Letting know the form Category_ImapgePicker which form Called
            Categories_ImagePicker Cat_ChImg = new Categories_ImagePicker(this.Name);
            {
                Cat_ChImg.ShowDialog();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Add_Category();
        }
    }
}
