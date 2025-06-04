using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        //Members
        List<clsOrders> mOrdersList = new List<clsOrders>();
        clsOrders mThisOrder = new clsOrders();
        List<string> mPopulateList = new List<string>();

        /****************** gets and sets ******************/

        //will provide an indexed list of Orders from the database table
        public List<clsOrders> OrdersList
        {
            get
            {
                //return the private data
                return mOrdersList;
            }
            set
            {
                //set the private data
                mOrdersList = value;
            }
        }
        //how many orders there are in this list
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrdersList.Count;
            }
            set
            {

            }
        }
        public clsOrders ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }
        public List<string> PopulateList
        {
            get
            {
                //return the private data
                return mPopulateList;
            }
            set
            {
                mPopulateList = value;
            }
        }

        
        //constructor for the class
        public clsOrdersCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblOrders_SelectAll");
            //populate the array list with the data from tblOrders
            PopulateArray(DB);
        }
        //METHODS
        //database updating
        //add
        public int Add()
        {
            //adds a record to the database based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@placementDate", mThisOrder.OrderDate);
            DB.AddParameter("@orderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@isPaid", mThisOrder.OrderPaid);
            DB.AddParameter("@totalPrice", mThisOrder.OrderTotalPrice);
            DB.AddParameter("@customerID", mThisOrder.CustomerID);
            DB.AddParameter("@staffID", mThisOrder.StaffID);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrders_Insert");
        }
        //edit/update
        public void Update()
        {
            //update an existing record based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@orderID", mThisOrder.OrderID);
            DB.AddParameter("@placementDate", mThisOrder.OrderDate);
            DB.AddParameter("@orderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@isPaid", mThisOrder.OrderPaid);
            DB.AddParameter("@totalPrice", mThisOrder.OrderTotalPrice);
            DB.AddParameter("@customerID", mThisOrder.CustomerID);
            DB.AddParameter("@staffID", mThisOrder.StaffID);

            //execute the query returning the primary key value
           DB.Execute("sproc_tblOrders_Update");
        }
        //delete
        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@orderID", mThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Delete");
        }
        //filter
        public void ReportByStatus(string orderStatus)
        {
            //filters the records based on the status
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the order status parameter to to the database
            DB.AddParameter("@orderStatus", orderStatus);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByStatus");
            //populate the array list with the data from tblOrders
            PopulateArray(DB);
        }
        //populating methods
        //order status drop down list
        public void PopulateStatusDDL()
        {
            //populates the drop down using unique order statuses from the database
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure - get unique order statuses
            DB.Execute("sproc_tblOrders_SelectDistinctOrderStatus");
            //varible for index
            Int32 Index = 0;
            //count of records
            Int32 RecordCount = DB.Count;
            //clear private string list
            mPopulateList = new List<string>();
            //while there are records
            while (Index < RecordCount)
            {
                //blank string
                string status = "";
                //populate string
                status = Convert.ToString(DB.DataTable.Rows[Index]["orderStatus"]);
                //add string to string list
                mPopulateList.Add(status);
                //next record
                Index++;
            }
        }
        //customer ID drop down list
        public void PopulateCustomerDDL()
        {
            //populates the drop down using unique order statuses from the database
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure - get unique order statuses
            DB.Execute("sproc_tblOrders_SelectDistinctCustomerID");
            //varible for index
            Int32 Index = 0;
            //count of records
            Int32 RecordCount = DB.Count;
            //clear private string list
            mPopulateList = new List<string>();
            //while there are records
            while (Index < RecordCount)
            {
                //blank string
                string customer = "";
                //populate string
                customer = Convert.ToString(DB.DataTable.Rows[Index]["customerID"]);
                //add string to string list
                mPopulateList.Add(customer);
                //next record
                Index++;
            }
        }
        //staff ID drop down list
        public void PopulateStaffDDL() 
        {
            //populates the drop down using unique order statuses from the database
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure - get unique order statuses
            DB.Execute("sproc_tblOrders_SelectDistinctStaffID");
            //varible for index
            Int32 Index = 0;
            //count of records
            Int32 RecordCount = DB.Count;
            //clear private string list
            mPopulateList = new List<string>();
            //while there are records
            while (Index < RecordCount)
            {
                //blank string
                string staff = "";
                //populate string
                staff = Convert.ToString(DB.DataTable.Rows[Index]["staffID"]);
                //add string to string list
                mPopulateList.Add(staff);
                //next record
                Index++;
            }
        }


        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //varible for index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrdersList = new List<clsOrders>();
            //while there are records
            while (Index < RecordCount)
            {
                //create a blank order object
                clsOrders AnOrder = new clsOrders();
                //read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["orderID"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["placementDate"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["orderStatus"]);
                AnOrder.OrderPaid = Convert.ToBoolean(DB.DataTable.Rows[Index]["isPaid"]);
                AnOrder.OrderTotalPrice = (float)Convert.ToDouble(DB.DataTable.Rows[Index]["totalPrice"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["customerID"]);
                AnOrder.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["staffID"]);
                //add the record to the private data member
                mOrdersList.Add(AnOrder);
                //point to the next record
                Index++;
            }
        }
    }
}