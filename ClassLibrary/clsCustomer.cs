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

        public bool Find(int CustomerId)
        {
            mCustomerId = 4;
            mCustomerDateCreated = Convert.ToDateTime("23/10/2024");
            mCustomerName = "Sam";
            mCustomerEmail = "Sam@gmail.com";
            mCustomerAddress = "LE3 3JD";
            mCustomerIsSubscribed = true;
            mCustomerPhoneNumber = "09382736282";
            //always return true
            return true;
        }

    }
}