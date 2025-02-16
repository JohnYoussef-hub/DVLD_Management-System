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

namespace DVLD_Project.Application
{
    public partial class frmAddNewApplication : Form
    {
        public frmAddNewApplication()
        {
            InitializeComponent();
        }

        private void AddNewLDLApp(int AppID, int LicenseClass)
        {
            if (clsLocalDrivingLicenseApp.AddNewLDLApplication(AppID, LicenseClass))
            {
                MessageBox.Show("Local Driving License Application saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error saving application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            int PersonID;
            int LicensetypeID = drbLicenseClass.SelectedIndex + 1;

            if(ctrlPersonInfoWithFilter1.LblPersonID.Text == "???")
            {
                MessageBox.Show("Please search for a person first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!clsUser.IsPersonHasUserByPersonID(int.Parse(ctrlPersonInfoWithFilter1.LblPersonID.Text)))
            {
                MessageBox.Show("This person doesn't has a user account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(ctrlPersonInfoWithFilter1.LblPersonID.Text, out PersonID))
            {
                if (clsApplication.IsEligibleToMakeNewApp(PersonID, LicensetypeID))
                {
                    clsApplication application = new clsApplication();
                    application.ApplicantPersonID = PersonID;
                    application.ApplicationTypeID = LicensetypeID;
                    application.ApplicationDate = DateTime.Now;
                    application.ApplicationStatus = 1;
                    application.LastStatusDate = DateTime.Now;
                    application.PaidFees = decimal.Parse(lblAppFees.Text);
                    application.CreatedByUserID = clsUser.GetUserIDbyUserName(clsUser._CurrentUserName);
                    application.PassedTests = 0;

                    if (application.Save())
                    {
                        MessageBox.Show("Application saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        lblAppID.Text = application.ApplicationID.ToString();
                        lblMainTitle.Text = "Update Application ID: " + application.ApplicationID.ToString();

                        ctrlPersonInfoWithFilter1.TxtFindBy.Enabled = false;
                        ctrlPersonInfoWithFilter1.DropFindBy.Enabled = false;
                        ctrlPersonInfoWithFilter1.PbAdd.Enabled = false;
                        ctrlPersonInfoWithFilter1.PbSearch.Enabled = false;

                        AddNewLDLApp(application.ApplicationID, LicensetypeID);

                    }
                    else
                    {
                        MessageBox.Show("Error saving application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This person is not eligible to make a new application\n\nNote: (have already an application from this type \nor have already a license from this type)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool switchCaseByNationalNo()
        {
            if (clsPerson.IsPersonExistByNationalNo(ctrlPersonInfoWithFilter1.TxtFindBy.Text))
            {
                if (clsUser.IsPersonHasUserByNationalNo(ctrlPersonInfoWithFilter1.TxtFindBy.Text))
                {
                    TabControl1.SelectedTab = tabLoginInfo;
                    return true;
                }
                else
                {
                    MessageBox.Show("This person doesn't has a user account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("This person does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool switchCaseByPersonID()
        {
            if (int.TryParse(ctrlPersonInfoWithFilter1.TxtFindBy.Text, out int result))
                if (clsPerson.IsPersonExistByPersonID(Convert.ToInt32(result)))
                {
                    if (clsUser.IsPersonHasUserByPersonID(Convert.ToInt32(result)))
                    {
                        TabControl1.SelectedTab = tabLoginInfo;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("This person doesn't has a user account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("This person does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            return false;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ctrlPersonInfoWithFilter1.TxtFindBy.Text))
            {
                MessageBox.Show("Please enter a value to search for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (ctrlPersonInfoWithFilter1.DropFindBy.SelectedIndex)
            {
                case 1:
                    switchCaseByPersonID();
                    break;
                case 2:
                    switchCaseByNationalNo();
                    break;
            }
        }

            //switch (ctrlPersonInfoWithFilter1.DropFindBy.SelectedIndex)
            //{
            //    case 1:
            //        switchCaseByPersonID();
            //        break;
            //    case 2:
            //        switchCaseByNationalNo();
            //        break;
            //}
        

        private void frmAddNewApplication_Load(object sender, EventArgs e)
        {
            lblAppDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsUser._CurrentUserName;
            drbLicenseClass.SelectedIndex = 0;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
