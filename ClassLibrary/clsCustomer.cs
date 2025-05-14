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
        private string mCustomerEmailAddress;
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
        
        public DateTime DateAdded { get; set; }
        public bool IsSubscribed { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }

        public bool Find(int CustomerId)
        {
            //always return true
            return true;
        }
    }
}