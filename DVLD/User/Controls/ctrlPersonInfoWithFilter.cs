using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Project.Person;

namespace DVLD_Project.User.Controls
{
    public partial class ctrlPersonInfoWithFilter : UserControl
    {
        public ctrlPersonInformation CtrlPersonInfo { get { return ctrlPersonInformation1; } }

        public ctrlPersonInfoWithFilter()
        {
            InitializeComponent();
            dropFindBy.SelectedIndex = 0;
        }

        public ctrlPersonInfoWithFilter(int PersonID)
        {
            InitializeComponent();
            dropFindBy.SelectedIndex = 0;

            ctrlPersonInformation1.LoadPersonInformationByID(PersonID);
        }


        public Bunifu.UI.WinForms.BunifuLabel LblPersonID
        {
            get { return ctrlPersonInformation1.LblPersonID; }
        }


        public Bunifu.UI.WinForms.BunifuTextBox TxtFindBy
        {
            get { return txtFindBy; }
            set { txtFindBy = value; }
        }

        public Bunifu.UI.WinForms.BunifuDropdown DropFindBy
        {
            get { return dropFindBy; }
            set { dropFindBy = value; }
        }

        public Bunifu.UI.WinForms.BunifuPictureBox PbSearch
        {
            get { return pbSearch; }
        }

        public Bunifu.UI.WinForms.BunifuPictureBox PbAdd
        {
            get { return pbAdd; }
        }


        private void dropFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (dropFindBy.SelectedIndex)
            {
                case 0:
                    txtFindBy.Enabled = false;
                    txtFindBy.Text = "";
                    ctrlPersonInformation1.LoadPersonInformationByID(0);
                    //pbSearch.Enabled = false;
                    break;
                case 1:
                    txtFindBy.Enabled = true;
                    pbSearch.Enabled = true;
                    txtFindBy.Text = "";
                    txtFindBy.Focus();
                    break;
                case 2:
                    txtFindBy.Enabled = true;
                    pbSearch.Enabled = true;
                    txtFindBy.Text = "";
                    txtFindBy.Focus();
                    break;
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFindBy.Text))
            {
                MessageBox.Show("Please enter a value to search for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {


                switch (dropFindBy.SelectedIndex)
                {
                    case 2:
                        if (!ctrlPersonInformation1.LoadPersonInformationByNationalNo(txtFindBy.Text))
                        {
                            MessageBox.Show("Person not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        if (!txtFindBy.Text.All(char.IsDigit))
                        {
                            MessageBox.Show("Invalid input! Please enter numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        if (!ctrlPersonInformation1.LoadPersonInformationByID(Convert.ToInt32(txtFindBy.Text)))
                        {
                            MessageBox.Show("Person not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                }

            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson();
            frm.AddPerson += frmAddNewPerson_AddPerson;
            frm.ShowDialog();
        }

        private void frmAddNewPerson_AddPerson(int PersonID)
        {
            ctrlPersonInformation1.LoadPersonInformationByID(PersonID);
            dropFindBy.SelectedIndex = 1;
            txtFindBy.Text = PersonID.ToString();
        }

        private void ctrlPersonInformation1_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(pbAdd, "Add New Person");

            ToolTip tt2 = new ToolTip();
            tt2.SetToolTip(pbSearch, "Search");
        }
    }
}
