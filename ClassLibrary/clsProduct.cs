﻿using System;
using System.Runtime.Remoting.Messaging;

namespace ClassLibrary
{
    public class clsProduct
    {
        //private data member for the product id
        private Int32 mProductID;
        //productID public property
        public Int32 ProductID
        {
            get
            {
                //return the private data, sends data out if the property
                return mProductID;
            }
            set
            {
                //set the private data. allows the value to be changed
                mProductID = value;
            }
        }


        private string mName;
        //public property for the product name
        public string Name
        {
            get
            {
                //return the private data, sends data out if the property
                return mName;
            }
            set
            {
                //set the private data. allows the value to be changed
                mName = value;
            }
        }

        //private data member for the in stock property
        private Boolean mInStock;
        //public property for the in stock
        public Boolean InStock
        {
            get
            {
                //return the private data, sends data out if the property
                return mInStock;
            }
            set
            {
                //set the private data. allows the value to be changed
                mInStock = value;
            }
        }
        //private data member for the product category property
        private string mCategory;
        //public property for the product category
        public string Category
        {
            get
            {
                //return the private data, sends data out if the property
                return mCategory;
            }
            set
            {
                //set the private data. allows the value to be changed
                mCategory = value;
            }
        }

        //private data member for the price property
        private decimal mPrice;
        //public property for the product price
        public decimal Price
        {
            get
            {
                //return the private data, sends data out if the property
                return mPrice;
            }
            set
            {
                //set the private data. allows the value to be changed
                mPrice = value;
            }
        }

        //private data member for the product size property
        private string mSize;
        //public property for the product size
        public string Size
        {
            get
            {
                //return the private data, sends data out if the property
                return mSize;
            }
            set
            {
                //set the private data. allows the value to be changed
                mSize = value;
            }
        }

        //private data member for the release date property
        private DateTime mReleasedDate;
        //public property for the release date
        public DateTime ReleasedDate
        {
            get
            {
                //return the private data, sends data out if the property
                return mReleasedDate;
            }
            set
            {
                //set the private data. allows the value to be changed
                mReleasedDate = value;
            }
        }


        /******************* FIND METHOD *********************/

        public bool Find(int productID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the product ID to search for
            DB.AddParameter("ProductID", productID);
            //execute the stored procedure 
            DB.Execute("sproc_tblProduct_FilterByProductID");
            //if one record is found 
            if (DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mCategory = Convert.ToString(DB.DataTable.Rows[0]["Category"]);
                mSize = Convert.ToString(DB.DataTable.Rows[0]["Size"]);
                mReleasedDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleasedDate"]);

                // Return that everything worked OK
                return true;
            }
            else
            {
                // No record was found
                return false;

            }
        }

        public string Valid(string name, string size, string category, string price, string releasedDate)
        {

            //create a string variable to store the error
            string Error = "";
            //temp variable to store date values
            DateTime DateTemp;

            //name validation
            if (string.IsNullOrWhiteSpace(name))
            {

                //record the error
                Error = Error + "The name may not be blank. ";
            }
            else if (name.Length > 50)
            {
                //record the error
                Error = Error + "The name must be less than 50 characters. ";
            }

            //if the size is blank
            if (string.IsNullOrWhiteSpace(size))
            {
                //record the error
                Error = Error + "The size may not be blank. ";
            }
            else if (size.Length > 50)
            {
                //record the error
                Error = Error + "The size must be less than 50 characters. ";
            }
            //if the category is blank
            if (string.IsNullOrWhiteSpace(category))
            {
                //record the error
                Error = Error + "The category may not be blank. ";
            }
            else if (category.Length > 50)
            {
                //record the error
                Error = Error + "The category must be less than 50 characters. ";
            }
            //if the price is blank
            if (string.IsNullOrWhiteSpace(price))
            {
                //record the error
                Error = Error + "The price may not be blank. ";
            }
            else
            {
                try
                {
                    decimal priceValue = Convert.ToDecimal(price);
                    if (priceValue < 0)
                    {
                        Error += "The price cannot be negative. ";
                    }
                    else if (priceValue > 10000)
                    {
                        Error += "The price must be less than or equal to 10000 : ";
                    }
                }
                catch
                {
                    Error += "The price was not a valid decimal : ";
                }
            }
            //if the released date is blank

            if (string.IsNullOrWhiteSpace(releasedDate))
            {
                Error += "The released date may not be blank : ";
            }
            else
            {
                try
                {
                    DateTemp = Convert.ToDateTime(releasedDate);

                    DateTime DateComp = DateTime.Now.Date;



                    if (DateTemp != DateComp)

                    {

                        Error += "Release date must be today’s date. ";

                    }

                }

                catch

                {

                    Error += "Release date must be a valid date. ";

                }

            }



            return Error;

        }

        public string DisplayInfo
        {
            get
            {
                return Name + " | " + Category + " | £" + Price;
            }
        }
    }
}
