using DVLD_Project.Person.Controls;
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
    public partial class frmAddNewPerson : Form
    {

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void frmManageApplications_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmManageApplications_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void frmManageApplications_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }




        public delegate void AddPersonHandler(int PersonID);
        public event AddPersonHandler AddPerson;

        public frmAddNewPerson()
        {
            InitializeComponent();
        }

        public frmAddNewPerson(int PersonID)
        {
            InitializeComponent();
            ctrlAddPerson1.FillForm(PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(int.TryParse(ctrlAddPerson1.LblPersonID.Text, out int PersonID))
            {
                AddPerson?.Invoke(PersonID);
            }
            this.Close();
        }
    }
}
