using RealBudgetLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealBudgetUI.Reminder
{
    public partial class Reminder : Form
    {
        List<ReminderModel> reminders = new List<ReminderModel>();

        public Reminder()
        {
            InitializeComponent();

            txtTodayDateTime.Text = DateTime.Now.ToShortDateString();
            Start_dateTimePicker.Value = DateTime.Now;
            End_dateTimePicker.Value = DateTime.Now;

            Check_Notifications();

            Load_Reminder_ListView();
        }

        public void Load_Reminder_ListView()
        {
            try
            {
                ReminderListView.Items.Clear();

                reminders = ReminderDataProcessor.GetAllReminders();

                foreach (ReminderModel rem in reminders)
                {
                    ListViewItem lvi = new ListViewItem(rem.Title); //For ListView first Item: "allways first column as Item and the others as subItems"
                    //Casting Model Class to the Item.Tag
                    lvi.Tag = rem;
                    lvi.SubItems.Add(rem.RStart.ToShortDateString());
                    lvi.SubItems.Add(rem.REnd.ToShortDateString());
                    lvi.SubItems.Add(rem.Seen);
                    lvi.SubItems.Add(rem.Notes);
                    ReminderListView.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async Task PutTaskDelay()
        {
            //Wait 700ms second to loop throug ReminderModel properties
            await Task.Delay(750);
        }

        public async void Check_Notifications()
        {
            try
            {
                reminders = ReminderDataProcessor.GetAllReminders().Where(x => x.Seen == "no").ToList();

                foreach (ReminderModel item in reminders)
                { 
                    if (item.RStart.ToString("dd.MM.yyyy").Equals(txtTodayDateTime.Text))
                    {
                        //Call the Task
                        await PutTaskDelay();
                        //Then Show Form
                        Show_As_Notification(item);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void Show_As_Notification(ReminderModel rm)
        {
            Reminder_View rmv = new Reminder_View(this, rm);
            rmv.ShowDialog();
        }

        public void View_Edit_Reminder()
        {
            if (ReminderListView.SelectedItems.Count > 0)
            {
                ReminderModel reminder = (ReminderModel)ReminderListView.SelectedItems[0].Tag;

                Reminder_View rmv = new Reminder_View(this, reminder);
                rmv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select Reminder", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Refresh_ListView()
        {
            if (ReminderListView.Items.Count > 0)
            {
                ReminderListView.Items.Clear();

                Load_Reminder_ListView();
                Check_Notifications();
            }
        }

        private void Save_Reminder()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitel.Text))
                {
                    MessageBox.Show("Please enter Title.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Start_dateTimePicker.Value > End_dateTimePicker.Value)
                {
                    MessageBox.Show("Start Date musst be before the End Date.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (End_dateTimePicker.Value < Start_dateTimePicker.Value)
                {
                    MessageBox.Show("End Date musst be greater or equal to Start Date.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ReminderModel reminder = new ReminderModel();

                reminder.User_Id = GlobalConfig.GetUID();
                reminder.Title = txtTitel.Text;
                reminder.RStart = Convert.ToDateTime(Start_dateTimePicker.Value.ToString("dd.MM.yyyy"));
                reminder.REnd = Convert.ToDateTime(End_dateTimePicker.Value.ToString("dd.MM.yyyy"));
                reminder.Status = "present";
                reminder.Seen = "no";
                reminder.Notes = txtNotes.Text;

                ReminderDataProcessor.InsertReminder(reminder);

                MessageBox.Show($"{ reminder.Title } successfully created.", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Load_Reminder_ListView();
            }
        }

        private void Delete_Reminder()
        {
            if (ReminderListView.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this Reminder?",
                "RealBudget®", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        ReminderModel reminder = (ReminderModel)ReminderListView.SelectedItems[0].Tag;

                        ReminderDataProcessor.DeleteReminder(reminder);

                        MessageBox.Show("Reminder successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Load_Reminder_ListView();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Select Reminder", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Save_Reminder();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            txtTitel.Text = "";
            txtNotes.Text = "";
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh_ListView();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            View_Edit_Reminder();
        }

        private void ReminderListView_DoubleClick(object sender, EventArgs e)
        {
            View_Edit_Reminder();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete_Reminder();
        }

        private void TxtNotes_TextChanged(object sender, EventArgs e)
        {
            //Calculating the number of characters and display in the Label
            int TextCaracCounter = txtNotes.MaxLength - txtNotes.Text.Length;

            lblRichTextBoxTitle.Text = TextCaracCounter.ToString() + " Character{s) remaining [100 maximum]";
        }
    }
}
