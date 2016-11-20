using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantP
{
    class Employee //Class to validate the employees information
    {
        //Private variables for employee
        private string iD;
        private string level;
        private string fname;
        private string lname;
        private string username;
        private string password;
        private string phone;

        public string Feedback = "";

        //Public variables to be validated first
        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Level
        {
            get { return level; }
            set { if (Validation.IsNumber(value) == true) { level = value; } else { Feedback += "Level must be a number. "; } }
        }

        public string FName
        {
            get { return fname; }
            set { if (Validation.IsFilledIn(value) == true) { fname = value; } else { Feedback += "First Name must be fill in. "; } }
        }

        public string LName
        {
            get { return lname; }
            set { if (Validation.IsFilledIn(value) == true) { lname = value; } else { Feedback += "Last Name must be fill in. "; } }
        }

        public string UserName
        {
            get { return username; }
            set { if (Validation.IsFilledIn(value) == true) { username = value; } else { Feedback += "Username must be fill in. "; } }
        }

        public string Password
        {
            get { return password; }
            set { if (Validation.IsFilledIn(value) == true) { password = value; } else { Feedback += "Password must be fill in. "; } }
        }

        public string Phone
        {
            get { return phone; }
            set { if (Validation.IsValidPhone(value) == true) { phone = value; } else { Feedback += "Phone format is XXX-XXX-XXXX. "; } }
        }
    }
}
