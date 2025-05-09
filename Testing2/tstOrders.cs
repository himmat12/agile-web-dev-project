using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        //create instance of class
        private clsOrders AnOrder = new clsOrders();
        //test data
        private int TestDataInt = 1;
        private string TestDataStatus = "pending";
        private DateTime TestDataDate = DateTime.Now;
        private bool TestDataPaid = true;
        private float TestDataTotalPrice = 14.56F;

        private Int32 OrderID = 2;
        private Boolean Found = false; //create a Boolean to store result of search
        private Boolean OK = true; //create Boolean to record if data is OK (assume true)

        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOK()
        {
            //does it exist
            Assert.IsNotNull(AnOrder);
        }

        /******************PROPERTY OK TESTS******************/
        [TestMethod]
        public void OrderIDOK()
        {
            //assign data to test
            AnOrder.OrderID = TestDataInt;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestDataInt);
        }
        [TestMethod]
        public void OrderPlacementDateOK()
        {
            //assign data to test
            AnOrder.OrderDate = TestDataDate;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestDataDate);
        }
        [TestMethod]
        public void OrderStatusOK()
        {
            //assign data to test
            AnOrder.OrderStatus = TestDataStatus;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderStatus, TestDataStatus);
        }
        [TestMethod]
        public void OrderIsPaidOK()
        {
            //assign data to test
            AnOrder.OrderPaid = TestDataPaid;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderPaid, TestDataPaid);
        }
        [TestMethod]
        public void OrderTotalPriceOK()
        {
            //assign data to test
            AnOrder.OrderTotalPrice = TestDataTotalPrice;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderTotalPrice, TestDataTotalPrice);
        }
        [TestMethod]
        public void CustomerIDOK()
        {
            //assign data to test
            AnOrder.CustomerID = TestDataInt;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestDataInt);
        }
        [TestMethod]
        public void StaffIDOK()
        {
            //assign data to test
            AnOrder.StaffID = TestDataInt;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.StaffID, TestDataInt);
        }

        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //Boolean to store result of validation
            Boolean Found = false;
            //test data
            Int32 OrderID = 2;

            //invoke method
            Found = AnOrder.Find(OrderID);
            //test to check if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestOrderIDFound()
        {
            //invoke method using test data OrderID
            Found = AnOrder.Find(OrderID);
            if(AnOrder.OrderID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK); //test to see if result is correct
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            //invoke method using test data OrderID
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderDate != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderStatusFound()
        {
            //invoke method using test data OrderID
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderStatus != "Test") 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPaidFound()
        {
            //invoke method using test data OrderID
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderPaid != true)
            {
                OK = false;
            }
          Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTotalPriceFound()
        {
            //invoke method using test data OrderID
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderTotalPrice != 12.34F)
            {  
                OK = false; 
            }   
            Assert.IsTrue(OK);  
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            //invoke method using test data OrderID
            Found = AnOrder.Find(OrderID);
            if (AnOrder.StaffID != 2)
            { 
            OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerID()
        {
            //invoke method using test data OrderID
            Found = AnOrder.Find(OrderID);
            if (AnOrder.CustomerID != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
