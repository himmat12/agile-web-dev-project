using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        //Members
        List<clsOrders> mOrdersList = new List<clsOrders>();
        clsOrders mThisOrder = new clsOrders();

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

        
        //constructor for the class
        public clsOrdersCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrders AnOrder = new clsOrders();
                //read in the fields for the current record
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
    }
}