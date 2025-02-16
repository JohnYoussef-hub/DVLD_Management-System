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

namespace DVLD_Project.Application_Types
{
    public partial class frmEditApplicationType : Form
    {
        public frmEditApplicationType()
        {
            InitializeComponent();
        }

        public frmEditApplicationType(int appID, string Title, double Fees)
        {
            InitializeComponent();
            lblID.Text = appID.ToString();
            txtTitle.Text = Title;
            txtFees.Text = Fees.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtFees.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(clsValidation.ValidateFloat(txtFees.Text) == false)
            {
                MessageBox.Show("Fees must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                UpdateApplicationType();
        }

        private void UpdateApplicationType()
        {
            int appID = int.Parse(lblID.Text);
            string Title = txtTitle.Text;
            double Fees = double.Parse(txtFees.Text);

            if (clsApplicationTypes.UpdateApplicationType(appID, Title, Fees)) 
            {
                MessageBox.Show("Application Type Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
