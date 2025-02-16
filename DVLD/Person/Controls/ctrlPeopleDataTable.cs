using Bunifu.UI.WinForms;
using DVLD_Project.Person.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Person
{
    public partial class ctrlPeopleDataTable : UserControl
    {

        public Bunifu.UI.WinForms.BunifuDataGridView PeopleDGV { get { return DataGridView1; } }

        public ctrlPeopleDataTable()
        {
            InitializeComponent();
        }

        public void LoadPeopleDataTable()
        {
            DataGridView1.DataSource = BusinessLayer.clsPerson.GetAllPeople();          
        }

        public void FilterByAnything(string ColumnName, string para)
        {
            string query = "select * from (SELECT People.PersonID, People.NationalNo, People.FirstName, " +
            "People.SecondName, People.ThirdName, People.LastName, " +
            "CASE WHEN People.Gendor = 0 THEN 'Male' WHEN People.Gendor = 1 THEN 'Female' ELSE 'Unknown' " +
            "END AS Gendor, People.DateOfBirth, Countries.CountryName AS Nationality, People.Phone, " +
            "People.Email FROM People INNER JOIN " +
            "Countries ON People.NationalityCountryID = Countries.CountryID)v " +
            "where " + ColumnName + " like '%" + para + "%'";
            DataGridView1.DataSource = BusinessLayer.clsPerson.GetPeopleByFilter(query);
        }

        private void ctrlPeopleDataTable_Load(object sender, EventArgs e)
        {
            LoadPeopleDataTable();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                int selectedPersonID = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["PersonID"].Value);
                frmAddNewPerson frm = new frmAddNewPerson(selectedPersonID);
                frm.ShowDialog();
                LoadPeopleDataTable();
            }
            else
            {
                MessageBox.Show("Please select a person to edit.", "Edit Person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                int selectedPersonID = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["PersonID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this person with ID = " + selectedPersonID + " ?", "Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes && DataGridView1.SelectedRows.Count > 0)
                {
                    try
                    {
                        BusinessLayer.clsPerson.DeletePerson(selectedPersonID);
                        LoadPeopleDataTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("This person is related to other records, you can't delete it.", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Please select a person to delete.", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void RowAffected(object sender, EventArgs e)
        {
            
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblCount.Text = DataGridView1.Rows.Count.ToString();
        }

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblCount.Text = DataGridView1.Rows.Count.ToString();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedPersonID = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["PersonID"].Value);
            frmPersonInfo frm = new frmPersonInfo(selectedPersonID);
            frm.ShowDialog();
        }
    }
}
