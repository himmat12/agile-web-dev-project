using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list 
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private member data for thisCustomer
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

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomers_SelectAll");
            PopulateArray(DB);
           
            }
        

        public int Add()
        {
            //adds a record to the database based on the values of mThisCustomer
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@IsSubscribed", mThisCustomer.IsSubscribed);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@CreatedAt", mThisCustomer.CreatedAt);

            //execute the query returning the primary key values
            return DB.Execute("sproc_tblCustomers_Insert");
        }

        public void Update()
        {
            //adds a record to the database based on the values of mThisCustomer
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@IsSubscribed", mThisCustomer.IsSubscribed);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@CreatedAt", mThisCustomer.CreatedAt);

            //execute the query returning the primary key values
            DB.Execute("sproc_tblCustomers_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_Delete");
        }

        //public void ReportByPhoneNumber(string v, string PhoneNumber)
        //{
        //    //filters the records based on a full or partial phone number
        //}
        public void ReportByPhoneNumber(string PhoneNumber)
        {
            //filters the records based on a full or partial phone number
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PhoneNumber", PhoneNumber);
            //execute 
            DB.Execute("sproc_tblCustomers_FilterByPhoneNumber");

            PopulateArray(DB);
        }

         void PopulateArray(clsDataConnection DB)
        {

            //clear the current list
            //mCustomerList = new List<clsCustomer>();

            //populate the list with filtered data
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();

            while (Index < RecordCount)
            {
                clsCustomer Customer = new clsCustomer();

                Customer.IsSubscribed = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsSubscribed"]);
                Customer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                Customer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                Customer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                Customer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                Customer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                Customer.CreatedAt = Convert.ToDateTime(DB.DataTable.Rows[Index]["CreatedAt"]);
                mCustomerList.Add(Customer);
                Index++;

            }
        }
    }  
}
