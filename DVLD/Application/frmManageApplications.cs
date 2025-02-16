using BusinessLayer;
using DVLD_Project.License;
using DVLD_Project.Test_Appointments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Application
{
    public partial class frmManageApplications : Form
    {
        public frmManageApplications()
        {
            InitializeComponent();
        }

        private void frmManageApplications_Load(object sender, EventArgs e)
        {
            drbFilterBy.SelectedIndex = 0;
            DataTable dt = clsApplication.GetAllApplications();
            bunifuDataGridView1.DataSource = dt;
        }

        private void txtFilterBy_TextChange(object sender, EventArgs e)
        {
            if (txtFilterBy.Text == "")
            {
                DataTable dt = clsApplication.GetAllApplications();
                bunifuDataGridView1.DataSource = dt;
            }
            else
            {
                DataTable dt = clsApplication.FilterWithNationalNo(txtFilterBy.Text);
                bunifuDataGridView1.DataSource = dt;
            }
        }

        private void bunifuDataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblRecords.Text = bunifuDataGridView1.Rows.Count.ToString();
        }

        private void bunifuDataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblRecords.Text = bunifuDataGridView1.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int ApplicationID = Convert.ToInt32(bunifuDataGridView1.SelectedRows[0].Cells[0].Value);
                if (clsApplication.CancelApplication(ApplicationID))
                {
                    MessageBox.Show("Application cancelled successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dt = clsApplication.GetAllApplications();
                    bunifuDataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Error cancelling application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            frmAddNewApplication frm = new frmAddNewApplication();
            frm.ShowDialog();
            bunifuDataGridView1.DataSource = clsApplication.GetAllApplications();
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            string Type = menuItem.Tag.ToString();
            int AppID = Convert.ToInt32(bunifuDataGridView1.SelectedRows[0].Cells[0].Value);
            int LDLid = clsTestAppointments.GetLDLidByAppID(AppID);
            int PassedTests = Convert.ToInt32(bunifuDataGridView1.SelectedRows[0].Cells[5].Value);
            string Status = bunifuDataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            string Name = bunifuDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string LicenseClass = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();


            frmTestAppointments frm = new frmTestAppointments(AppID, LDLid, Type, PassedTests, Status, Name, LicenseClass);
            frm.ShowDialog();
            bunifuDataGridView1.DataSource = clsApplication.GetAllApplications();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int PassedTests = Convert.ToInt32(bunifuDataGridView1.SelectedRows[0].Cells[5].Value);
            int AppID = Convert.ToInt32(bunifuDataGridView1.SelectedRows[0].Cells[0].Value);

            if (PassedTests == 0)
            {
                cancelApplicationToolStripMenuItem.Enabled = true;
                sechduleTestsToolStripMenuItem.Enabled = true;
                scheduleVisionTestToolStripMenuItem.Enabled = true;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                showLicensesHistoryToolStripMenuItem.Enabled = false;
            }
            else if (PassedTests == 1)
            {
                cancelApplicationToolStripMenuItem.Enabled = true;
                sechduleTestsToolStripMenuItem.Enabled = true;
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = true;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                showLicensesHistoryToolStripMenuItem.Enabled = false;
            }
            else if (PassedTests == 2)
            {
                cancelApplicationToolStripMenuItem.Enabled = true;
                sechduleTestsToolStripMenuItem.Enabled = true;
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = true;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                showLicensesHistoryToolStripMenuItem.Enabled = false;
            }
            else
            {
                cancelApplicationToolStripMenuItem.Enabled = false;
                sechduleTestsToolStripMenuItem.Enabled = false;
                if (clsLicense.IsHasLicensebyAppID(AppID))
                {
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                    showLicenseToolStripMenuItem.Enabled = true;
                    showLicensesHistoryToolStripMenuItem.Enabled = true;
                }
                else
                {
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                    showLicenseToolStripMenuItem.Enabled = false;
                    showLicensesHistoryToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppID = Convert.ToInt32(bunifuDataGridView1.SelectedRows[0].Cells[0].Value);
            int LDLid = clsTestAppointments.GetLDLidByAppID(AppID);
            int PassedTests = Convert.ToInt32(bunifuDataGridView1.SelectedRows[0].Cells[5].Value);
            string Status = bunifuDataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            frmIssueDrivingLicense frm = new frmIssueDrivingLicense(AppID, LDLid, "New Local Drivig License Service", PassedTests, Status);
            frm.ShowDialog();

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppID = Convert.ToInt32(bunifuDataGridView1.SelectedRows[0].Cells[0].Value);
            string Class = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string Name;
            int LicenseID;
            string NationalNo;
            string Gendor;
            string IssueDate;
            string IsActive;
            int DriverID;
            string ExpirationDate;
            string IsDetained;
            string Notes;
            string ImagePath;


            DataTable dt = clsLicense.GetLicenseInfo("Applications.ApplicationID", AppID);
            if (dt.Rows.Count > 0)
            {
                Name = dt.Rows[0]["FullName"].ToString();
                LicenseID = Convert.ToInt32(dt.Rows[0]["LicenseID"]);
                NationalNo = dt.Rows[0]["NationalNo"].ToString();
                Gendor = dt.Rows[0]["Gendor"].ToString();
                IssueDate = Convert.ToDateTime(dt.Rows[0]["IssueDate"]).ToString("dd/MM/yyyy");
                IsActive = dt.Rows[0]["IsActive"].ToString();
                DriverID = Convert.ToInt32(dt.Rows[0]["DriverID"]);
                ExpirationDate = Convert.ToDateTime(dt.Rows[0]["ExpirationDate"]).ToString("dd/MM/yyyy");
                ImagePath = dt.Rows[0]["ImagePath"].ToString();

                IsDetained = clsDetainLicense.IsDetainbyLicenseID(AppID) ? "Yes" : "No";

                Notes = dt.Rows[0]["Notes"].ToString();
                frmShowLicense frm = new frmShowLicense(Class, Name, LicenseID, NationalNo, Gendor, IssueDate, IsActive, DriverID, ExpirationDate, IsDetained, Notes, ImagePath);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No license found for this application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void showLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppID = Convert.ToInt32(bunifuDataGridView1.SelectedRows[0].Cells[0].Value);
            frmShowLicenseHistory frm = new frmShowLicenseHistory(AppID);
            frm.ShowDialog();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppID = Convert.ToInt32(bunifuDataGridView1.SelectedRows[0].Cells[0].Value);
            int records = int.Parse(lblRecords.Text);

            if(records < 1)
            {
                MessageBox.Show("No records to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (clsApplication.DeleteApplication(AppID))
                    {
                        MessageBox.Show("Application deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable dt = clsApplication.GetAllApplications();
                        bunifuDataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Error deleting application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
