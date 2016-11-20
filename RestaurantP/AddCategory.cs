using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantP
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
        }

        bool selected; //Setting variable to check if item from database was selected

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds;

            Database.ConnectToDb();
            ds = Database.SearchCategory();

            //Display results
            dgvCategory.DataSource = ds;
            dgvCategory.DataMember = ds.Tables["Category"].ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Database.ConnectToDb();
            lblFeedback.Text = Database.AddCategory(txtCategory.Text);

            selected = false; //Reseting selected variable

            txtCategory.Text = "";
            btnClear.Enabled = false;

            btnSearch.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selected = false; //After item is deleted, selected variable gets reseted
            txtCategory.Text = "";
            btnClear.Enabled = false;

            btnSearch.PerformClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = true;
            txtCategory.Text = dgvCategory.Rows[e.RowIndex].Cells["CATEGORY"].Value.ToString();
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;

            //Depending if selected is true or false the add or delete buttons get enable or disable
            if (selected == true)
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reseting every control and variable
            txtCategory.Text = "";
            lblFeedback.Text = "";
            selected = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
        }

    }
}
