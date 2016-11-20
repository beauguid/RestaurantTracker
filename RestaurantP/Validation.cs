using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RestaurantP
{
    class Validation
    {
        /////////////////////////////////////////////
        //Functions to validate person's information
        /////////////////////////////////////////////
        public static bool IsFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0 && temp != " ")
            {
                result = true;
            }

            return result;
        }

        public static bool IsNumber(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                try { double number = Convert.ToDouble(temp); result = true; }
                catch (Exception) {  }
            }

            return result;
        }


        public static bool IsValidPhone(string phone)
        {
            bool result = false;
            string pattern = @"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$";

            Regex regex = new Regex(pattern);

            if (regex.IsMatch(phone))
            {
                result = true;
            }

            return result;
        }


        /////////////////////////////////////////////
        //Functions to validate person's information
        /////////////////////////////////////////////

        //Function to validate code and category
        public static bool isValidC(string code)
        {
            bool result = false;

            if (code.Length > 0 && code.Length < 5)
            {
                result = true;
            }

            return result;
        }

    }
}
