using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace DVLD_Project.License.Controls
{
    public partial class ctrlLicenseInfo : UserControl
    {
        public ctrlLicenseInfo()
        {
            InitializeComponent();
        }

        public Bunifu.UI.WinForms.BunifuLabel LblLicenseID { get { return lblLicenseID; } }
        public Bunifu.UI.WinForms.BunifuLabel LblClass { get { return lblClass; } }
        public Bunifu.UI.WinForms.BunifuLabel LblName { get { return lblName; } }
        public Bunifu.UI.WinForms.BunifuLabel LblNationalNo { get { return lblNationalNo; } }
        public Bunifu.UI.WinForms.BunifuLabel LblGendor { get { return lblGendor; } }
        public Bunifu.UI.WinForms.BunifuLabel LblIssueDate { get { return lblIssueDate; } }
        public Bunifu.UI.WinForms.BunifuLabel LblIsActive { get { return lblIsActive; } }
        public Bunifu.UI.WinForms.BunifuLabel LblDriverID { get { return lblDriverID; } }
        public Bunifu.UI.WinForms.BunifuLabel LblExpirationDate { get { return lblExpirationDate; } }
        public Bunifu.UI.WinForms.BunifuLabel LblIsDetained { get { return lblIsDetained; } }
        public Bunifu.UI.WinForms.BunifuTextBox TxtNotes { get { return txtNotes; } }
        public PictureBox PbImage { get { return pbImage; } }


        int AppID;
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



        public bool FillFormByLicenseID(int LicenseID)
        {
            DataTable dt = clsLicense.GetLicenseInfo("Licenses.LicenseID", LicenseID);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    AppID = Convert.ToInt32(dt.Rows[0]["ApplicationID"]);
                    this.LicenseID =LicenseID;
                    Name = dt.Rows[0]["FullName"].ToString();
                    NationalNo = dt.Rows[0]["NationalNo"].ToString();
                    Class = clsLicense.GetLicenseNameByID(Convert.ToInt32(dt.Rows[0]["LicenseClass"]));
                    Gendor = dt.Rows[0]["Gendor"].ToString();
                    IssueDate = Convert.ToDateTime(dt.Rows[0]["IssueDate"]).ToString("dd/MM/yyyy");
                    IsActive = dt.Rows[0]["IsActive"].ToString();
                    DriverID = Convert.ToInt32(dt.Rows[0]["DriverID"]);
                    ExpirationDate = Convert.ToDateTime(dt.Rows[0]["ExpirationDate"]).ToString("dd/MM/yyyy");
                    ImagePath = dt.Rows[0]["ImagePath"].ToString();
                    IsDetained = clsDetainLicense.IsDetainbyLicenseID(AppID) ? "Yes" : "No";
                    Notes = dt.Rows[0]["Notes"].ToString();
                    FillForm();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
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

    }
}
