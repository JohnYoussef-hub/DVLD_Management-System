using BusinessLayer;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DVLD_Project.Login
{
    public partial class frmLogin : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public event Action OnSaveCredentialsEvent;
        public event Action OnUnSaveCredentialsEvent;


        public frmLogin()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmLogin_KeyDown);

            LoadLoginInfo();
            OnSaveCredentialsEvent += SaveLoginInfo;
            OnUnSaveCredentialsEvent += UnSaveLoginInfo;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pbSeePass.Image = Properties.Resources.invisible;
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool LoginProccess(string UserName, string Password)
        {
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!clsUser.Login(UserName, Password))
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!clsUser.IsUserActive(UserName))
            {
                MessageBox.Show("This user is not active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private void SaveLoginInfo()
        {
            string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\DVLD";


            Registry.SetValue(keyPath, "UserName", txtUserName.Text ?? "", RegistryValueKind.String);
            Registry.SetValue(keyPath, "Password", txtPassword.Text ?? "", RegistryValueKind.String);
            Registry.SetValue(keyPath, "SaveState", "true", RegistryValueKind.String);

        }

        private void UnSaveLoginInfo()
        {
            string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\DVLD";

            Registry.SetValue(keyPath, "UserName", "", RegistryValueKind.String);
            Registry.SetValue(keyPath, "Password", "", RegistryValueKind.String);
            Registry.SetValue(keyPath, "SaveState", "false", RegistryValueKind.String);

        }

        private void LoadLoginInfo()
        {
            string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\DVLD";
            string value1Data = Registry.GetValue(keyPath, "UserName", null) as string;
            string value2Data = Registry.GetValue(keyPath, "Password", null) as string;
            bool saveState = Registry.GetValue(keyPath, "SaveState", null) as string == "true";
            
            txtUserName.Text = value1Data ?? "";
            txtPassword.Text = value2Data ?? "";
            chkRememberMe.Checked = saveState;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LoginProccess(txtUserName.Text, txtPassword.Text))
            {
                (chkRememberMe.Checked ? OnSaveCredentialsEvent : OnUnSaveCredentialsEvent)?.Invoke();

                clsUser._CurrentUserName = txtUserName.Text;
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.ShowDialog();
                this.Close();
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Handled)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnLogin_Click(sender, e);
            }
        }

        private void pbSeePass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            pbSeePass.Image = txtPassword.UseSystemPasswordChar ? Properties.Resources.invisible : Properties.Resources.see;
        }
    }
}
