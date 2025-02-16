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

namespace DVLD_Project.License
{
    public partial class frmShowLicenseHistory : Form
    {
        public int _AppID {  get; }
        

        public frmShowLicenseHistory(int AppID)
        {
            InitializeComponent();
            _AppID = AppID;
            DataTable dt = clsLicense.GetLicenseHistorybyAppID(AppID);
            bunifuDataGridView1.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(bunifuDataGridView1.SelectedRows[0].Cells[0].Value);
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes && bunifuDataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    clsLicense.DeleteLicense(LicenseID);
                    MessageBox.Show("Record Deleted Successfully", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dt = clsLicense.GetLicenseHistorybyAppID(_AppID);
                    bunifuDataGridView1.DataSource = dt;
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

        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            deleteToolStripMenuItem.Enabled = false;
        }
    }
}
