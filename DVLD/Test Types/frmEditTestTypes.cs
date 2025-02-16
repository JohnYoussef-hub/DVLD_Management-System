using BusinessLayer;
using DVLD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Test_Types
{
    public partial class frmEditTestType : Form
    {
        public frmEditTestType()
        {
            InitializeComponent();
        }

        public frmEditTestType(int testID, string Title, string Description, double Fees)
        {
            InitializeComponent();
            lblID.Text = testID.ToString();
            txtTitle.Text = Title;
            txtDescription.Text = Description;
            txtFees.Text = Fees.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTestType();
        }

        private void UpdateTestType()
        {
            int testID = int.Parse(lblID.Text);
            string Title = txtTitle.Text;
            string Description = txtDescription.Text;
            double Fees = double.Parse(txtFees.Text);

            if(clsValidation.ValidateFloat(txtFees.Text) == false)
            {
                MessageBox.Show("Fees must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (clsTestTypes.UpdateTestType(testID, Title, Description, Fees))
            {
                MessageBox.Show("Test Type Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}


