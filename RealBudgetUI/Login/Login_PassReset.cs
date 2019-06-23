using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using RealBudgetLibrary;

namespace RealBudgetUI.Login
{
    public partial class Login_PassReset : Form
    {
        //Email Address stored in app.settings
        readonly string RealBudgetAppEmail = Properties.Settings.Default.Email_Settings;

        //declare strings for the username and password
        string StrUsername;
        string StrPassword;

        public Login_PassReset()
        {
            InitializeComponent();
        }

        private void Check_User_Email()
        {
            try
            {
                //Counting Emails in the list
                int emailsCount = UsersDataProcessor.GetAllUsers().FindAll(x => (x.Email == TxtToEmail.Text)).Count;

                //Getting specific Email from the list
                UsersModel user = UsersDataProcessor.GetAllUsers().Find(x => (x.Email == TxtToEmail.Text));

                if (user != null)
                {
                    StrUsername = user.Username;
                    StrPassword = user.Password;
                }

                if (emailsCount == 0)
                {
                    TxtToEmail.BackColor = Color.Tomato;
                    MessageBox.Show("Email address is not registered with RealBudget. Please check your Email Address and try again.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SendEmail();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendEmail()
        {
            string mailBodyHtml = "This Email was sent by RealBudget® - Personal Budget Software<br /><br /><b>Your Account:</b> <br /> Username: "
                            + StrUsername + "<br />Password: " + StrPassword + "<br /><br /><br />"
                            + "<i>You received this email service announcement to update you about important changes to your account.<br /><br />RealBudget®</i>";

            var msg = new MailMessage(RealBudgetAppEmail, TxtToEmail.Text, "RealBudget® - Password Recovery", mailBodyHtml);

            try
            {
                msg.To.Add(TxtToEmail.Text);
                msg.IsBodyHtml = true;
                var smtpClient = new SmtpClient("smtp.live.com", 587)
                {
                    UseDefaultCredentials = true,
                    Credentials = new NetworkCredential(RealBudgetAppEmail, "yourPassword"),
                    EnableSsl = true
                }; //**if your from email address is "from@hotmail.com" then host should be "smtp.hotmail.com"**
                smtpClient.Send(msg);
                MessageBox.Show("Thank You. Please check your Inbox, an email is on the way...", "RealBudget®", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ///Check if the OK button was clicked on the dialog box. ///
                if (this.DialogResult == DialogResult.OK)
                {
                    /// Optional: Call the Dispose method when you are finished with the dialog box. ///
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            Check_User_Email();
        }

        private void Email_txt_TextChanged(object sender, EventArgs e)
        {
            if (TxtToEmail.TextLength > 0)
            {
                TxtToEmail.BackColor = SystemColors.Window;
            }
        }
    }
}
