using System;
using System.Windows.Forms;

namespace RealBudgetUI.Accounts
{
    public partial class Accounts_ImagePicker : Form
    {
        //Define string to get the parameter from which form was this form called
        private readonly string CallingFormName;

        public Accounts_ImagePicker(string FromFormName)
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

        private void PicBox0_DoubleClick(object sender, EventArgs e)
        {
            //Get PictureBox clicked Event
            PictureBox PictureBoxClicked = sender as PictureBox;

            //We Respond to the form that called this form
            if (CallingFormName == "Accounts_Add")
            {
                //Send Image to Another form
                Accounts_Add obj_Form1 = (Accounts_Add)Application.OpenForms["Accounts_Add"];

                obj_Form1.Accounts_AddImage_PicBox.Image = PictureBoxClicked.Image;

                this.Close();
            }
            if (CallingFormName == "Accounts_View")
            {
                //Send Image to Another form
                Accounts_View obj_Form1 = (Accounts_View)Application.OpenForms["Accounts_View"];

                obj_Form1.Accounts_ViewImage_PicBox.Image = PictureBoxClicked.Image;

                this.Close();
            }
        }
    }
}
