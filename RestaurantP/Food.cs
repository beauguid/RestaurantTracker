using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantP
{
    class Food
    {
        private string item_number;
        private string code;
        private string item_name;
        private string price;
        private string price_small;
        private string category;
        private string description;
        private char spicy;

        public string Feedback = "";

        public string Item_Number
        {
            get { return item_number; }
            set { item_number = value; }
        }

        public string Code
        {
            get { return code; }
            set { if (Validation.isValidC(value)) { code = value; } else { Feedback += "Invalid Code. "; } }
        }

        public string Item_Name
        {
            get { return item_name; }
            set { if (Validation.IsFilledIn(value)) { item_name = value; } else { Feedback += "Invalid Item Name."; } }
        }

        public string Price
        {
            get { return price; }
            set { if (Validation.IsNumber(value)) { price = value; } else { Feedback += "Invalid Price."; } }
        }

        public string Price_Small
        {
            get { return price_small; }
            set { if (Validation.IsNumber(value)) { price_small = value; } else { Feedback += "Invalid Price Small."; } }
        }

        public string Category
        {
            get { return category; }
            set { if (Validation.isValidC(value)) { category = value; } else { Feedback += "Invalid Category."; } }
        }

        public string Description
        {
            get { return description; }
            set { if (Validation.IsFilledIn(value)) { description = value; } else { Feedback += "Invalid Description."; } }
        }

        public char Spicy
        {
            get { return spicy; }
            set { spicy = value; }
        }
    }
}
