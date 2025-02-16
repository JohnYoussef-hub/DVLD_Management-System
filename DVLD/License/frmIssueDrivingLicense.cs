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
    public partial class frmIssueDrivingLicense : Form
    {
        int AppID;
        int LDLid;

        public frmIssueDrivingLicense(int AppID, int LDLid, string Type, int PassedTests, string Status)
        {
            InitializeComponent();
            this.AppID = AppID;
            this.LDLid = LDLid;
            ctrlTestAppointmentsInfo1.FillForm(AppID, LDLid, Type, PassedTests, Status);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            MakeHimDriver();
        }


        private void MakeHimDriver()
        {
            int PersonID = clsApplication.GetPersonIDbyAppID(AppID);
            int CreatedByUserID = clsUser.GetUserIDbyUserName(clsUser._CurrentUserName);
            DateTime CreatedDate = DateTime.Now;


            clsDriver driver = new clsDriver()
            {
                PersonID = PersonID,
                CreatedByUserID = CreatedByUserID,
                CreatedDate = CreatedDate
            };

            if (driver.AddNewDriver())
            {
                MessageBox.Show("Congratulations.. You become a driver Now!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add driver", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Issuelicense(driver.DriverID);
        }




        private void Issuelicense(int driverID)
        {
            int ApplicationID = AppID;
            int LicenseClass = clsApplicationTypes.GetApplicationType(AppID);
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = IssueDate.AddYears(7);
            string Notes = txtNotes.Text;
            decimal PaidFees = clsTestAppointments.GetFeesbyAppoID(ApplicationID);
            bool IsActive = true;
            int CreatedByUserID = clsUser.GetUserIDbyUserName(clsUser._CurrentUserName);


            clsLicense license = new clsLicense(ApplicationID, driverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, CreatedByUserID);
            if (license != null)
            {
                if (license.AddNewLicense())
                {
                    MessageBox.Show("License issued successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error issuing license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }




            }
        }
    }
}
