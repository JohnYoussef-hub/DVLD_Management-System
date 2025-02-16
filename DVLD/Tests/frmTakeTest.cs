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

namespace DVLD_Project.Tests
{
    public partial class frmTakeTest : Form
    {

        public delegate void PassTestHandler();
        public event PassTestHandler OnPassTest;


        private int _LDLid;
        private string _DClass;
        private string _Name;
        private int _Trial;
        private string _Date;
        private decimal _Fees;
        private int _TestType;
        private bool _IsRetake;
        private int _TestAppointmentID;
        private int _CreatedByUserID;
        private int _AppID;


        public frmTakeTest(int LDLid, string DClass, string Name, int Trial, 
            string Date, decimal Fees, int TestType, bool IsRetake, 
            int TestAppointmentID, int CreatedByUserID, bool IsLocked)
        {
            InitializeComponent();

            _LDLid = LDLid;
            _DClass = DClass;
            _Name = Name;
            _Trial = Trial;
            _Date = Date;
            _Fees = Fees;
            _TestType = TestType;
            _IsRetake = IsRetake;
            _TestAppointmentID = TestAppointmentID;
            _CreatedByUserID = CreatedByUserID;
            _AppID = clsTestAppointments.GetAppIDByLDLid(LDLid);


            lblLDLappID.Text = LDLid.ToString();
            lblDClass.Text = DClass.ToString();
            lblName.Text = Name.ToString();
            lblTrial.Text = Trial.ToString();
            lblDate.Text = Date.ToString();
            lblFees.Text = Fees.ToString() + " $";


            if(IsLocked == true)
            {
                lblDate.Enabled = false;
                btnSaveSchedule.Enabled = false;
                rbFail.Enabled = false;
                rbPass.Enabled = false;
            }

            WhichTest(TestType);

            if (IsRetake) lblMainTitle.Text = "Retake Test";
        }

        public void WhichTest(int type)
        {
            switch(type)
            {
                case 1:
                    bunifuGroupBox1.Text = "Vision Test";
                    break;

                case 2:
                    bunifuGroupBox1.Text = "Written Test";
                    break;

                case 3:
                    bunifuGroupBox1.Text = "Street Test";
                    break;

                default:
                    bunifuGroupBox1.Text = "Vision Test";
                    break;
            }
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            clsTest test = new clsTest()
            {
                TestAppointmentID = _TestAppointmentID,
                TestResult = rbFail.Checked ? false : true,
                Notes = txtNotes.Text,
                CreatedByUserID = _CreatedByUserID
            };

            bool isSaved = test.AddNewTest();

            if (isSaved)
            {
                if(test.TestResult == true)
                {
                    MessageBox.Show("The test saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    test.ChangeToLocked();
                    clsApplication.UpdatePassedTests(_AppID);
                    OnPassTest?.Invoke();

                    if(_TestType == 3 && test.TestResult == true)
                    {
                        clsApplication.ChangeAppToCompleted(_AppID);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("The test saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    test.ChangeToLocked();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Failed to save the test.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


    }
}
