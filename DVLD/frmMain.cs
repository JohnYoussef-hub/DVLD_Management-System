using BusinessLayer;
using DVLD_Project.Application;
using DVLD_Project.Application_Types;
using DVLD_Project.Driver;
using DVLD_Project.International_Driving_License;
using DVLD_Project.Login;
using DVLD_Project.Test_Types;
using DVLD_Project.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        
        private void accountSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DVLD_Project.Person.frmPeopleManagement();
            frm.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new DVLD_Project.User.frmUsersManagement();
            frm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = clsUser.GetUserIDbyUserName(clsUser._CurrentUserName);

            clsPerson person = clsPerson.GetPersonByUserID(UserID);
            int PersonID = person.PersonID;

            Form frm = new frmUserInfo(PersonID, UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = clsUser.GetUserIDbyUserName(clsUser._CurrentUserName);

            clsPerson person = clsPerson.GetPersonByUserID(UserID);
            int PersonID = person.PersonID;

            Form frm = new frmUserInfoWithChangePass(PersonID, UserID);
            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplications frm = new frmManageApplications();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewApplication frm = new frmAddNewApplication();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriversManagment frm = new frmDriversManagment();
            frm.ShowDialog();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInterApps frm = new frmManageInterApps();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueInternationalLicense frm = new frmIssueInternationalLicense();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Come back in 7 years to renew your license :)", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
