using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace RestaurantP
{
    public partial class ReceptionistForm : Form
    {

        public ReceptionistForm(string firstname, string lastname, string id)
        {
            InitializeComponent();
            
            //Closing the connection
            Database.ConnectToDb();

            //Making the table layout panel for the orders invisible and not usable
            tlpMakeOrder.Visible = false;
            tlpMakeOrder.Enabled = false;

            this.WindowState = FormWindowState.Maximized;

            //Main layout panel controls
            lblInfo.Text = "Employee ID: " + id + " Name: " + firstname + " " + lastname;
            lblDate.Text = DateTime.Now.ToLongDateString();

            makingButtons();


            //Make order table layout panel controls
            lblInfo2.Text = "Employee ID: " + id + " Name: " + firstname + " " + lastname;
            lblOrderN.Text = "Order #: ";
            lblLine.Visible = false;
            lblItem.Visible = false;
            nudQuantity.Visible = false;
            nudQuantity.Enabled = false;
            btnDelete.Visible = false;
            btnDelete.Enabled = false;
            btnCheckOut.Enabled = false;

        }

        //Function to create buttons
        private void makingButtons()
        {
            //ListView in the main windown for receptionist
            SqlDataReader dr = Database.SearchCat();

            ArrayList list = new ArrayList();

            while (dr.Read())
            {
                list.Add(dr["CATEGORY"].ToString());
            }

            Database.ConnectToDb();


            //Making buttons for menu search
            Button button;
            int count = 0;

            foreach (string item in list)
            {
                button = new Button();
                button.Name = "btn" + item;
                button.Text = item;
                button.Top = count;
                button.Height = 27;
                button.Click += new EventHandler(OnClick);
                pnlButtons.Controls.Add(button);

                count += 27;
            }
        }


        private void OnClick(object sender, EventArgs e)
        {
            
            int height = 0;
            int count = 0;
            int total = 0;
            try
            {
                DataTable ds;
                Database.ConnectToDb();
                string search = sender.ToString().Substring(sender.ToString().Length - Math.Min(3, sender.ToString().Length));
                ds = Database.SearchCat(search);

                //Clearing datagridview before use
                dgvMenu.DataSource = null;
                //dgvMenu.Refresh();

                dgvMenu.DataSource = ds;

                //Styling of the datagridview
                dgvMenu.Font = new Font("serif", 15);

                height = dgvMenu.Size.Height;
                count = dgvMenu.Rows.Count;
                total = (height - dgvMenu.ColumnHeadersHeight - 2) / count;
                dgvMenu.RowTemplate.Height = total;
                //dgvMenu.AutoResizeColumns();
                dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }

            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Add code for registering the employee time out
            //
            //

            this.DialogResult = DialogResult.OK;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Action(sender);
        }

        private void btnVOrders_Click(object sender, EventArgs e)
        {

        }



        ///////////////////////////////////////////////////////////
        //Make an Order table layout panel options
        //////////////////////////////////////////////////////////

        private void btnBack_Click(object sender, EventArgs e)
        {
            Action(sender);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void Action(object sender)
        {
            if (sender.Equals(btnOrder))
            {
                tlpReceptionist.Visible = false;
                tlpReceptionist.Enabled = false;
                tlpMakeOrder.Visible = true;
                tlpMakeOrder.Enabled = true;
            }
            else if (sender.Equals(btnBack))
            {
                tlpReceptionist.Visible = true;
                tlpReceptionist.Enabled = true;
                tlpMakeOrder.Visible = false;
                tlpMakeOrder.Enabled = false;
            }
        }


    }
}
