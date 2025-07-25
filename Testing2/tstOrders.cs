﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        /******************DATA******************/
        //create instance of class
        private clsOrders AnOrder = new clsOrders();
        //test data
        private int TestDataInt = 1;
        //good test data
        private Int32 OrderID = 2; //1,2 or 3
        private bool TestDataPaid = true;
        private DateTime TestDataDate = DateTime.Now;
        private float TestDataTotalPrice = 14.56F;
        private string OrderStatus = "pending";

        //to strings
        private string OrderDateString = DateTime.Now.ToShortDateString();
        private string OrderTotalPriceString = Convert.ToString(14.56F);
        private string OrderStaffIDString = Convert.ToString(3);
        private string OrderCustomerIDString = Convert.ToString(14);

        //string for error messages
        private string Error = "";

        //for found and ok
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
            AnOrder.OrderStatus = OrderStatus;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderStatus, OrderStatus);
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
            //invoke method uses test data from top
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
            if (AnOrder.OrderID != 2)
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
            if (AnOrder.OrderDate != Convert.ToDateTime("28/04/2025"))
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
            if (AnOrder.OrderStatus != "shipped")
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
            if (AnOrder.OrderTotalPrice != 28.99F)
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
            if (AnOrder.StaffID != 1)
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
            if (AnOrder.CustomerID != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        /******************VALIDATION TESTS******************/

        /****** UPDATE ALL TO CONTAIN STAFFID AND CUSTOMREID ******/

        [TestMethod]
        public void ValidMethodOK()
        {
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        //** STATUS **//
        private string Status = "";
        [TestMethod]
        public void OrderStatusMinMinusOne()
        {
            //invoke method- uses a blank string
            Error = AnOrder.Valid(Status, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "Order Status cannot be blank : ");
        }
        [TestMethod]
        public void OrderStatusMin()
        {
            //invoke method- uses a one character string
            Status += "a";
            Error = AnOrder.Valid(Status, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        public void OrderStatusMinPlusone()
        {
            //invoke method- uses a 2 character string
            Status += "aa";
            Error = AnOrder.Valid(Status, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMaxMinusOne()
        {
            //invoke method- uses a 19 character string
            Status = Status.PadLeft(19, 'a');
            Error = AnOrder.Valid(Status, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMax()
        {
            //invoke method- uses a 20 character string
            Status = Status.PadLeft(20, 'a');
            Error = AnOrder.Valid(Status, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            //invoke method- uses a 21 character string
            Status = Status.PadLeft(21, 'a');
            Error = AnOrder.Valid(Status, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "Order Status must have less than 20 characters: ");
        }
        [TestMethod]
        public void OrderStatusMid()
        {
            //invoke method- uses a 10 character string
            Status = Status.PadLeft(10, 'a');
            Error = AnOrder.Valid(Status, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusExtremeMax()
        {
            //invoke method- uses a 500 character string
            Status = Status.PadLeft(500, 'a');
            Error = AnOrder.Valid(Status, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "Order Status must have less than 20 characters: ");
        }

        //** DATE **//
        //create a variable to store the test date data and set it to today
        private DateTime TestDate = DateTime.Now.Date;
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderStatus, OrderDate, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see that the result is correct - date cannot be less than 5 years ago
            Assert.AreEqual(Error, "The order date is too far in the past : ");
        }
        [TestMethod]
        public void OrderDateMinMinusOne()
        {
            //change the date to yesterday
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderStatus, OrderDate, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see that the result is correct - changed to accept past dates
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderStatus, OrderDate, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //change the date to tomorrow
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderStatus, OrderDate, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see that the result is correct
            Assert.AreEqual(Error, "The order date cannot be in the future : ");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //change the date to plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderStatus, OrderDate, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see that the result is correct
            Assert.AreEqual(Error, "The order date cannot be in the future : ");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //invalid data type - string not date
            string OrderDate = "this is not a date!";
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDate, OrderTotalPriceString, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "The date is not a valid date : ");
        }

        //** TOTAL PRICE **//
        private float TestTotalPrice = 0.00F;
        [TestMethod]
        public void OrderTotalPriceExtremeMin()
        {
            //change total price
            TestTotalPrice -= 1000000.00F; //over 6 digits and under 0
            //convert to string
            string TotalPrice = TestTotalPrice.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, TotalPrice, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "The total price cannot be over 7 digits : The total price cannot be lower than 0 : ");
        }
        [TestMethod]
        public void OrderTotalPriceMinMinusOne()
        {
            //change total price
            TestTotalPrice -= 1;
            //convert to string
            string TotalPrice = TestTotalPrice.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, TotalPrice, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "The total price cannot be lower than 0 : ");
        }
        [TestMethod]
        public void OrderTotalPriceMin()
        {
            //convert to string- uses default 0
            string TotalPrice = TestTotalPrice.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, TotalPrice, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderTotalPriceMinPlusOne()
        {
            //change total price
            TestTotalPrice = 1;
            //convert to string
            string TotalPrice = TestTotalPrice.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, TotalPrice, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderTotalPriceMaxMinusOne()
        {
            //change total price
            TestTotalPrice = 9999998.99F;
            //convert to string
            string TotalPrice = TestTotalPrice.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, TotalPrice, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderTotalPriceMax()
        {
            //change total price
            TestTotalPrice = 9999.49F;
            //convert to string
            string TotalPrice = TestTotalPrice.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, TotalPrice, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderTotalPriceMaxPlusOne()
        {
            //change total price
            TestTotalPrice = 10000.49F;
            //convert to string
            string TotalPrice = TestTotalPrice.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, TotalPrice, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "The total price cannot be over 7 digits : ");
        }
        [TestMethod]
        public void OrderTotalPriceMid()
        {
            //change total price
            TestTotalPrice = 5000000.50F;
            //convert to string
            string TotalPrice = TestTotalPrice.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, TotalPrice, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderTotalPriceExtremeMax()
        {
            //change total price
            TestTotalPrice = 9999999999999999999999F;
            //convert to string
            string TotalPrice = TestTotalPrice.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, TotalPrice, OrderCustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "The total price was not in the right format - a decimal of 7 digits : ");
        }
        //** CUSTOMER ID **//
        private int CustomerID = 1;
        [TestMethod]
        public void CustomerIDExtremeMin()
        {
            //change customer ID
            CustomerID = -1000;
            //convert to string
            string CustomerIDString = CustomerID.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, OrderTotalPriceString, CustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "Customer ID cannot be 0 or lower : ");
        }
        [TestMethod]
        public void CustomerIDMinMinusOne()
        {
            //change customer ID
            CustomerID = 0;
            //convert to string
            string CustomerIDString = CustomerID.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, OrderTotalPriceString, CustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "Customer ID cannot be 0 or lower : ");
        }
        [TestMethod]
        public void CustomerIDMin()
        {
            //change customer ID
            CustomerID = 1;
            //convert to string
            string CustomerIDString = CustomerID.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, OrderTotalPriceString, CustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //change customer ID
            CustomerID = 2;
            //convert to string
            string CustomerIDString = CustomerID.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, OrderTotalPriceString, CustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //change customer ID
            CustomerID = 10000000;
            //convert to string
            string CustomerIDString = CustomerID.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, OrderTotalPriceString, CustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "Customer ID is too large : ");
        }
        [TestMethod]
        public void CustomerIDInvalidData()
        {
            //set customer ID to a string
            string CustomerIDString = "string";
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, OrderTotalPriceString, CustomerIDString, OrderStaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "Select a customer ID : ");
        }

        //** STAFF ID **//
        private int StaffID = 1;
        [TestMethod]
        public void StaffIDExtremeMin()
        {
            //change Staff ID
            StaffID = -1000;
            //convert to string
            string StaffIDString = StaffID.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, StaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "Staff ID cannot be 0 or lower : ");
        }
        
        [TestMethod]
        public void StaffIDMinMinusOne()
        {
            //change Staff ID
            StaffID = 0;
            //convert to string
            string StaffIDString = StaffID.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, StaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "Staff ID cannot be 0 or lower : ");
        }
        
        [TestMethod]
        public void StaffIDMin()
        {
            //change Staff ID
            StaffID = 1;
            //convert to string
            string StaffIDString = StaffID.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, StaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            //change Staff ID
            StaffID = 2;
            //convert to string
            string StaffIDString = StaffID.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, StaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDExtremeMax()
        {
            //change Staff ID
            StaffID = 10000000;
            //convert to string
            string StaffIDString = StaffID.ToString();
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, StaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "Staff ID is too large : ");
        }
        [TestMethod]
        public void StaffIDInvalidData()
        {
            //set Staff ID to a string
            string StaffIDString = "string";
            //invoke method
            Error = AnOrder.Valid(OrderStatus, OrderDateString, OrderTotalPriceString, OrderCustomerIDString, StaffIDString);
            //test to see if result is correct
            Assert.AreEqual(Error, "Select a Staff ID ");
        }
       
    }
}
