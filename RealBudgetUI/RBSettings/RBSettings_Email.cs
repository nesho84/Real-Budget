using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RealBudgetUI.RBSettings
{
    public partial class RBSettings_Email : Form
    {
        public RBSettings_Email()
        {
            InitializeComponent();

            TxtEmail.Text = Properties.Settings.Default.Email_Settings;
        }

        private void Save_Email()
        {
            //Validating
            Regex RX = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!RX.IsMatch(TxtEmail.Text))
            {
                TxtEmail.BackColor = Color.Tomato;
                MessageBox.Show("Invalid Email Format!", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEmail.Focus();
                return;
            }
            //Save
            try
            {
                if (MessageBox.Show("Are you sure you want to change Software Email?", "RealBudget®", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Properties.Settings.Default.Email_Settings = TxtEmail.Text;
                    Properties.Settings.Default.Save();

                    MessageBox.Show("Email changed Successfully.", "RealBudget®", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Save_Email();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
