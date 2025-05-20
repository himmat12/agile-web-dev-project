using System;
using System.Globalization;

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

        /*********VALID METHOD**********/

        public string Valid(string name, string email, string PhoneNumber, string address, string CreatedAt)
        {
            string Error = "";

            //if the name is blank
            if (name.Length == 0)
            {
                //record the error
                Error = Error + "Name may not be blank : ";

            }
            //if name is no greater than 50 characters
            if (name.Length > 50)
            {
                //record error
                Error = Error + "name must be under 50 characters";
            }
           

                //if email is blank
                if (email.Length == 0)
            {
                //record the error
                Error = Error + "email must not remain blank : ";

            }
            if (email.Length > 50)
            {
                //record error
                Error = Error + "email must be under 50 characters";
            }

            if (address.Length == 0)
            {
                //record the error
                Error = Error + "address must not remain blank : ";

            }
            if (address.Length > 50)
            {
                //record error
                Error = Error + "address must be under 50 characters";
            }

            DateTime DateTemp;

            try
            {
                DateTemp = Convert.ToDateTime(CreatedAt);

                /**DATE **/
                if (DateTemp > DateTime.Now.Date)
                {
                    Error += "The created date cannot be in the past : ";
                }
                if (DateTemp < DateTime.Now.Date.AddMonths(-3)) //dates can be 3 month in the past
                {
                    Error += "The created date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error += "The date was not a valid date : ";
            }

            if (PhoneNumber.Length == 0)

            {
                Error = Error + "phonenumber must not remain blank : ";
            }
            if (PhoneNumber.Length > 50)
            {
                //record the error
                Error = Error + "phonenumber must be under 50 characters : ";
            }


                return "";

        }
    }
}