using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD_Project.User.Controls
{
    public partial class ctrlLoginInfo : UserControl
    {
        public ctrlLoginInfo()
        {
            InitializeComponent();
        }

        public void FillForm(int UserID)
        {
            clsUser user = new clsUser();
            user = clsUser.GetUserByID(UserID);
            lblUserID.Text = user._userID.ToString();
            lblUserName.Text = user._userName;
            lblIsActive.Text = user._isActive.ToString();
        }
    }
}
