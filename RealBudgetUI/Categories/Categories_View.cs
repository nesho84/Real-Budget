using RealBudgetLibrary;
using System;
using System.Windows.Forms;

namespace RealBudgetUI.Categories
{
    public partial class Categories_View : Form
    {
        private readonly CategoriesModel category;

        //Instance of the Form Categories
        private readonly Categories frmCategories = null;

        //Define ImageList to get ImageList from Categories Form
        private readonly ImageList imageList;

        public Categories_View(Form frm, CategoriesModel catm, ImageList imgList)
        {
            //Initialize instance of the Form Categories
            frmCategories = frm as Categories;

            InitializeComponent();

            //Get Category Model from Categories Form
            category = catm;

            //Get ImageList posted from Categories Form
            imageList = imgList;

            //Fill the Form with passed Data
            LoadFormData();
        }

        private void LoadFormData()
        {
            TxtCatName.Focus();

            TxtCatName.Text = category.Name;
            Type_comboBox.Text = category.Type;

            //Set the Image Tag too, because somethimes we change the picture with CategoriesImagepicker
            Cat_ViewImage_PicBox.Image = imageList.Images[category.ImageIndex];
            Cat_ViewImage_PicBox.Image.Tag = category.ImageIndex; 
        }

        private void Edit_Category()
        {
            if (string.IsNullOrWhiteSpace(TxtCatName.Text))
            {
                MessageBox.Show("Please enter Category name.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Cat_ViewImage_PicBox.Image == null)
            {
                MessageBox.Show("Please choose Icon.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    category.Name = TxtCatName.Text;
                    category.Type = Type_comboBox.Text;
                    //Image.Tag as number passed from Categories_ImagePicker
                    category.ImageIndex = Convert.ToInt32(Cat_ViewImage_PicBox.Image.Tag);

                    CategoriesDataProcessor.UpdateCategory(category);

                    MessageBox.Show($"{Type_comboBox.Text} successfully updated.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Close();
                    //Refresh Parent Form
                    this.frmCategories.Load_Categories_ListView(Type_comboBox.Text);
                }
            }
        }

        private void Btn_ChangeImage_Click(object sender, EventArgs e)
        {
            //Letting know the form Category_ImapgePicker which form Called
            Categories_ImagePicker Cat_ChImg = new Categories_ImagePicker(this.Name);
            {
                Cat_ChImg.ShowDialog();
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            Edit_Category();
        }
    }
}
