using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RealBudgetLibrary;

namespace RealBudgetUI.Users
{
    public partial class Users : Form
    {
        //UserModel data
        private UsersModel user = new UsersModel();

        public Users()
        {
            InitializeComponent();

            Load_Users_LisView();
        }

        public void Load_Users_LisView()
        {
            try
            {
                UsersListView.Items.Clear();

                List<UsersModel> users = new List<UsersModel>();

                users = UsersDataProcessor.GetAllUsers().FindAll(x => x.Username != "admin");

                foreach (UsersModel user in users)
                {
                    ListViewItem lvi = new ListViewItem(user.Username, user.ImageIndex);
                    lvi.Tag = user;
                    UsersListView.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void View_Edit_ListView_User()
        {
            if (UsersListView.SelectedItems.Count > 0)
            {
                user = (UsersModel)UsersListView.SelectedItems[0].Tag;

                User_View Usserr_edit = new User_View(this, user);
                {
                    Usserr_edit.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please Select User", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Delete_User()
        {
            if (UsersListView.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this User?\n\nNote: Deleting User will " +
                                    "permanently delete all of its content. User information cannot be recovered.",
                                    "RealBudget®", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        user = (UsersModel)UsersListView.SelectedItems[0].Tag;

                        UsersDataProcessor.DeleteUser(user);

                        MessageBox.Show("User successfully deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Load_Users_LisView();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Select User", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BlockUser()
        {
            if (UsersListView.SelectedItems.Count > 0)
            {
                //Getting the selected user data from the selected ListView item Tag
                user = (UsersModel)UsersListView.SelectedItems[0].Tag;

                //Getting the current user data
                string SelectedCell = user.Blocked;

                string AreYouS_Block = "";
                string Success_Block = "";

                if (SelectedCell == "no")
                {
                    AreYouS_Block = $"Are you sure you want to block this Username: ({ user.Username })?";
                    Success_Block = $"The Username: ({ user.Username }) has been Successfully blocked.";
                }
                else if (SelectedCell == "yes")
                {
                    AreYouS_Block = $"Are you sure you want to unblock this Username: ({ user.Username })?";
                    Success_Block = $"The Username: ({ user.Username }) has been Successfully unblocked.";
                }

                if (MessageBox.Show(AreYouS_Block, "RealBudget®", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (SelectedCell == "no")
                        {
                            user.Blocked = "yes";
                        }
                        else if (SelectedCell == "yes")
                        {
                            user.Blocked = "no";
                        }

                        UsersDataProcessor.BlockUnblockUser(user);

                        MessageBox.Show(Success_Block, "RealBudget®", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Load_Users_LisView();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Select User", "RealBudget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete_User();
        }

        private void Btn_Block_Click(object sender, EventArgs e)
        {
            BlockUser();
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            Load_Users_LisView();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            View_Edit_ListView_User();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            User_Add User_addd = new User_Add(this);
            {
                User_addd.ShowDialog();
            }
        }

        private void UsersListView_DoubleClick(object sender, EventArgs e)
        {
            View_Edit_ListView_User();
        }

        private void Btn_Pass_Admin_Click(object sender, EventArgs e)
        {
            user = UsersDataProcessor.GetByUser_Id(GlobalConfig.GetUID());

            User_View usrAdminEdit = new User_View(this, user);
            {
                usrAdminEdit.ShowDialog();
            }
        }
    }
}
