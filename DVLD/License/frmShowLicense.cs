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
    public partial class frmShowLicense : Form
    {

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void frmManageApplications_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmManageApplications_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void frmManageApplications_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }




        string Class;
        string Name;
        int LicenseID;
        string NationalNo;
        string Gendor;
        string IssueDate;
        string IsActive;
        int DriverID;
        string ExpirationDate;
        string IsDetained;
        string Notes;
        string ImagePath;



        public frmShowLicense(string Class, string Name, int LicenseID, 
            string NationalNo, string Gendor, string IssueDate, string IsActive, 
            int DriverID, string ExpirationDate, string IsDetained, 
            string Notes, string ImagePath)
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(frmManageApplications_MouseDown);
            this.MouseMove += new MouseEventHandler(frmManageApplications_MouseMove);
            this.MouseUp += new MouseEventHandler(frmManageApplications_MouseUp);

            this.Class = Class;
            this.Name = Name;
            this.LicenseID = LicenseID;
            this.NationalNo = NationalNo;
            this.Gendor = Gendor;
            this.IssueDate = IssueDate;
            this.IsActive = IsActive;
            this.DriverID = DriverID;
            this.ExpirationDate = ExpirationDate;
            this.IsDetained = IsDetained;
            this.Notes = Notes;
            this.ImagePath = ImagePath;

            FillForm();
        }


        private void FillForm()
        {
            this.SuspendLayout();
            lblClass.Text = Class;
            lblName.Text = Name;
            lblLicenseID.Text = LicenseID.ToString();
            lblNationalNo.Text = NationalNo.ToString();
            lblGendor.Text = Gendor;
            lblIssueDate.Text = IssueDate;
            lblIsActive.Text = IsActive;
            lblDriverID.Text = DriverID.ToString();
            lblExpirationDate.Text = ExpirationDate;
            lblIsDetained.Text = IsDetained;
            txtNotes.Text = Notes;
            pbImage.ImageLocation = ImagePath;
        }


        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
