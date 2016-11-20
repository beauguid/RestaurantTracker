using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace RestaurantP
{
    class Database
    {
        //Creating the varibles to connect to the DB and to give feedback
        public static string Feedback;
        public static SqlConnection conn = new SqlConnection();
        static string strConn;

        //Function to connect to the Database
        public static string ConnectToDb()
        {
            Feedback = "";

            strConn = "Server=sql.neit.edu;Database=DataBayce;User Id=DataBayce   ; Password=!Ace 2016!;";

            //Closing or Opening the connection depending on the state of it
            try
            {
                if (conn.State.ToString().Equals("Open"))
                {
                    conn.Close();
                }
                else
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                Feedback = "Error: " + e.Message; //Setting the feedback variable as the exception message
            }

            return Feedback;
        }


        //Function to get employee information to verify credentials
        public static SqlDataReader RunEmployeeSearch()
        {
            Feedback = "";

            string strSQL = "SELECT Employee_ID, E_Level, UserName, Pword, E_FName, E_LName, Phone FROM Employees;";

            //Setting the command connection and the sql statement
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = strSQL;

            //Running the command and returning the results
            SqlDataReader runsearch = null;

            try
            {
                ConnectToDb();
                runsearch = comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Feedback = e.Message;
            }

            return runsearch;
        }

        //Function to search for all the employees by level
        public static DataSet SearchEmployees(string level)
        {
            //Setting variables
            Feedback = "";
            string strSql;
            DataSet ds = new DataSet();
            SqlCommand comm = new SqlCommand();

            if (level.Equals("All")) //If level was choose from the combo box a different query will be executed
            {
                strSql = "SELECT Employee_ID, E_Level, UserName, Pword, E_FName, E_LName, Phone FROM Employees WHERE 0 = 0";
            }
            else
            {
                strSql = "SELECT Employee_ID, E_Level, UserName, Pword, E_FName, E_LName, Phone FROM Employees WHERE 0 = 0"
                    + " AND E_Level LIKE @level;";

                comm.Parameters.AddWithValue("@level", "%" + level + "%");
            }
                try
                {
                    //Setting command query and connection
                    comm.CommandText = strSql;
                    comm.Connection = conn;

                    //Creating adapter for the data
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = comm;
                    da.Fill(ds, "Employees");
                }
                catch (Exception e)
                {
                    Feedback = "Error: " + e.Message;
                }

                //Clossing the connection
                ConnectToDb();

            //Returning Data
            return ds;
        }

        
        ///////////////////////////////////////////////////////////
        //Employee Menu Functions
        ///////////////////////////////////////////////////////////

        //Function to add employees
        public static string AddEmployee(Employee temp)
        {
            Feedback = "";

            //Setting command variables
            string strSql = "INSERT INTO Employees (E_Level, UserName, Pword, E_FName, E_LName, Phone) VALUES (@Level, @UserName, @Pword, @FName, @LName, @Phone);";
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSql;
            comm.Connection = conn;

            //Filling the variables of the command
            comm.Parameters.AddWithValue("@Level", temp.Level);
            comm.Parameters.AddWithValue("@UserName", temp.UserName);
            comm.Parameters.AddWithValue("@Pword", temp.Password);
            comm.Parameters.AddWithValue("@FName", temp.FName);
            comm.Parameters.AddWithValue("@LName", temp.LName);
            comm.Parameters.AddWithValue("@Phone", temp.Phone);

            //Running command
            try
            {
                Feedback = comm.ExecuteNonQuery().ToString() + " Employee Added.";
            }
            catch (Exception e)
            {
                Feedback += "Error: " + e.Message;
            }

            //Closing the connection and returning feedback
            conn.Close();
            return Feedback;
        }

        //Function to update employees information
        public static string UpdateEmployee(Employee temp)
        {
            Feedback = "";

            //Setting command variables
            string strSql = "UPDATE Employees SET E_Level = @Level, UserName = @UserName, Pword = @Pword, E_FName = @FName, E_LName = @LName, Phone = @Phone WHERE Employee_ID = @ID;";
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSql;
            comm.Connection = conn;

            //Filling the variables of the command
            comm.Parameters.AddWithValue("@Level", temp.Level);
            comm.Parameters.AddWithValue("@UserName", temp.UserName);
            comm.Parameters.AddWithValue("@Pword", temp.Password);
            comm.Parameters.AddWithValue("@FName", temp.FName);
            comm.Parameters.AddWithValue("@LName", temp.LName);
            comm.Parameters.AddWithValue("@Phone", temp.Phone);
            comm.Parameters.AddWithValue("@ID", temp.ID);

            //Running command
            try
            {
                Feedback = comm.ExecuteNonQuery().ToString() + " Employee Updated.";
            }
            catch (Exception e)
            {
                Feedback += "Error: " + e.Message;
            }

            //Closing the connection and returning feedback
            conn.Close();
            return Feedback;
        }


        //Function to delete employees
        public static string DeleteEmployee(string ID)
        {
            Feedback = "";

            //Setting command variables
            string strSql = "DELETE FROM Employees WHERE Employee_ID = @ID;";
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSql;
            comm.Connection = conn;

            comm.Parameters.AddWithValue("@ID", ID);

            //Running command
            try
            {
                Feedback = comm.ExecuteNonQuery().ToString() + " Employee Deleted.";
            }
            catch (Exception e)
            {
                Feedback += "Error: " + e.Message;
            }

            //Closing the connection and returning feedback
            conn.Close();
            return Feedback;
        }


        ///////////////////////////////////////////////////////////
        //Settings Menu Functions
        ///////////////////////////////////////////////////////////

        //Function to search for categories options
        public static SqlDataReader categorySearch()
        {
            Feedback = "";

            string strSQL = "SELECT CATEGORY_ID, CATEGORY FROM Category;";

            //Setting the command connection and the sql statement
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = strSQL;

            //Running the command and returning the results
            SqlDataReader runsearch = null;

            try
            {
                ConnectToDb();
                runsearch = comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Feedback = e.Message;
            }

            return runsearch;
        }

        public static DataSet SearchCategory()
        {
            Feedback = "";

            string strSQL = "SELECT CATEGORY_ID, CATEGORY FROM Category";

            //Setting the command connection and the sql statement
            SqlCommand comm = new SqlCommand();

            //Running the command and returning the results
            DataSet ds = new DataSet();

            try
            {
                comm.Connection = conn;
                comm.CommandText = strSQL;

                //Creating adapter for the data
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comm;
                da.Fill(ds, "Category");
            }
            catch (Exception e)
            {
                Feedback = e.Message;
            }

            ConnectToDb();

            return ds;
        }

        public static string AddCategory(string cat)
        {
            Feedback = "";

            string strSQL = "INSERT INTO Category (CATEGORY) VALUES (@category)";

            //Setting the command connection and the sql statement
            SqlCommand comm = new SqlCommand();

            comm.Connection = conn;
            comm.CommandText = strSQL;

            comm.Parameters.AddWithValue("@category", cat);

            //Running the command and returning the results
            DataSet ds = new DataSet();

            try
            {
                Feedback = comm.ExecuteNonQuery() + " Category Added.";
            }
            catch (Exception e)
            {
                Feedback = e.Message;
            }

            conn.Close();

            return Feedback;
        }

        //Function to search for all the messages by date and type of platform
        public static DataSet SearchMenu(string type, string criteria)
        {
            //Setting variables
            Feedback = "";
            string strSql = "SELECT ITEM_NUM, CODE, ITEM_NAME, PRICE, PRICE_SMALL, CATEGORY, DESCRIPTION, SPICY FROM Menu WHERE 0 = 0";
            DataSet ds = new DataSet();
            SqlCommand comm = new SqlCommand();

            //Depending on the button, the search
            if (type != "Everything")
            {
                if (criteria == "")
                {
                    strSql += " ORDER BY " + type;
                }
                else
                {
                    strSql += " AND " + type + "  LIKE @criteria";
                    comm.Parameters.AddWithValue("@criteria", "%" + criteria + "%");
                }

            }
            else
            {
                strSql = "SELECT ITEM_NUM, CODE, ITEM_NAME, PRICE, PRICE_SMALL, CATEGORY, DESCRIPTION, SPICY FROM Menu WHERE 0 = 0";
            }


            try
            {
                //Setting command query and connection
                comm.CommandText = strSql;
                comm.Connection = conn;

                //Creating adapter for the data
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comm;
                da.Fill(ds, "Menu");
            }
            catch (Exception e)
            {
                Feedback = "Error: " + e.Message;
            }

            //Clossing the connection
            ConnectToDb();

            //Returning Data
            return ds;
        }

        public static string AddMenu(Food temp)
        {
            Feedback = "";

            //Setting command variables
            string strSql = "INSERT INTO Menu (CODE, ITEM_NAME, PRICE, PRICE_SMALL, CATEGORY, DESCRIPTION, SPICY) VALUES (@code, @item_name, @price, @price_small, @category, @description, @spicy);";
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSql;
            comm.Connection = conn;

            //Filling the variables of the command
            comm.Parameters.AddWithValue("@code", temp.Code);
            comm.Parameters.AddWithValue("@item_name", temp.Item_Name);
            comm.Parameters.AddWithValue("@price", temp.Price);
            comm.Parameters.AddWithValue("@price_small", temp.Price_Small);
            comm.Parameters.AddWithValue("@category", temp.Category);
            comm.Parameters.AddWithValue("@description", temp.Description);
            comm.Parameters.AddWithValue("@spicy", temp.Spicy);

            //Running command
            try
            {
                Feedback = comm.ExecuteNonQuery().ToString() + " Food Added.";
            }
            catch (Exception e)
            {
                Feedback += "Error: " + e.Message;
            }

            //Closing the connection and returning feedback
            conn.Close();
            return Feedback;
        }

        public static string UpdateMenu(Food temp)
        {
            Feedback = "";

            //Setting command variables
            string strSql = "UPDATE Menu SET CODE = @code, ITEM_NAME = @item_name, PRICE = @price,  PRICE_SMALL = @price_small, CATEGORY = @category, DESCRIPTION = @description, SPICY = @spicy WHERE ITEM_NUM = @id";
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSql;
            comm.Connection = conn;

            //Filling the variables of the command
            comm.Parameters.AddWithValue("@code", temp.Code);
            comm.Parameters.AddWithValue("@item_name", temp.Item_Name);
            comm.Parameters.AddWithValue("@price", temp.Price);
            comm.Parameters.AddWithValue("@price_small", temp.Price_Small);
            comm.Parameters.AddWithValue("@category", temp.Category);
            comm.Parameters.AddWithValue("@description", temp.Description);
            comm.Parameters.AddWithValue("@spicy", temp.Spicy);
            comm.Parameters.AddWithValue("@id", temp.Item_Number);

            //Running command
            try
            {
                Feedback = comm.ExecuteNonQuery().ToString() + " Food Updated.";
            }
            catch (Exception e)
            {
                Feedback += "Error: " + e.Message;
            }

            //Closing the connection and returning feedback
            conn.Close();
            return Feedback;
        }
    

    ///////////////////////////////////////////////////////////
    //Functions for the receptionist menu
    ///////////////////////////////////////////////////////////

    public static SqlDataReader SearchCat()
        {
            Feedback = "";

            string strSQL = "SELECT CATEGORY FROM Menu GROUP BY CATEGORY;";

            //Setting the command connection and the sql statement
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = strSQL;

            //Running the command and returning the results
            SqlDataReader runsearch = null;

            try
            {
                ConnectToDb();
                runsearch = comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Feedback = e.Message;
                MessageBox.Show(e.Message);
            }

            return runsearch;
        }

    //public static DataSet SearchCat(string cat)
    //{
    //    Feedback = "";

    //    string strSQL = "SELECT ITEM_NAME, PRICE, PRICE_SMALL,SPICY FROM Menu WHERE CATEGORY = @cat;";

    //    //Setting the command connection and the sql statement
    //    SqlCommand comm = new SqlCommand();
    //    comm.Connection = conn;
    //    comm.CommandText = strSQL;

    //    comm.Parameters.AddWithValue("@cat", cat);

    //    //Running the command and returning the results
    //    DataSet ds = null;

    //    try
    //    {
    //        //Creating adapter for the data
    //        SqlDataAdapter da = new SqlDataAdapter();
    //        da.SelectCommand = comm;
    //        da.Fill(ds, "Menu");
    //    }
    //    catch (Exception e)
    //    {
    //        Feedback = "Error: " + e.Message;
    //    }

    //    //Clossing the connection
    //    ConnectToDb();

    //    return ds;
    //}



    public static DataTable SearchCat(string cat)
    {
        Feedback = "";

        string strSQL = "SELECT ITEM_NAME, PRICE, PRICE_SMALL FROM Menu WHERE CATEGORY = @cat;";

        //Setting the command connection and the sql statement
        SqlCommand comm = new SqlCommand();
        comm.Connection = conn;
        comm.CommandText = strSQL;

        comm.Parameters.AddWithValue("@cat", cat);

        //Running the command and returning the results
        DataTable table = new DataTable();

        try
        {
            //Creating adapter for the data
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;
            da.Fill(table);
        }
        catch (Exception e)
        {
            Feedback = "Error: " + e.Message;
        }

        //Clossing the connection
        ConnectToDb();

        return table;
    }
  }

}

