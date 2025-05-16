using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer id 
        private Int32 mCustomerId;
        private string mCustomerName;
        private string mCustomerEmail;
        private string mCustomerPhoneNumber;
        private string mCustomerAddress;
        private Boolean mCustomerIsSubscribed;
        private DateTime mCustomerDateCreated;


        //customerId public property
        public Int32 CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }

        public bool IsSubscribed
        {
            get
            {
                return mCustomerIsSubscribed;
            }

            set
            {
                mCustomerIsSubscribed = value;

            }
        }
        public string Name
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
            }
        }
        public string Email
        {
            get
            {
                return mCustomerEmail;
            }

            set
            {
                mCustomerEmail = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return mCustomerPhoneNumber;

            }
            set
            {
                mCustomerPhoneNumber = value;
            }
        }
        public string Address
        {
            get
            {
                return mCustomerAddress;
            }
            set
            {
                mCustomerAddress = value;
            }
        }
        public DateTime CreatedAt
        {
            get
            {
                return mCustomerDateCreated;
            }
            set
            {
                mCustomerDateCreated = value;
            }
        }

        /*********FIND METHOD  ********/
        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for 
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerDateCreated = Convert.ToDateTime(DB.DataTable.Rows[0]["CreatedAt"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mCustomerIsSubscribed = Convert.ToBoolean(DB.DataTable.Rows[0]["IsSubscribed"]);
                mCustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                //always return true
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating there is a problem
                return false;
            }

        }
    }
}