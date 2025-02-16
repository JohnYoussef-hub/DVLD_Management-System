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

namespace DVLD_Project.User
{
    public partial class frmUserInfoWithChangePass : Form
    {
        private int UserID;
        private int PersonID;

        public frmUserInfoWithChangePass(int PersonID, int UserID)
        {
            InitializeComponent();
            this.PersonID = PersonID;
            this.UserID = UserID;
            FillAll(PersonID, UserID);
        }

        private void UserInfoWithChangePass_Load(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtCurrentPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
        }


        public void FillAll(int PersonID, int UserID)
        {
            ctrlLoginInfo1.FillForm(UserID);
            ctrlPersonInformation1.LoadPersonInformationByID(PersonID);

            clsUser user = clsUser.GetUserByID(UserID);
            string UserPass = user._Password;
        }


        public void CheckPass(int UserID)
        {
            if(string.IsNullOrEmpty(txtCurrentPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if(txtCurrentPassword.Text != clsUser.GetUserByID(UserID)._Password)
            {
                MessageBox.Show("Current Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("New Password and Confirm Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                clsUser user = clsUser.GetUserByID(UserID);
                user._Password = txtNewPassword.Text;
                clsUser.UpdatePassword(UserID, txtNewPassword.Text);
                MessageBox.Show("Password Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbSeePass_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.UseSystemPasswordChar = !txtCurrentPassword.UseSystemPasswordChar;
            txtConfirmPassword.UseSystemPasswordChar = !txtConfirmPassword.UseSystemPasswordChar;
            txtNewPassword.UseSystemPasswordChar = !txtNewPassword.UseSystemPasswordChar;


            pbSeePass.Image = txtCurrentPassword.UseSystemPasswordChar == true
                ? Properties.Resources.invisible
                : Properties.Resources.see;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckPass(UserID);
        }
    }
}
