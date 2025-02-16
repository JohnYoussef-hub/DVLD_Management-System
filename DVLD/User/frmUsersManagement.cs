using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD_Project.User
{
    public partial class frmUsersManagement : Form
    {
        public frmUsersManagement()
        {
            InitializeComponent();
            drdFilterBy.SelectedIndex = 0;
            LoadUsersDataTable();
            lblCount.Text = UsersDataGridView1.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadUsersDataTable()
        {
            UsersDataGridView1.DataSource = clsUser.GetAllUsers();
        }

        public void FilterByAnything(string ColumnName, string para)
        {
            string query = "select * from (SELECT Users.UserID, Users.PersonID, " +
                           "CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.ThirdName, ' ', People.LastName) AS FullName, " +
                           "Users.UserName, Users.IsActive " +
                           "FROM Users " +
                           "INNER JOIN People ON Users.PersonID = People.PersonID)v " +
                           "WHERE " + ColumnName + " LIKE '%" + para + "%'";
            UsersDataGridView1.DataSource = clsUser.GetUsersByFilter(query);
        }

        private void drdFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (drdFilterBy.SelectedIndex)
            {
                case 0:
                    txtFilterBy.Visible = false;
                    txtFilterBy.Text = "";
                    LoadUsersDataTable();
                    break;
                case 1:
                    txtFilterBy.Visible = true;
                    FilterByAnything("UserID", txtFilterBy.Text);
                    break;
                case 2:
                    txtFilterBy.Visible = true;
                    FilterByAnything("PersonID", txtFilterBy.Text);
                    break;
                case 3:
                    txtFilterBy.Visible = true;
                    FilterByAnything("FullName", txtFilterBy.Text);
                    break;
                case 4:
                    txtFilterBy.Visible = true;
                    FilterByAnything("UserName", txtFilterBy.Text);
                    break;
                case 5:
                    txtFilterBy.Visible = true;
                    FilterByAnything("IsActive", txtFilterBy.Text);
                    break;
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            drdFilterBy_SelectedIndexChanged(sender, e);
        }

        private void UsersDataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblCount.Text = UsersDataGridView1.Rows.Count.ToString();
        }

        private void UsersDataGridView1_ControlAdded(object sender, ControlEventArgs e)
        {
            lblCount.Text = UsersDataGridView1.Rows.Count.ToString();
        }

        private void UsersDataGridView1_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            lblCount.Text = UsersDataGridView1.Rows.Count.ToString();
        }

        private void UsersDataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblCount.Text = UsersDataGridView1.Rows.Count.ToString();
        }

        private void btnAddMngUsers_Click(object sender, EventArgs e)
        {
            frmAddNewUser frm = new frmAddNewUser();
            frm.ShowDialog();
            LoadUsersDataTable();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UsersDataGridView1.SelectedRows.Count > 0)
            {
                int UserID = Convert.ToInt32(UsersDataGridView1.SelectedRows[0].Cells[0].Value);
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        clsUser.DeleteUser(UserID);
                        MessageBox.Show("Record Deleted Successfully", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsersDataTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("This user is related to other records, you can't delete it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(UsersDataGridView1.SelectedRows[0].Cells[0].Value);
            int PersonID = Convert.ToInt32(UsersDataGridView1.SelectedRows[0].Cells[1].Value);

            frmAddNewUser frm = new frmAddNewUser(UserID, PersonID);
            frm.ShowDialog();
            LoadUsersDataTable();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(UsersDataGridView1.SelectedRows[0].Cells[0].Value);
            int PersonID = Convert.ToInt32(UsersDataGridView1.SelectedRows[0].Cells[1].Value);

            frmUserInfo frm = new frmUserInfo(PersonID, UserID);
            frm.ShowDialog();

        }

        private void ChangePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(UsersDataGridView1.SelectedRows[0].Cells[0].Value);
            int PersonID = Convert.ToInt32(UsersDataGridView1.SelectedRows[0].Cells[1].Value);

            frmUserInfoWithChangePass frm = new frmUserInfoWithChangePass(PersonID, UserID);
            frm.ShowDialog();
        }
    }
}
