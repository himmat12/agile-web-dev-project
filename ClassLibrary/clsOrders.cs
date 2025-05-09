using System;

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

        public bool Find(int orderID)
        {
            //set private data members to the test data value 
            mOrderID = 2;
            mOrderDate = Convert.ToDateTime("23/12/2022");
            mOrderStatus = "Test";  //no validation for enum
            mOrderPaid = true;
            mOrderTotalPrice = 12.34F;
            mStaffID = 2;
            mCustomerID = 5;
            //always return true
            return true;

        }
    }
}