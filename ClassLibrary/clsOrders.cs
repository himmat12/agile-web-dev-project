using System;
using System.Collections.Generic;
using System.Web;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for the order ID property
        private Int32 mOrderID;
        private DateTime mOrderDate;
        private string mOrderStatus;
        private Boolean mOrderPaid;
        private float mOrderTotalPrice;
        private int mCustomerID;
        private int mStaffID;

        public Int32 OrderID 
        {
            get
            {
                return mOrderID; //sends data out of the property
            }
            set
            {
                mOrderID = value; //allows data into property
            }
        }

        public DateTime OrderDate 
        {
            get
            {
                return mOrderDate; //sends data out of the property
            }
            set
            {
                mOrderDate = value; //allows data into property
            }
        }
        public string OrderStatus 
        {
            get
            {
                return mOrderStatus; //sends data out of the property
            }
            set
            {
                mOrderStatus = value; //allows data into property
            }
        }
        public bool OrderPaid 
        {
            get
            {
                return mOrderPaid; //sends data out of the property
            }
            set
            {
                mOrderPaid = value; //allows data into property
            }
        }
        public float OrderTotalPrice 
        {
            get
            {
                return mOrderTotalPrice; //sends data out of the property
            }
            set
            {
                mOrderTotalPrice = value; //allows data into property
            }
        }
        public int CustomerID 
        {
            get
            {
                return mCustomerID; //sends data out of the property
            }
            set
            {
                mCustomerID = value; //allows data into property
            }
        }
        public int StaffID 
        {
            get
            {
                return mStaffID; //sends data out of the property
            }
            set
            {
                mStaffID = value; //allows data into property
            }
        }

        /****** FIND METHOD ******/
        public bool Find(int orderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for
            DB.AddParameter("@orderID", orderID);
            //execute stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderID");
            //if one record is found (should be 1 or 0)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["orderID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["placementDate"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["orderStatus"]);
                mOrderPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["isPaid"]);
                mOrderTotalPrice = (float)Convert.ToDouble(DB.DataTable.Rows[0]["totalPrice"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["customerID"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["staffID"]);
                return true;
            }
            //no record found
            else
            {
                //indicates there is a problem
                return false;
            }
        }
        /****** VALID METHOD ******/
        public string Valid(string orderStatus, string orderDate, string orderTotalPrice)  //could add foreign keys
        { 
            String Error = "";
            //make temp variable for date
            DateTime DateTemp;
            try
            {
                //orderDate value copied to DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);

                /** ORDERSTATUS **/
                if (orderStatus.Length == 0)
                {
                    Error += "Order Status cannot be blank : ";
                }
                if (orderStatus.Length > 20)
                {
                    Error += "Order Status must have less than 20 characters: ";
                }
                if (orderStatus == "--please select--")
                {
                    Error += "Select an order status : ";
                }

                /** DATE **/
                //if we cannot have past dates we cannot see past orders. so changed to be only future
                if (DateTemp > DateTime.Now.Date)
                {
                    Error += "The order date cannot be in the future : ";
                }
                if (DateTemp < DateTime.Now.Date.AddYears(-5) ) //dates can be 5 years in past
                {
                    Error += "The order date is too far in the past : ";
                }
            }
            catch
            {
                //record the error
                Error += "The date was not a valid date : ";
            }
            /** TOTAL PRICE **/
            try
            {
                if (orderTotalPrice.Length == 0)
                {
                    Error += "Order total price cannot be blank : ";
                } 
                if (orderTotalPrice.Length > 7)
                {
                    Error += "The total price cannot be over 7 digits : ";
                }
                if (Convert.ToDecimal(orderTotalPrice) < 0)
                {
                    Error += "The total price cannot be lower than 0 : ";
                }
            }
            catch
            {
                //record error
                Error += "The total price was not in the right format - a decimal of 7 digits : ";
            }
            //always return at end
            return Error;

        }


    }
}