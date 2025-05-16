using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        //Members
        List<clsOrders> mOrdersList = new List<clsOrders>();
        clsOrders mThisOrder;

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
            get;
            set;
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

    }
}