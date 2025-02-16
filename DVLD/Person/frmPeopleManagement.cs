using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Person
{
    public partial class frmPeopleManagement : Form
    {
        public frmPeopleManagement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMngPeople_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewPerson();
            frm.ShowDialog();
            ctrlpeopleDataTableWithFilter1.PeopleDGV.DataSource = BusinessLayer.clsPerson.GetAllPeople();
        }

    }
}
