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
        //Create test data using a list of objects
        private List<clsOrders> TestList = new List<clsOrders>();
        //create the item of test data
        private clsOrders TestOrder = new clsOrders();

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

    }
}
