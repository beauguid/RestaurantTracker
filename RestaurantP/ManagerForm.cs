using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace RestaurantP
{
    public partial class ManagerForm : Form
    {
        public ManagerForm(string firstname, string lastname, string id)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            //Closing the connection
            Database.ConnectToDb();

            //Hidding the sub options to show the main menu
            tlpOptions.Visible = true;
            tlpOptions.Enabled = true;
            tlpMenuOptions.Visible = false;
            tlpMenuOptions.Enabled = false;
            tlpEmployeeOptions.Visible = false;
            tlpEmployeeOptions.Enabled = false;

            //Setting controls for menu options
            lblInfo.Text = "Employee ID: " + id + " Name: " + firstname + " " + lastname;
            lblDate.Text = DateTime.Now.ToLongDateString();

            //Setting controls for the menu
            lblInfoM.Text = "Employee ID: " + id + " Name: " + firstname + " " + lastname;
            lblDateM.Text = DateTime.Now.ToLongDateString();

            //Setting user information for employee menu
            lblInfo2.Text = "Employee ID: " + id + " Name: " + firstname + " " + lastname;

            
        }

        //Variable use to idenfity if the user input in the textboxes was selected from the database
        bool seleted = false;

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Manager information:\n"
                + "Menu Options - To modify menu list.\n"
                + "Employee Options - To add or delete employees.\n"
                + "Reports - To generate daily reports."
                );
        }


        ////////////////////////////////////////////////////////////
        //Function to determine what to do depending on the sender
        ////////////////////////////////////////////////////////////

        private void Action(object sender)
        {
            if (sender.Equals(btnMenu))
            {
                //Hidding other menus
                tlpOptions.Visible = false;
                tlpOptions.Enabled = false;
                //tlpEmployeeOptions.Visible = false;
                //tlpEmployeeOptions.Enabled = false;

                //Disabling buttons not allow to use until all field are fill in
                btnAddM.Enabled = false;
                btnUpdateM.Enabled = false;
                btnDeleteM.Enabled = false;
                btnClearM.Enabled = false;

                tlpMenuOptions.Visible = true;
                tlpMenuOptions.Enabled = true;

                //Filling category combo box
                cbType.Items.Add("Everything");
                cbType.Items.Add("Code");
                cbType.Items.Add("Name");
                cbType.Items.Add("Price");
                cbType.Items.Add("Price Small");
                cbType.Items.Add("Category");
                cbType.Items.Add("Spicy");
                cbType.SelectedIndex = 0;

                fillcategory();

                cbCriteria.Enabled = false;
                cbCriteria.Visible = false;
                
            }
            else if (sender.Equals(btnEmployee))
            {
                //Adding levels to the level combo box
                cbLevel.Items.Add("All");
                cbLevel.Items.Add("1");
                cbLevel.Items.Add("2");
                cbLevel.SelectedIndex = 0;

                //Hidding the main options to show the sub-options
                tlpOptions.Visible = false;
                tlpOptions.Enabled = false;

                //Unabling controls not allowed to use by the user yet
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = false;
                btnClear.Enabled = false;

                tlpEmployeeOptions.Visible = true;
                tlpEmployeeOptions.Enabled = true;

                
            }

        }


        ///////////////////////////////////////////////////////////////
        //Controls for the main table layout panel
        ///////////////////////////////////////////////////////////////
 
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Action(sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Action(sender);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
        }



        ///////////////////////////////////////////////////////////////////////////////////////////
        //Employee Sub Menu
        ///////////////////////////////////////////////////////////////////////////////////////////


        ///////////////////////////////////////////////////////////////
        //Controls for the table layout panel for the Employee Options
        /// ///////////////////////////////////////////////////////////

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Hidding the sub-options to show the main options
            tlpOptions.Visible = true; ;
            tlpOptions.Enabled = true;
            tlpEmployeeOptions.Visible = false;
            tlpEmployeeOptions.Enabled = false;

            //Clearing controls
            clearEntries();
            dgvEmployees.DataSource = null;
            dgvEmployees.Refresh();
            lblFeedback.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clearing everything but the data grid view
            clearEntries();
            lblFeedback.Text = "";
            btnAdd.Enabled = false;
            seleted = false;
            btnClear.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SubAction(sender);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SubAction(sender);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SubAction(sender);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SubAction(sender);
        }

        ////////////////////////////////////////////////////////////
        //Function to determine what to do depending on the sender (sub-menus)
        ////////////////////////////////////////////////////////////

        private void SubAction(object sender)
        {
            if (sender.Equals(btnAdd)) //Button ADD
            {
                //Creating an instance of employee class to validate the information
                Employee temp = new Employee();
                temp.ID = txtID.Text;
                temp.Level = txtLevel.Text;
                temp.FName = txtFName.Text;
                temp.LName = txtLName.Text;
                temp.UserName = txtUserName.Text;
                temp.Password = txtPassword.Text;
                temp.Phone = txtPhoneNumber.Text;

                //If everything went good with the employee information
                //Add the new employee to the database
                if (temp.Feedback == "")
                {
                    Database.ConnectToDb();
                    lblFeedback.Text = Database.AddEmployee(temp);
                }
                else //If something went wrong give feedback to the user
                {
                    lblFeedback.Text = "Error: " + temp.Feedback;
                }

            }
            else if (sender.Equals(btnDelete)) //Button DELETE
            {
                Database.ConnectToDb();
                lblFeedback.Text = Database.DeleteEmployee(txtID.Text);
                seleted = false;
            }
            else if (sender.Equals(btnUpdate)) //Button Update
            {
                //Creating an instance of employee class to validate the information
                Employee temp = new Employee();
                temp.ID = txtID.Text;
                temp.Level = txtLevel.Text;
                temp.FName = txtFName.Text;
                temp.LName = txtLName.Text;
                temp.UserName = txtUserName.Text;
                temp.Password = txtPassword.Text;
                temp.Phone = txtPhoneNumber.Text;

                if (temp.Feedback == "")
                {
                    Database.ConnectToDb();
                    lblFeedback.Text = Database.UpdateEmployee(temp);
                }
                else
                {
                    lblFeedback.Text = "Error: " + temp.Feedback;
                }

                seleted = false;

            }
            else if (sender.Equals(btnSearch))
            {
                //Setting varibles
                DataSet ds;

                //Running connection and query
                Database.ConnectToDb();

                ds = Database.SearchEmployees(cbLevel.SelectedItem.ToString());

                //Display results
                dgvEmployees.DataSource = ds;
                dgvEmployees.DataMember = ds.Tables["Employees"].ToString();

                //Reseting search controls
                cbLevel.SelectedIndex = 0;
            }

            if (lblFeedback.Text.Contains("Error") == false && sender.Equals(btnSearch) == false)
            {
                clearEntries();
                btnSearch.PerformClick();
            }
            
        }

        ////////////////////////////////////////////////////////////
        //Function to run when any textboxe content is changed
        ////////////////////////////////////////////////////////////

        private void onChange(object sender, EventArgs e)
        {
            btnClear.Enabled = true; //Enabling button as soon as any textbox receives any change

                if (txtLevel.Text != "" && txtFName.Text != "" && txtLName.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && txtPhoneNumber.Text != "")
                {
                    if (seleted == true) //If the user input in the textboxes was from the datasbase the buttons update and delete should be enable
                    {
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnAdd.Enabled = false;
                    }
                    else
                    {
                        btnAdd.Enabled = true;
                    }
                }
                else if (txtLevel.Text == "" && txtFName.Text == "" && txtLName.Text == "" && txtUserName.Text == "" && txtPassword.Text == "" && txtPhoneNumber.Text == "")
                {
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnAdd.Enabled = false;
                    btnClear.Enabled = false;

                    seleted = false;
                    txtID.Text = "";

                }
                else
                {
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnAdd.Enabled = false;
                    btnClear.Enabled = true;
                }

        }

        ////////////////////////////////////////////////////////////
        //Function to run when the employee list has been modified
        ////////////////////////////////////////////////////////////

        private void clearEntries()
        {
            txtID.Text = "";
            txtLevel.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtPhoneNumber.Text = "";

            cbLevel.SelectedIndex = 0;
        }

        //On any cell double click, the employee information will be pass to a textboxes
        private void dgvEmployees_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleted = true;
            txtID.Text = dgvEmployees.Rows[e.RowIndex].Cells["Employee_ID"].Value.ToString();
            txtLevel.Text = dgvEmployees.Rows[e.RowIndex].Cells["E_Level"].Value.ToString();
            txtFName.Text = dgvEmployees.Rows[e.RowIndex].Cells["E_FName"].Value.ToString();
            txtLName.Text = dgvEmployees.Rows[e.RowIndex].Cells["E_LName"].Value.ToString();
            txtUserName.Text = dgvEmployees.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            txtPassword.Text = dgvEmployees.Rows[e.RowIndex].Cells["Pword"].Value.ToString();
            txtPhoneNumber.Text = dgvEmployees.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
        }


        ////////////////////////////////////////////////////////////
        //Menu Options
        ////////////////////////////////////////////////////////////

        //Function to fill category-related combo boxes
        private void fillcategory()
        {
            cbCriteria.Items.Clear();
            cbCategory.Items.Clear();

            SqlDataReader dr = Database.categorySearch();

            while (dr.Read())
            {
                cbCriteria.Items.Add(dr["category"].ToString()); //Adding it to the search combo box
                cbCategory.Items.Add(dr["category"].ToString()); //Adding it to the adding new food combo box
            }

            Database.ConnectToDb();
        }

        //Function to clear and reset everything
        private void ClearM()
        { 
            //Reseting textboxes
            txtINumber.Text = "";
            txtCode.Text = "";
            txtIName.Text = "";
            txtPrice.Text = "";
            txtPSmall.Text = "";
            cbCategory.SelectedIndex = -1;
            txtDescription.Text = "";
            ckbSpicy.Checked = false;

            //Reseting buttons
            btnAddM.Enabled = false;
            btnUpdateM.Enabled = false;
            btnDeleteM.Enabled = false;

            seleted = false;
        }

        private void btnBackM_Click(object sender, EventArgs e)
        {
            //Reseting data grid view
            dgvMenu.DataSource = null;
            dgvMenu.Refresh();

            ClearM();

            tlpMenuOptions.Enabled = false;
            tlpMenuOptions.Visible = false;
            tlpOptions.Visible = true;
            tlpOptions.Enabled = true;
        }

        private void onChangeM(object sender, EventArgs e)
        {
           btnClearM.Enabled = true; //Enabling button as soon as any textbox receives any change

               if (txtCode.Text != "" && txtIName.Text != "" && txtPrice.Text != "" && txtPSmall.Text != "" && cbCategory.Text != "" && txtDescription.Text != "")
               {
                   if (seleted == true) //If the user input in the textboxes was from the datasbase the buttons update and delete should be enable
                   {
                       btnUpdateM.Enabled = true;
                       btnDeleteM.Enabled = true;
                       btnAddM.Enabled = false;
                   }
                   else
                   {
                       btnAddM.Enabled = true;
                   }
               }
               else if (txtCode.Text == "" && txtIName.Text == "" && txtPrice.Text == "" && txtPSmall.Text == "" && cbCategory.Text == "" && txtDescription.Text == "" && ckbSpicy.Checked == false)
               {
                   seleted = false;
                   btnClearM.Enabled = false;
                   txtINumber.Text = "";
               }
               else
               {
                   btnUpdateM.Enabled = false;
                   btnDeleteM.Enabled = false;
                   btnAddM.Enabled = false;
                   btnClearM.Enabled = true;
               }
        }

        private void dgvMenu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleted = true;

            txtINumber.Text = dgvMenu.Rows[e.RowIndex].Cells["ITEM_NUM"].Value.ToString();
            txtCode.Text = dgvMenu.Rows[e.RowIndex].Cells["CODE"].Value.ToString();
            txtIName.Text = dgvMenu.Rows[e.RowIndex].Cells["ITEM_NAME"].Value.ToString();
            txtPrice.Text = dgvMenu.Rows[e.RowIndex].Cells["PRICE"].Value.ToString();
            txtPSmall.Text = dgvMenu.Rows[e.RowIndex].Cells["PRICE_SMALL"].Value.ToString();
            cbCategory.SelectedItem = dgvMenu.Rows[e.RowIndex].Cells["CATEGORY"].Value.ToString();
            txtDescription.Text = dgvMenu.Rows[e.RowIndex].Cells["DESCRIPTION"].Value.ToString();

            if (dgvMenu.Rows[e.RowIndex].Cells["SPICY"].Value.ToString() == "T")
            {
                ckbSpicy.Checked = true;
            }
            else
            {
                ckbSpicy.Checked = false;
            }
        }

        private void btnClearM_Click(object sender, EventArgs e)
        {
            ClearM();
        }

        //Variables used for search
        string type = "";
        string criteria = "";

        /////////////////////
        //Type of Searches
        ////////////////////
        private void btnSearchM_Click(object sender, EventArgs e)
        {
            //Setting varibles
            DataSet ds;

            //Depending on the selection the type of search is set to the name in the table
            switch (cbType.SelectedItem.ToString())
            { 
                case "Code":
                    type = "CODE";
                    break;
                case "Name":
                    type = "ITEM_NAME";
                    break;
                case "Price":
                    type = "PRICE";
                    break;
                case "Price Small":
                    type = "PRICE_SMALL";
                    break;
                case "Category":
                    type = "CATEGORY";
                    break;
                case "Spicy":
                    type = "SPICY";
                    break;
                default:
                    type = "Everything";
                    break;
            }

            //Depending on the enabled control, criteria is to be set
            if (txtCriteria.Enabled == true)
                criteria = txtCriteria.Text;
            else if (txtCriteria.Enabled == false && cbCriteria.Enabled == true)
                criteria = cbCriteria.Text.ToString();
            else
                criteria = "";


            //Running connection and query
            Database.ConnectToDb();
            ds = Database.SearchMenu(type, criteria);

            //Display results
            dgvMenu.DataSource = ds;
            dgvMenu.DataMember = ds.Tables["Menu"].ToString();

            //Everything gets reseted
            cbType.SelectedIndex = 0;
            txtCriteria.Text = "";
            txtCriteria.Visible = true;
            txtCriteria.Enabled = false;
            cbCriteria.SelectedIndex = -1;
            cbCriteria.Enabled = false;
            cbCriteria.Visible = false;
        }

        
        //Deleting food from menu
        private void btnDeleteM_Click(object sender, EventArgs e)
        {
            btnSearchM.PerformClick();
            ClearM();
        }

        //Updatng Menu
        private void btnUpdateM_Click(object sender, EventArgs e)
        {
            Food nFood = new Food();
            nFood.Item_Number = txtINumber.Text;
            nFood.Code = txtCode.Text;
            nFood.Item_Name = txtIName.Text;
            nFood.Price = txtPrice.Text;
            nFood.Price_Small = txtPSmall.Text;
            nFood.Category = cbCategory.SelectedItem.ToString();
            nFood.Description = txtDescription.Text;

            if (ckbSpicy.Checked == true)
                nFood.Spicy = 'T';
            else
                nFood.Spicy = 'F';

            if (nFood.Feedback != "")
            {
                lblFeedbackM.Text = "Error: " + nFood.Feedback;
            }
            else
            {
                Database.ConnectToDb();
                Database.UpdateMenu(nFood);
                lblFeedbackM.Text = Database.Feedback;
            }

            btnSearchM.PerformClick();
            ClearM();
        }

        private void cbType_TextChanged(object sender, EventArgs e)
        {
            txtCriteria.Text = "";

            if (cbType.Text == "Everything")
            {
                txtCriteria.Enabled = false;
            }
            else if (cbType.Text == "Category")
            {
                txtCriteria.Enabled = false;
                txtCriteria.Visible = false;

                cbCriteria.Visible = true;
                cbCriteria.Enabled = true;
            }
            else
            {
                txtCriteria.Enabled = true;
                txtCriteria.Visible = true;

                cbCriteria.Visible = false;
                cbCriteria.Enabled = false;
            }
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            AddCategory cat = new AddCategory();
            cat.ShowDialog();

            fillcategory();
        }

        //Adding to menu
        private void btnAddM_Click_1(object sender, EventArgs e)
        {
            Food nFood = new Food();
            nFood.Code = txtCode.Text;
            nFood.Item_Name = txtIName.Text;
            nFood.Price = txtPrice.Text;
            nFood.Price_Small = txtPSmall.Text;
            nFood.Category = cbCategory.SelectedItem.ToString();
            nFood.Description = txtDescription.Text;

            if (ckbSpicy.Checked == true)
                nFood.Spicy = 'T';
            else
                nFood.Spicy = 'F';

            if (nFood.Feedback != "")
            {
                lblFeedbackM.Text = "Error: " + nFood.Feedback;
            }
            else
            {
                Database.ConnectToDb();
                Database.AddMenu(nFood);
            }

            btnSearchM.PerformClick();
            ClearM();
        }



    }

}

