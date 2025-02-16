using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BusinessLayer;
using DVLD_Project.Tests;

namespace DVLD_Project.Test_Appointments
{
    public partial class frmTestAppointments : Form
    {
        enum enTestType { Vision = 1, Written = 2, Street = 3 }
        private enTestType _TestType;

        private int _LDLid;
        private string _Name;
        private string _Dlicense;
        private int _Trial;
        private decimal _Fees;


        public frmTestAppointments(int AppID, int LDLid, string TestType, int PassedTests, string Status,
                                    string Name, string DLicense)
        {
            InitializeComponent();
            CheckWhichTest(TestType);
            ctrlTestAppointmentsInfo1.FillForm(AppID, LDLid, TestType, PassedTests, Status);
            _LDLid = LDLid;
            _Name = Name;
            _Dlicense = DLicense;
            _Trial = GetDataCounts();
            _Fees = clsTestTypes.GetTestFees((int)_TestType);
        }

        private int GetDataCounts()
        {
            return dgvTestAppointments.Rows.Count;
        }

        private void frmTestAppointments_Load(object sender, EventArgs e)
        {
            dgvTestAppointments.DataSource = clsTestAppointments.GetTestAppointmentsByType(_LDLid, (int)_TestType);

        }

        private void ChangeFormToVision()
        {
            lblMainTitle.Text = "Vision Test Appointments";
            pbMain.Image = Properties.Resources.visionTest;
            dgvTestAppointments.DataSource = clsTestAppointments.GetTestAppointmentsByType(_LDLid, 1);
        }

        private void ChangeFormToWritten()
        {
            lblMainTitle.Text = "Written Test Appointments";
            pbMain.Image = Properties.Resources.writtenTest;
            dgvTestAppointments.DataSource = clsTestAppointments.GetTestAppointmentsByType(_LDLid, 2);
        }

        private void ChangeFormToStreet()
        {
            lblMainTitle.Text = "Street Test Appointments";
            pbMain.Image = Properties.Resources.driveTest;
            dgvTestAppointments.DataSource = clsTestAppointments.GetTestAppointmentsByType(_LDLid, 3);
        }

        public void ChangeForm()
        {
            if (_TestType == enTestType.Vision)
            {
                ChangeFormToVision();
            }
            else if (_TestType == enTestType.Written)
            {
                ChangeFormToWritten();
            }
            else if (_TestType == enTestType.Street)
            {
                ChangeFormToStreet();
            }
        }


        public void CheckWhichTest(string TestType)
        {
            switch (TestType)
            {
                case "Vision":
                    _TestType = enTestType.Vision;
                    break;
                case "Written":
                    _TestType = enTestType.Written;
                    break;
                case "Street":
                    _TestType = enTestType.Street;
                    break;
            }
            ChangeForm();


        }

        private void btnAddAppo_Click(object sender, EventArgs e)
        {
            int LDLid = Convert.ToInt32(ctrlTestAppointmentsInfo1.LblLDLid.Text);
            int TestType = (int)_TestType;
            if (clsTestAppointments.IsEligibleToMakeNewAppo(LDLid, TestType) || dgvTestAppointments.SelectedRows.Count == 0)
            {
                frmScheduleTest frm = new frmScheduleTest(LDLid, _Dlicense, _Name, GetDataCounts(), _Fees, (int)_TestType);
                frm.ShowDialog();
                dgvTestAppointments.DataSource = clsTestAppointments.GetTestAppointmentsByType(_LDLid, (int)_TestType);
            }
            else
            {
                MessageBox.Show("You are not eligible to make a new appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isRetake = GetDataCounts() == 1 ? false : true;

            if (dgvTestAppointments.SelectedRows.Count > 0)
            {
                int selectedAppoID = Convert.ToInt32(dgvTestAppointments.SelectedRows[0].Cells[0].Value);
                frmTakeTest frm = new frmTakeTest(
                    _LDLid,
                    _Dlicense,
                    _Name,
                    _Trial + 1,
                    DateTime.Now.ToString("yyyy-MM-dd"),
                    Convert.ToDecimal(dgvTestAppointments.SelectedRows[0].Cells[2].Value),
                    (int)_TestType,
                    isRetake,
                    selectedAppoID,
                    clsUser.GetUserIDbyUserName(clsUser._CurrentUserName),
                    bool.Parse(dgvTestAppointments.SelectedRows[0].Cells[3].Value.ToString())
                );
                frm.OnPassTest += DisableAddNewAppBtn;
                frm.ShowDialog();
                dgvTestAppointments.DataSource = clsTestAppointments.GetTestAppointmentsByType(_LDLid, (int)_TestType);
            }
            else
            {
                MessageBox.Show("Please select an appointment to take the test.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DisableAddNewAppBtn()
        {
            btnAddAppo.Enabled = false;
            MessageBox.Show("You have passed the test successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            bool IsLocked = bool.Parse(dgvTestAppointments.SelectedRows[0].Cells[3].Value.ToString());
            if (IsLocked) takeTestToolStripMenuItem.Enabled = false;
            else takeTestToolStripMenuItem.Enabled = true;
        }
    }
}
