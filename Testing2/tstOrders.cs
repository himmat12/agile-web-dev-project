using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        private int TestDataInt = 1;
        private string TestDataStatus = "pending";
        private DateTime TestDataDate = DateTime.Now;
        private bool TestDataPaid = true;
        private float TestDataTotalPrice = 14.56F;

        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class
            clsOrders AnOrder = new clsOrders();
            //does it exist
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void OrderIDOK()
        {
            //create instance of class
            clsOrders AnOrder = new clsOrders();
            //assign data to test
            AnOrder.OrderID = TestDataInt;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestDataInt);
        }
        [TestMethod]
        public void OrderPlacementDateOK()
        {
            //create instance of class
            clsOrders AnOrder = new clsOrders();
            //assign data to test
            AnOrder.OrderDate = TestDataDate;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestDataDate);
        }
        [TestMethod]
        public void OrderStatusOK()
        {
            //create instance of class
            clsOrders AnOrder = new clsOrders();
            //assign data to test
            AnOrder.OrderStatus = TestDataStatus;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderStatus, TestDataStatus);
        }
        [TestMethod]
        public void OrderIsPaidOK()
        {
            //create instance of class
            clsOrders AnOrder = new clsOrders();
            //assign data to test
            AnOrder.OrderPaid = TestDataPaid;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderPaid, TestDataPaid);
        }
        [TestMethod]
        public void OrderTotalPriceOK()
        {
            //create instance of class
            clsOrders AnOrder = new clsOrders();
            //assign data to test
            AnOrder.OrderTotalPrice = TestDataTotalPrice;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderTotalPrice, TestDataTotalPrice);
        }
        [TestMethod]
        public void CustomerIDOK()
        {
            //create instance of class
            clsOrders AnOrder = new clsOrders();
            //assign data to test
            AnOrder.CustomerID = TestDataInt;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestDataInt);
        }
        [TestMethod]
        public void StaffIDOK()
        {
            //create instance of class
            clsOrders AnOrder = new clsOrders();
            //assign data to test
            AnOrder.StaffID = TestDataInt;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.StaffID, TestDataInt);
        }
    }
}
