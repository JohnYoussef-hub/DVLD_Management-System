using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.International_Driving_License
{
    public partial class frmManageInterApps : Form
    {
        public frmManageInterApps()
        {
            InitializeComponent();
        }



        private void frmManageInterApps_Load(object sender, EventArgs e)
        {
            dgvInterData.DataSource = BusinessLayer.clsInternationalDrivingLicenseApp.GetAllInternationalLicenses();
            drbFilterBy.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gdvInterData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblRecords.Text = dgvInterData.Rows.Count.ToString();
        }

        private void gdvInterData_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblRecords.Text = dgvInterData.Rows.Count.ToString();
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (dgvInterData == null)
                return;

            string filterBy = txtFilterBy.Text;
            if (drbFilterBy.SelectedItem == null)
                return;

            string filter = drbFilterBy.SelectedItem.ToString();
            DataView dv;

            dv = ((DataTable)dgvInterData.DataSource).DefaultView;

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
                    case "InternationalLicenseID":
                        dv.RowFilter = $"Convert(InternationalLicenseID, 'System.String') LIKE '%{filterBy}%'";
                        break;
                    case "DriverID":
                        dv.RowFilter = $"Convert(DriverID, 'System.String') LIKE '%{filterBy}%'";
                        break;
                    default:
                        dv.RowFilter = string.Empty;
                        break;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ILid = int.Parse(dgvInterData.SelectedRows[0].Cells[0].Value.ToString());



            DialogResult = MessageBox.Show("Are you sure you want to delete this International License?", "Delete International License", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( dgvInterData.SelectedRows.Count > 0 && DialogResult == DialogResult.Yes)
            {
                try
                {
                    BusinessLayer.clsInternationalDrivingLicenseApp.DeleteInternationalLicense(ILid);
                    dgvInterData.DataSource = BusinessLayer.clsInternationalDrivingLicenseApp.GetAllInternationalLicenses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This international license is related to other records, you can't delete it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a International License to delete.", "Delete International License", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

