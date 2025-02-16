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

namespace DVLD_Project.Test_Types
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
            LoadTestTypes();
        }

        public void LoadTestTypes()
        {
            bunifuDataGridView1.DataSource = clsTestTypes.GetTestTypes();
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

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string title = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string description = bunifuDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            double fees = double.Parse(bunifuDataGridView1.SelectedRows[0].Cells[3].Value.ToString());

            frmEditTestType frm = new frmEditTestType(id, title, description, fees);
            frm.ShowDialog();
            LoadTestTypes();
        }

        private void bunifuDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editTestTypeToolStripMenuItem_Click(sender, e);
        }
    }
}

