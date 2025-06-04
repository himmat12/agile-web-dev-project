using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing4
{
    [TestClass]
    public class tstCustomerCollection
    {
        public object AllCustomers { get; private set; }

        /*************INSTANCE OF THE CLASS TEST************/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        /***************PROPERTY OK TESTS*************/
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an Item to the List
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.IsSubscribed = true;
            TestItem.CustomerId = 1;
            TestItem.Name = "Sam";
            TestItem.Email = "Sam@gmail.com";
            TestItem.PhoneNumber = "1234567890";
            TestItem.CreatedAt = DateTime.Now;
            TestItem.Address = "Le4 4ft";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.IsSubscribed = true;
            TestCustomer.CustomerId = 1;
            TestCustomer.Name = "Sam";
            TestCustomer.Email = "Sam@gmail.com";
            TestCustomer.PhoneNumber = "1234567890";
            TestCustomer.CreatedAt = DateTime.Now;
            TestCustomer.Address = "Le4 4ft";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.IsSubscribed = true;
            TestItem.CustomerId = 1;
            TestItem.Name = "Sam";
            TestItem.Email = "Sam@gmail.com";
            TestItem.PhoneNumber = "1234567890";
            TestItem.CreatedAt = DateTime.Now;
            TestItem.Address = "Le4 4ft";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }
    }
}

