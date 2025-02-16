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

namespace DVLD_Project.Test_Appointments.controls
{
    public partial class ctrlTestAppointmentsInfo : UserControl
    {
        public Bunifu.UI.WinForms.BunifuLabel LblLDLid
        {
            get { return lblDLAppID; }
        }

        public Bunifu.UI.WinForms.BunifuLabel LblApplicant
        {
            get { return lblApplicant; }
        }

        public Bunifu.UI.WinForms.BunifuLabel LblCreatedBy
        {
            get { return lblCreatedBy; }
        }

        public Bunifu.UI.WinForms.BunifuLabel LblDate
        {
            get { return lblDate; }
        }

        public Bunifu.UI.WinForms.BunifuLabel LblStatus
        {
            get { return lblStatus; }
        }

        public Bunifu.UI.WinForms.BunifuLabel LblFees
        {
            get { return lblFees; }
        }

        public Bunifu.UI.WinForms.BunifuLabel LblID
        {
            get { return lblID; }
        }

        public Bunifu.UI.WinForms.BunifuLabel LblStatusDate
        {
            get { return lblStatusDate; }
        }

        public Bunifu.UI.WinForms.BunifuLabel LblLicense
        {
            get { return lblLicense; }
        }


        public ctrlTestAppointmentsInfo()
        {
            InitializeComponent();
        }


        public void FillForm(int AppID, int LDLid, string Type, int PassedTests, string Status)
        {
            clsApplication app = clsApplication.GetApplicationByID(AppID);

            lblApplicant.Text = clsApplication.GetApplicantNameByID(AppID);
            lblCreatedBy.Text = app.CreatedByUserID.ToString();
            lblDate.Text = app.ApplicationDate.ToString();
            lblTestsPassed.Text = PassedTests.ToString();
            lblStatus.Text = Status;
            lblFees.Text = app.PaidFees.ToString() + " $";
            lblID.Text = AppID.ToString();
            lblDLAppID.Text = LDLid.ToString();
            lblStatusDate.Text = app.LastStatusDate.ToString();
            lblLicense.Text = Type;


        }
    }
}
