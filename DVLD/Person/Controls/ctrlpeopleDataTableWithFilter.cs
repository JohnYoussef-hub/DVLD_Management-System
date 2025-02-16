using Bunifu.UI.WinForms;
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
    public partial class ctrlpeopleDataTableWithFilter : UserControl
    {
        public ctrlpeopleDataTableWithFilter()
        {
            InitializeComponent();
        }

        public Bunifu.UI.WinForms.BunifuDataGridView PeopleDGV { get { return ctrlPeopleDataTable1.PeopleDGV; } }



        private void ctrlpeopleDataTableWithFilter_Load(object sender, EventArgs e)
        {
            drdFilterBy.SelectedIndex = 0;
        }

        private void drdFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (drdFilterBy.SelectedIndex)
            {
                case 0:
                    txtFilterBy.Visible = false;
                    ctrlPeopleDataTable1.LoadPeopleDataTable();
                    break;
                case 1:
                    txtFilterBy.Visible = true;
                    ctrlPeopleDataTable1.FilterByAnything("PersonID", txtFilterBy.Text);
                    break;
                case 2:
                    txtFilterBy.Visible = true;
                    ctrlPeopleDataTable1.FilterByAnything("NationalNo", txtFilterBy.Text);
                    break;
                case 3:
                    txtFilterBy.Visible = true;
                    ctrlPeopleDataTable1.FilterByAnything("FirstName", txtFilterBy.Text);
                    break;
                case 4:
                    txtFilterBy.Visible = true;
                    ctrlPeopleDataTable1.FilterByAnything("SecondName", txtFilterBy.Text);
                    break;
                case 5:
                    txtFilterBy.Visible = true;
                    ctrlPeopleDataTable1.FilterByAnything("ThirdName", txtFilterBy.Text);
                    break;
                case 6:
                    txtFilterBy.Visible = true;
                    ctrlPeopleDataTable1.FilterByAnything("LastName", txtFilterBy.Text);
                    break;
                case 7:
                    txtFilterBy.Visible = true;
                    ctrlPeopleDataTable1.FilterByAnything("Nationality", txtFilterBy.Text);
                    break;
                case 8:
                    txtFilterBy.Visible = true;
                    ctrlPeopleDataTable1.FilterByAnything("Gendor", txtFilterBy.Text);
                    break;
                case 9:
                    txtFilterBy.Visible = true;
                    ctrlPeopleDataTable1.FilterByAnything("Phone", txtFilterBy.Text);
                    break;
                case 10:
                    txtFilterBy.Visible = true;
                    ctrlPeopleDataTable1.FilterByAnything("Email", txtFilterBy.Text);
                    break;
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            drdFilterBy_SelectedIndexChanged(sender, e);
        }
    }
}
