using BusinessLayer;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DVLD_Project.Login
{
    public partial class frmLogin : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private const string CredentialsFile = "user_credentials.txt";

        public frmLogin()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmLogin_KeyDown);
            LoadSavedCredentials();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pbSeePass.Image = Properties.Resources.invisible;
        }

        private void LoadSavedCredentials()
        {
            if (File.Exists(CredentialsFile))
            {
                string[] credentials = File.ReadAllLines(CredentialsFile);
                if (credentials.Length == 2)
                {
                    txtUserName.Text = credentials[0];
                    txtPassword.Text = credentials[1];
                    chkRememberMe.Checked = true;
                }
            }
        }

        private void SaveCredentials()
        {
            if (chkRememberMe.Checked)
            {
                File.WriteAllLines(CredentialsFile, new string[] { txtUserName.Text, txtPassword.Text });
            }
            else if (File.Exists(CredentialsFile))
            {
                File.Delete(CredentialsFile);
            }
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LoginProccess(txtUserName.Text, txtPassword.Text))
            {
                SaveCredentials();
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
