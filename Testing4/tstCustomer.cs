using System;
using System.Net;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(Customer);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the propert
            customer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Customer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.DateAdded, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            customer.customerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.customerId, TestData);
        }



        [TestMethod]
        public void CountyCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            customer.CountyCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.CountyCode, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            customer.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.HouseNo, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            customer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            customer.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            customer.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Town, TestData);
        }
    }
}