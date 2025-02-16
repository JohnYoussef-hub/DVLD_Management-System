using Bunifu.UI.WinForms.BunifuButton;
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

namespace DVLD_Project.License.Controls
{
    public partial class ctrlLicenseInfoWithFilter : UserControl
    {

        public delegate void DisableBtnHandler();
        public event DisableBtnHandler OnDisableClick;

        public delegate void EnableBtnHandler();
        public event EnableBtnHandler OnEnableClick;

        public int LBLlicenseID = -1;
        public string LBLlicenseClass = "";
        public string ExpDate = "";

        private int Mode;

        public ctrlLicenseInfoWithFilter()
        {
            InitializeComponent();
            drbFindBy.SelectedIndex = 1;
        }

        public Bunifu.UI.WinForms.BunifuTextBox TxtSearch { get { return txtFindBy; } }

        private void ctrlLicenseInfoWithFilter_Load(object sender, EventArgs e)
        {
            drbFindBy.SelectedIndex = 1;
        }


        

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFindBy.Text))
            {
                MessageBox.Show("Please enter a value to search for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnDisableClick?.Invoke();
                return;
            }
            else if (!int.TryParse(txtFindBy.Text, out int result))
            {
                MessageBox.Show("Please enter a valid value to search for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnDisableClick?.Invoke();
                return;
            }
            else if (!clsLicense.IsLicenseFound(result))
            {
                MessageBox.Show("License not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnDisableClick?.Invoke();
                return;
            }
            else if (clsInternationalDrivingLicenseApp.IsLDLhasIDL(result))
            {
                ctrlLicenseInfo1.FillFormByLicenseID(result);
                MessageBox.Show("This license already has an international license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnDisableClick?.Invoke();
                return;
            }
            else if(clsLicense.IsLicenseEligibleForRenewal(result))
            {
                ctrlLicenseInfo1.FillFormByLicenseID(result);
                MessageBox.Show("This license is not eligible for renewal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnDisableClick?.Invoke();
                return;
            }
            else
            {
                ctrlLicenseInfo1.FillFormByLicenseID(result);
                LBLlicenseID = int.Parse(ctrlLicenseInfo1.LblLicenseID.Text);
                LBLlicenseClass = ctrlLicenseInfo1.LblClass.Text;
                ExpDate = ctrlLicenseInfo1.LblExpirationDate.Text;
                OnEnableClick?.Invoke();
            }
        }

        private void dropFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drbFindBy.SelectedIndex == 0)
            {
                pbSearch.Enabled = false;
                txtFindBy.Enabled = false;
            }
            else if (drbFindBy.SelectedIndex == 1)
            {
                pbSearch.Enabled = true;
                txtFindBy.Enabled = true;
            }
        }


    }
}
