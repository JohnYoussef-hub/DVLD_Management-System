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

namespace DVLD_Project.Application_Types
{
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
            LoadApplicationTypes();
        }

        public void LoadApplicationTypes()
        {
            bunifuDataGridView1.DataSource = clsApplicationTypes.GetApplicationTypes();
        }

        private void bunifuDataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblCount.Text = bunifuDataGridView1.Rows.Count.ToString();
        }

        private void bunifuDataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblCount.Text = bunifuDataGridView1.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string title = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            double fees = double.Parse(bunifuDataGridView1.SelectedRows[0].Cells[2].Value.ToString());


            frmEditApplicationType frm = new frmEditApplicationType(id, title, fees);
            frm.ShowDialog();
            LoadApplicationTypes();
        }

        private void bunifuDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editApplicationTypeToolStripMenuItem_Click(sender, e);
        }
    }
}
