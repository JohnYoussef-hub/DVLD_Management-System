﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.User
{
    public partial class frmUserInfo : Form
    {
        public frmUserInfo(int PersonID, int UserID)
        {
            InitializeComponent();
            ctrlPersonInformation1.LoadPersonInformationByID(PersonID);
            ctrlLoginInfo1.FillForm(UserID);
        }

        private void ctrlPersonInformation1_Load(object sender, EventArgs e)
        {

        }
    }
}
