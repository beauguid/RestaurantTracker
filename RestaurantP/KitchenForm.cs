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
    public partial class KitchenForm : Form
    {
        public KitchenForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
