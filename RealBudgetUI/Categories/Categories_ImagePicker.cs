using System;
using System.Windows.Forms;

namespace RealBudgetUI.Categories
{
    public partial class Categories_ImagePicker : Form
    {
        //Define string to get the value from which Form was this form called
        private readonly string CallingFormName;

        public Categories_ImagePicker(string FromFormName)
        {
            InitializeComponent();

            //string RespondToForm will be equal to parameter came from another Form (string CalledFromForm)
            CallingFormName = FromFormName;

            //Make Pictureboxes equal to Imagelist indexes
            Set_Pictureboxes_Tag();
        }

        private void Set_Pictureboxes_Tag()
        {
            //Filling pictureboxes Tag with numbers for others Forms to use as imageIndex
            picBox0.Image.Tag = 0;
            picBox1.Image.Tag = 1;
            picBox2.Image.Tag = 2;
            picBox3.Image.Tag = 3;
            picBox4.Image.Tag = 4;
            picBox5.Image.Tag = 5;
            picBox6.Image.Tag = 6;
            picBox7.Image.Tag = 7;
            picBox8.Image.Tag = 8;
            picBox9.Image.Tag = 9;
            picBox10.Image.Tag = 10;
            picBox11.Image.Tag = 11;
            picBox12.Image.Tag = 12;
            picBox13.Image.Tag = 13;
            picBox14.Image.Tag = 14;
            picBox15.Image.Tag = 15;
        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            //Get PictureBox clicked Event
            PictureBox PictureBoxClicked = sender as PictureBox;

            //We Respond to the form that called this form
            if (CallingFormName == "Categories_Add")
            {
                //Send Image to Another form
                Categories_Add obj_Form1 = (Categories_Add)Application.OpenForms["Categories_Add"];

                obj_Form1.Cat_AddImage_PicBox.Image = PictureBoxClicked.Image;
                obj_Form1.Cat_AddImage_PicBox.Image.Tag = PictureBoxClicked.Image.Tag;

                this.Close();
            }
            else if (CallingFormName == "Categories_View")
            {
                //Send Image to Another form
                Categories_View obj_Form2 = (Categories_View)Application.OpenForms["Categories_View"];

                obj_Form2.Cat_ViewImage_PicBox.Image = PictureBoxClicked.Image;
                obj_Form2.Cat_ViewImage_PicBox.Image.Tag = PictureBoxClicked.Image.Tag;

                this.Close();
            }
        }
    }
}
