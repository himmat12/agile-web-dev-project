using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }

            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the Count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we will worry about this late
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }
        public clsCustomerCollection()
        {
            //variable for the class
            Int32 Index = 0;

            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomers_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomer Customer = new clsCustomer();
                //read in the fields for the current record 
                Customer.IsSubscribed = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsSubscribed"]);
                Customer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                Customer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                Customer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                Customer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                Customer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                Customer.CreatedAt = Convert.ToDateTime(DB.DataTable.Rows[Index]["CreatedAt"]);
                mCustomerList.Add(Customer);
                //point at the next record
                Index++;
            }
        }
    }
}
