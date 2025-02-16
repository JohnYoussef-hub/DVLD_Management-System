using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Person.Controls
{
    public partial class frmPersonInfo : Form
    {
        public frmPersonInfo()
        {
            InitializeComponent();
        }

        public frmPersonInfo(int personID)
        {
            InitializeComponent();
            ctrlPersonInformation1.LoadPersonInformationByID(personID);
        }
    }
}
