using Bunifu.UI.WinForms;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.License
{
    public partial class frmShowAllLicenses: Form
    {

        public int LicenseID { get; }
        public frmShowAllLicenses(int licenseID)
        {
            LicenseID = licenseID;
            InitializeComponent();
            LoadLicensesData();
        }

        private void LoadLicensesData()
        {
            try
            {
                int PersonID = clsLicense.GetPersonIDFromLicenseID(LicenseID);
                DataTable dt = BusinessLayer.clsLicense.GetAllLicensebyPersonID(PersonID);
                dgvAllLicenses.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading licenses data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(dgvAllLicenses.SelectedRows[0].Cells[0].Value);
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes && dgvAllLicenses.SelectedRows.Count > 0)
            {
                try
                {
                    clsLicense.DeleteLicense(LicenseID);
                    MessageBox.Show("Record Deleted Successfully", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLicensesData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This license is related to other records, you can't delete it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void frmShowAllLicenses_Load(object sender, EventArgs e)
        {
            deleteToolStripMenuItem.Enabled = false;
        }
    }
}
