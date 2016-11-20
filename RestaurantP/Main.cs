using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestaurantP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        //Variable use to identify which option was selected
        int selected = 0;


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            //Windows form in full screen
            this.WindowState = FormWindowState.Maximized;

            //Calling function to disable login options
            Action(sender);
        }



        private void btnKitchen_Click(object sender, EventArgs e)
        {
            //Kitchen dialog is created and this form gets hidden
            KitchenForm kitchen = new KitchenForm();
            kitchen.ShowDialog();
            this.Hide();

            //If kitchen dialog closed OK, this form will show
            //If the user close the form at the "x" the main form will still show
            if (kitchen.DialogResult == DialogResult.OK || kitchen.DialogResult == DialogResult.Cancel)
            {
                this.Show();
                this.Focus();
            }

        }



        //btnAction() and onLoadControls() are functions to determine the action depending on the sender
        private void btnRecepcionist_Click(object sender, EventArgs e)
        {
            Action(sender);
            selected = 1; // selected is set to 1 to specify that receptionist option was selected
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            Action(sender);
            selected = 2; // selected is set to 2 to specify that manager option was selected
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Action(sender);

            //Clearing the textboxes
            txtUser.Text = "";
            txtPass.Text = "";
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool access = false; //Variable use to check if access was granted
            MessageBox.Show(Database.conn.State.ToString());
            //Setting a Data reader to read the database info used to compare credentials
            SqlDataReader dr = Database.RunEmployeeSearch();

            while (dr.Read()) //Reading date while there is any
            {
                if (txtUser.Text == dr["UserName"].ToString() && txtPass.Text == dr["Pword"].ToString())
                {
                    switch (selected)
                    {
                        case 1:
                            access = true;

                            //Clearing the entries
                            txtUser.Text = "";
                            txtPass.Text = "";

                            //Running new receptionist dialog
                            ReceptionistForm RF = new ReceptionistForm(dr["E_FName"].ToString(), dr["E_LName"].ToString(), dr["Employee_ID"].ToString());

                            RF.ShowDialog();
                            this.Hide();

                            if (RF.DialogResult == DialogResult.OK || RF.DialogResult == DialogResult.Cancel)
                            {
                                this.Show();
                                this.BringToFront();
                                this.Focus();
                            }
                            break;
                        case 2:
                            if (dr["E_Level"].ToString() == "1")
                            {                    
                                access = true;

                                //Clearing the entries
                                txtUser.Text = "";
                                txtPass.Text = "";

                                //Running new manager dialog
                                ManagerForm MF = new ManagerForm(dr["E_FName"].ToString(), dr["E_LName"].ToString(), dr["Employee_ID"].ToString());

                                MF.ShowDialog();
                                this.Hide();


                                if (MF.DialogResult == DialogResult.OK || MF.DialogResult == DialogResult.Cancel)
                                {
                                    this.Show();
                                    this.BringToFront();
                                    this.Focus();
                                }
                            }
                            break;
                    }
                }
                //If access is true, the reading of the data will stop
                if (access == true)
                    break;
                
            }

            //If access is not granted at the end user feedback is given
            if (access == false)
            {
                MessageBox.Show("Wrong username or password.");
                Database.ConnectToDb();
            }
                

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (pnlOptions.Visible == true) //Message box to display help if the main menu is visible
            {
                MessageBox.Show(this, "Kitchen Button: Shows the kitchen display with orders.\n"
                    + "Receptionist Button: Shows the receptionist menu with take-order options.\n"
                    + "Manager Button: Only manager accesible. Shows manager options menu.", "Menu Options Help");
            }
            else //Message box to display help if the login menu is visible
            {
                MessageBox.Show(this, "Manager and Receptionist can access the receptionist menu.\n"
                    + "Manager is the only one allowed to access the manager menu.\n", "Login Help");
            }
        }


        private void Action(object s)
        {
            //Depending on the sender the panel with the initial control is shown or not
            //Making visible/invisible and enabling/disabling login options depending on sender
            if (s.Equals(btnRecepcionist))
            {
                pnlOptions.Visible = false;
                pnlOptions.Enabled = false;
                pnlLogin.Visible = true;
                pnlLogin.Enabled = true;
            }
            else if (s.Equals(btnManager))
            {
                pnlOptions.Visible = false;
                pnlOptions.Enabled = false;
                pnlLogin.Visible = true;
                pnlLogin.Enabled = true;
            }
            else
            {
                pnlOptions.Visible = true;
                pnlOptions.Enabled = true;
                pnlLogin.Visible = false;
                pnlLogin.Enabled = false;
            }
        }





    }
}
