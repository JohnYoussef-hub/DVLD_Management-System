using DVLD_Project.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Driver
{
    public partial class frmDriversManagment : Form
    {
        public frmDriversManagment()
        {
            InitializeComponent();
        }

        private void LoadDriversData()
        {
            try
            {
                DataTable dt = BusinessLayer.clsDriver.GetAllDrivers();
                dgvDrivers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading drivers data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDriversManagment_Load(object sender, EventArgs e)
        {
            LoadDriversData();
            drdFilterBy.SelectedIndex = 0;
        }

        private void drdFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (dgvDrivers == null)
                return;

            string filterBy = txtFilterBy.Text;
            if (drdFilterBy.SelectedItem == null)
                return;

            string filter = drdFilterBy.SelectedItem.ToString();
            DataView dv;

            dv = ((DataTable)dgvDrivers.DataSource).DefaultView;

            if (string.IsNullOrWhiteSpace(filterBy))
            {
                dv.RowFilter = string.Empty;
            }
            else
            {
                switch (filter)
                {
                    case "None":
                        dv.RowFilter = string.Empty;
                        break;
                    case "DriverID":
                        dv.RowFilter = $"Convert(DriverID, 'System.String') LIKE '%{filterBy}%'";
                        break;
                    case "PersonID":
                        dv.RowFilter = $"Convert(PersonID, 'System.String') LIKE '%{filterBy}%'";
                        break;
                    default:
                        dv.RowFilter = string.Empty;
                        break;
                }
            }
        }

        private void dgvDrivers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblCount.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void dgvDrivers_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblCount.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int driverID = Convert.ToInt32(dgvDrivers.SelectedRows[0].Cells["DriverID"].Value);
            
            DialogResult res = MessageBox.Show("Are you sure you want to delete this driver?", "Delete Driver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    if (BusinessLayer.clsDriver.DeleteDriver(driverID))
                    {
                        MessageBox.Show("Driver deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDriversData();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting driver", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This driver is related to other records, you can't delete it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(dgvDrivers.SelectedRows[0].Cells["LicenseID"].Value);
            frmShowAllLicenses frm = new frmShowAllLicenses(LicenseID);
            frm.ShowDialog();
        }
    }
}
