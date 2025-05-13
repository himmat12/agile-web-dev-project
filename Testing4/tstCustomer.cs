using System;
using System.Net;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {

        /******************** INSTANCE OF THE CLASS TEST **************/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsCustomer Customer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(Customer);
        }



        /************** PROPERTY OK TEST ***********/

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
        public void NameOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Sam";
            //assign the data 
            customer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Name, TestData);
        }

        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data 
            string TestData = "samiira@email.com";
            //assign the data to the property
            customer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Email, TestData);
        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data
            string TestData = "07485837484";
            //assign the data to the property
            customer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void IsSubscribedOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the propert
            customer.IsSubscribed = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.IsSubscribed, TestData);
        }

        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data 
            string TestData = "Some Street";
            //assign the data
            customer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Address, TestData);
        }

        [TestMethod]
        public void CreatedAtOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Customer.CreatedAt = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CreatedAt, TestData);
        }


        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            Customer.DateAdded = TestData;

            Assert.AreEqual(Customer.DateAdded, TestData);
        }

    }
}