using Bunifu.UI.WinForms.BunifuButton;
using BusinessLayer;
using DVLD_Project.License.Controls;
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
    public partial class frmIssueInternationalLicense : Form
    {
        public frmIssueInternationalLicense()
        {
            InitializeComponent();
            ctrlLicenseInfoWithFilter1.OnDisableClick += () => ButtonBehavior(btnIssue, false);
            ctrlLicenseInfoWithFilter1.OnEnableClick += () => ButtonBehavior(btnIssue, true);
        }

        void ButtonBehavior(BunifuButton btn, bool mood)
        {
            btn.Enabled = mood;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int LDLid = clsLicense.GetLDLfromLicenseID(int.Parse(ctrlLicenseInfoWithFilter1.LBLlicenseID.ToString()));
            int LicenseClass = clsLicense.GetLicenseIDbyName(ctrlLicenseInfoWithFilter1.LBLlicenseClass);

            if (clsInternationalDrivingLicenseApp.IsLDLhasIDL(LDLid))
            {
                MessageBox.Show("Select a person doesn't has an international driving license!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }
            else if (!clsLicense.IsLicenseActive(int.Parse(ctrlLicenseInfoWithFilter1.LBLlicenseID.ToString())))
            {
                MessageBox.Show("This license is not active!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }
            else if(LicenseClass != 3)
            {
                MessageBox.Show("An international license can only be issued on top of an ordinary license!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }
            else
            {
                int ApplicationID;
                int DriverID;
                int IssueUsingLocalLicenseID;
                string IssueDate;
                string ExpirationDate;
                int CreatedByUserID;
                bool IsActive;

                DataTable dt = clsInternationalDrivingLicenseApp.GetSomeInfoFromLicense(ctrlLicenseInfoWithFilter1.LBLlicenseID);
                ApplicationID = Convert.ToInt32(dt.Rows[0]["ApplicationID"]);
                DriverID = Convert.ToInt32(dt.Rows[0]["DriverID"]);
                IssueUsingLocalLicenseID = ctrlLicenseInfoWithFilter1.LBLlicenseID;
                IssueDate = DateTime.Now.ToString();
                ExpirationDate = DateTime.Now.AddYears(7).ToString();
                IsActive = true;
                CreatedByUserID = clsUser.GetUserIDbyUserName(clsUser._CurrentUserName);

                clsInternationalDrivingLicenseApp IDL = new clsInternationalDrivingLicenseApp()
                {
                    ApplicationID = ApplicationID,
                    DriverID = DriverID,
                    IssueUsingLocalLicenseID = IssueUsingLocalLicenseID,
                    IssueDate = Convert.ToDateTime(IssueDate),
                    ExpirationDate = Convert.ToDateTime(ExpirationDate),
                    IsActive = IsActive,
                    CreatedByUserID = CreatedByUserID
                };

                if (IDL.AddNewInternationalLicense())
                {
                    MessageBox.Show("International License Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnIssue.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error Issuing International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmIssueInternationalLicense_Load(object sender, EventArgs e)
        {
            btnIssue.Enabled = false;
        }
    }
}
