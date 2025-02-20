using BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD_Project.User
{
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }

        public frmAddNewUser(int UserID, int PersonID)
        {
            InitializeComponent();
            FillForm(UserID, PersonID);
        }


        public void FillForm(int UserID, int PersonID)
        {
            clsUser user = clsUser.GetUserByID(UserID);
            if (user != null)
            {
                lblMainTitle.Text = "Update User";
                lblUserID.Text = user._userID.ToString();
                txtUserName.Text = user._userName;
                txtPassword.Text = user._Password;
                txtConfPassword.Text = user._Password;
                chkIsActive.Checked = user._isActive;
            }

            ctrlPersonInfoWithFilter1.CtrlPersonInfo.LoadPersonInformationByID(PersonID);
            ctrlPersonInfoWithFilter1.DropFindBy.SelectedIndex = 1;
            ctrlPersonInfoWithFilter1.TxtFindBy.Text = PersonID.ToString();

        }

        public bool switchCaseByNationalNo()
        {
            if(clsPerson.IsPersonExistByNationalNo(ctrlPersonInfoWithFilter1.TxtFindBy.Text))
            {
                if (!clsUser.IsPersonHasUserByNationalNo(ctrlPersonInfoWithFilter1.TxtFindBy.Text))
                {
                    TabControl1.SelectedTab = tabLoginInfo;
                    return true;
                }
                else
                {
                    MessageBox.Show("This person already has a user account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(int.TryParse(ctrlPersonInfoWithFilter1.TxtFindBy.Text, out int result))
                if (clsPerson.IsPersonExistByPersonID(Convert.ToInt32(result)))
                {
                    if (!clsUser.IsPersonHasUserByPersonID(Convert.ToInt32(result)))
                    {
                        TabControl1.SelectedTab = tabLoginInfo;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("This person already has a user account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(string.IsNullOrEmpty(ctrlPersonInfoWithFilter1.TxtFindBy.Text))
            {
                MessageBox.Show("Please enter a value to search for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch(ctrlPersonInfoWithFilter1.DropFindBy.SelectedIndex)
            {
                case 1:
                    switchCaseByPersonID();
                    break;
                case 2:
                    switchCaseByNationalNo();
                    break;
            }
        }



        ///////////////////////// Login Info /////////////////////



        private void ValidateTextField(Bunifu.UI.WinForms.BunifuTextBox textBox, string errorMessage, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, errorMessage);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private void ValidatePasswordField(Bunifu.UI.WinForms.BunifuTextBox passwordTextBox, string errorMessage, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                errorProvider1.SetError(passwordTextBox, errorMessage);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(passwordTextBox, "");
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtUserName, "Please enter a valid username", e);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidatePasswordField(txtPassword, "Password is empty", e);
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidatePasswordField(txtConfPassword, "Password is empty", e);
        }


        public void SaveAddUpdate()
        {
            if(int.TryParse(ctrlPersonInfoWithFilter1.CtrlPersonInfo.LblPersonID.Text, out int result))

            {
                clsUser user;

                if (lblUserID.Text == "N/A")
                {
                    user = new clsUser
                    {
                        _userName = txtUserName.Text,
                        _Password = txtPassword.Text,
                        _isActive = chkIsActive.Checked
                    };
                }
                else
                {
                    clsUser temp = clsUser.GetUserByID(int.Parse(lblUserID.Text));

                    if (temp != null)
                    {
                        temp._userName = txtUserName.Text;
                        temp._Password = txtPassword.Text;
                        temp._isActive = chkIsActive.Checked;
                    }
                    user = new clsUser(temp._userID, temp._userName, temp._Password, temp._isActive);

                    

                }



                if (user.Save(result))
                {
                    MessageBox.Show("User saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblMainTitle.Text = "Update User";

                    txtUserName.Text = user._userName;
                    txtPassword.Text = user._Password;
                    txtConfPassword.Text = "";
                    chkIsActive.Checked = user._isActive;
                    lblUserID.Text = user._userID.ToString();
                }
                else
                {
                    MessageBox.Show("Failed to add user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtConfPassword.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtPassword.Text != txtConfPassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(lblMainTitle.Text == "N/A" && clsUser.IsUserNameUsed(txtUserName.Text))
            {
                MessageBox.Show("Username is already used", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SaveAddUpdate();
            }
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtConfPassword.UseSystemPasswordChar = true;
            pbSeePass.Image = Properties.Resources.invisible;

            if (lblMainTitle.Text == "Update User")
            {
                ctrlPersonInfoWithFilter1.DropFindBy.Enabled = false;
                ctrlPersonInfoWithFilter1.TxtFindBy.Enabled = false;
                ctrlPersonInfoWithFilter1.PbAdd.Enabled = false;
                ctrlPersonInfoWithFilter1.PbSearch.Enabled = false;
            }
        }

        private void pbSeePass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            txtConfPassword.UseSystemPasswordChar = !txtConfPassword.UseSystemPasswordChar;

            pbSeePass.Image = txtPassword.UseSystemPasswordChar == true
                ? Properties.Resources.invisible
                : Properties.Resources.see;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void frmAddNewUser_Load(object sender, EventArgs e)
        //{
        //    TabControl1.Selecting += new TabControlCancelEventHandler(TabControl1_Selecting);
        //}

        //private void TabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        //{
        //    if(int.TryParse(ctrlPersonInfoWithFilter1.CtrlPersonInfo.LblPersonID.Text, out int result))
        //    {
        //        if (e.TabPage == tabLoginInfo)
        //        {
        //            if (clsUser.IsPersonHasUserByPersonID(Convert.ToInt32(result)))
        //            {
        //                e.Cancel = false;
        //            }
        //            else
        //            {
        //                e.Cancel = true;
        //                MessageBox.Show("This person does not have a user account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //    else e.Cancel = true;
        //}
    }
}
