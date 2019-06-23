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

namespace RealBudgetUI.Reminder
{
    public partial class Reminder_View : Form
    {
        private readonly ReminderModel reminder;

        //Instance of the Form Reminder
        private readonly Reminder frmReminder = null;

        public Reminder_View(Form frm, ReminderModel rm)
        {
            frmReminder = frm as Reminder;

            InitializeComponent();

            reminder = rm;

            LoadFormData();
        }

        private void LoadFormData()
        {
            lblStatus.Text = reminder.Status;
            txtTitel.Text = reminder.Title;
            txtStart.Text = reminder.RStart.ToShortDateString();
            txtEnd.Text = reminder.REnd.ToShortDateString();
            txtSeen.Text = reminder.Seen;
            Notes_richTextBox.Text = reminder.Notes;

            if (lblStatus.Text == "done")
            {
                lblStatus.ForeColor = Color.DarkKhaki;
                Btn_Done.Enabled = false;
                Btn_Present.Enabled = true;
                Btn_Missed.Enabled = true;
            }
            else if (lblStatus.Text == "present")
            {
                lblStatus.ForeColor = Color.SkyBlue;
                Btn_Present.Enabled = false;
                Btn_Done.Enabled = true;
                Btn_Missed.Enabled = true;
            }
            else if (lblStatus.Text == "missed")
            {
                lblStatus.ForeColor = Color.Red;
                Btn_Missed.Enabled = false;
                Btn_Done.Enabled = true;
                Btn_Present.Enabled = true;
            }
        }

        private void Reminder_View_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Close form with presing ESC
            if (e.KeyChar == (char)27)
            {
                this.Close();
            }
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                reminder.Seen = "yes";

                ReminderDataProcessor.UpdateReminder(reminder);

                MessageBox.Show($"Reminder { reminder.Title } marked as \"seen\".", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
                //Refresh parent ListView
                this.frmReminder.Load_Reminder_ListView();
            }
        }

        private void Btn_Done_Click(object sender, EventArgs e)
        {
            try
            {
                reminder.Status = "done";
                reminder.Seen = "yes";

                ReminderDataProcessor.UpdateReminder(reminder);

                MessageBox.Show($"Reminder { reminder.Title } Status changed successfully.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
                //Refresh ListView and start the Timer to check Notifications
                this.frmReminder.Load_Reminder_ListView();
            }
        }

        private void Btn_Missed_Click(object sender, EventArgs e)
        {
            try
            {
                reminder.Status = "missed";
                reminder.Seen = "yes";

                ReminderDataProcessor.UpdateReminder(reminder);

                MessageBox.Show($"Reminder { reminder.Title } Status changed successfully.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
                //Refresh ListView and start the Timer to check Notifications
                this.frmReminder.Load_Reminder_ListView();
            }
        }

        private void Btn_Present_Click(object sender, EventArgs e)
        {
            try
            {
                reminder.Status = "present";
                reminder.Seen = "yes";

                ReminderDataProcessor.UpdateReminder(reminder);

                MessageBox.Show($"Reminder { reminder.Title } Status changed successfully.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
                //Refresh Parent ListView
                this.frmReminder.Load_Reminder_ListView();
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Reminder?",
               "RealBudget®", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ReminderDataProcessor.DeleteReminder(reminder);

                    MessageBox.Show("Reminder successfully deleted.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Close();

                    frmReminder.Load_Reminder_ListView();
                }
            }
            else
            {
                return;
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
