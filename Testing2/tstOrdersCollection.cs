using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstOrdersCollection
    {
        /******************DATA******************/
        //create a new instance of the clsOrdersCollection
        private clsOrdersCollection AllOrders = new clsOrdersCollection();
        //create instance of the filtered data
        clsOrdersCollection FilteredOrders = new clsOrdersCollection();
        //apply a blank string - should return all records
        //Create test data using a list of objects
        private List<clsOrders> TestList = new List<clsOrders>();
        //create the item of test data
        private clsOrders TestOrder = new clsOrders();
        //variable to store primary key
        Int32 PrimaryKey = 0;

        /******************INSTANCE OF THE CLASS TEST******************/
        [TestMethod]
        public void InstanceOK()
        {
            //test to see if AllOrders exists - OrdersCollection class
            Assert.IsNotNull(AllOrders);
        }

        /******************PROPERTY OK TESTS******************/
        [TestMethod]
        public void OrdersListOK()
        {
            //set properties of test
            TestOrder.OrderID = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.OrderStatus = "pending";
            TestOrder.OrderPaid = true;
            TestOrder.OrderTotalPrice = 100;
            TestOrder.CustomerID = 1;
            TestOrder.StaffID = 1;
            //add the item to the test list
            TestList.Add(TestOrder);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to check if two values are the same
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //set properties of test
            TestOrder.OrderID = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.OrderStatus = "pending";
            TestOrder.OrderPaid = true;
            TestOrder.OrderTotalPrice = 100;
            TestOrder.CustomerID = 1;
            TestOrder.StaffID = 1;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        //functionality test
        [TestMethod]
        public void ListAndCountOK()
        {
            //set properties of test
            TestOrder.OrderID = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.OrderStatus = "pending";
            TestOrder.OrderPaid = true;
            TestOrder.OrderTotalPrice = 100;
            TestOrder.CustomerID = 1;
            TestOrder.StaffID = 1;
            //add the item to the test list
            TestList.Add(TestOrder);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        //add method
        [TestMethod]
        public void AddMethodOK()
        {
            //set properties of test
            TestOrder.OrderID = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.OrderStatus = "pending";
            TestOrder.OrderPaid = true;
            TestOrder.OrderTotalPrice = 100;
            TestOrder.CustomerID = 15;
            TestOrder.StaffID = 1;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestOrder;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestOrder.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);

        }
        //update method
        public void UpdateMethodOK()
        {
            //set properties of the test
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.OrderStatus = "pending";
            TestOrder.OrderPaid = false;
            TestOrder.OrderTotalPrice = 100;
            TestOrder.CustomerID = 15;
            TestOrder.StaffID = 1;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestOrder;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestOrder.OrderID = PrimaryKey;
            //modify the test record
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.OrderStatus = "shipped";
            TestOrder.OrderPaid = true;
            TestOrder.OrderTotalPrice = 105;
            TestOrder.CustomerID = 15;
            TestOrder.StaffID = 1;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestOrder;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see if ThisOrder matches test data
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        //delete method
        [TestMethod]
        public void DeleteMethodOK()
        {
            //set properties of the test
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.OrderStatus = "pending";
            TestOrder.OrderPaid = false;
            TestOrder.OrderTotalPrice = 100;
            TestOrder.CustomerID = 15;
            TestOrder.StaffID = 1;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestOrder;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestOrder.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see if the record was not found
            Assert.IsFalse(found); 
        }


        //filter method
        [TestMethod]
        public void ReportByStatusMethodOK()
        {
            FilteredOrders.ReportByStatus("");
            //test to see if two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByNoneFound()
        {
            //try to filter based on a value that doesn't exist
            FilteredOrders.ReportByStatus("xxxx");
            //test to see if there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByDataStatusTestDataFound()
        {
            //variable to store the outcome
            Boolean OK = true;
            //apply a status that doesnt exist
            FilteredOrders.ReportByStatus("shipped"); //2 records
            //check that the corret number of records are found
            if(FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrdersList[0].OrderID != 2)
                {
                    OK = false;
                }
                if(FilteredOrders.OrdersList[1].OrderID != 5)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are records
            Assert.IsTrue(OK);

        }

    }
}
