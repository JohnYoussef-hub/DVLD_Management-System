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

namespace DVLD_Project.Test_Appointments
{
    public partial class frmScheduleTest : Form
    {
        enum enStatus { New = 1, Retake = 2 }
        private int _TestTypeID;

        public frmScheduleTest(int LDLid, string Dlicense, string name, int trial, decimal fees, int testType)
        {
            InitializeComponent();
            lblName.Text = name;
            lblLDLappID.Text = LDLid.ToString();
            lblDClass.Text = Dlicense;
            lblTrial.Text = (trial + 1).ToString();
            _TestTypeID = testType;
            lblFees.Text = fees.ToString() + " $";
            int RetakeFees = Convert.ToInt32(lblRetakeFees.Text);
            lblRetakeTotalFees.Text = ((RetakeFees * trial) + fees).ToString() + " $";

            if (trial > 0)
            {
                lblMainTitle.Text = "Schedule Retake Test";
            }
            else
            {

                lblMainTitle.Text = "Schedule Test";
                bunifuGroupBox1.ForeColor = Color.LightGray;
                bunifuLabel10.ForeColor = Color.LightGray;
                bunifuLabel6.ForeColor = Color.LightGray;
                lblRetakeFees.ForeColor = Color.LightGray;
                bunifuGroupBox1.Enabled = false;
            }
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            int TestTypeID = _TestTypeID;
            int LDLid = Convert.ToInt32(lblLDLappID.Text);
            DateTime AppointmentDate = dpDate.Value;
            decimal PaidFees = Convert.ToDecimal(lblRetakeTotalFees.Text.Replace(" $", ""));
            int CreatedByUserID = clsUser.GetUserIDbyUserName(clsUser._CurrentUserName);
            bool IsLocked = false;
            int? RetakeTestApplicationID = null;

            clsTestAppointments testAppointment = new clsTestAppointments()
            {
                AppointmentDate = AppointmentDate,
                CreatedByUserID = CreatedByUserID,
                IsLocked = IsLocked,
                LocalDrivingLicenseApplicationID = LDLid,
                PaidFees = Convert.ToInt32(PaidFees),
                RetakeTestApplicationID = RetakeTestApplicationID,
                TestTypeID = TestTypeID
            };

            if (testAppointment.AddNewAppointment())
            {
                MessageBox.Show("Appointment has been scheduled successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to schedule appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            dpDate.MinDate = DateTime.Now.AddDays(1);
        }
    }
}
