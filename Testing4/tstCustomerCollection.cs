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
            TestCustomer.Name = "sam";
            TestCustomer.Email = "sam@gmail.com";
            TestCustomer.PhoneNumber = "123456789";
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
            TestItem.Name = "sam";
            TestItem.Email = "sam@gmail.com";
            TestItem.PhoneNumber = "123456789";
            TestItem.CreatedAt = DateTime.Now;
            TestItem.Address = "le4 4ft";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;

            TestItem.CustomerId = 1;
            TestItem.Name = "sam";
            TestItem.Email = "sam@gmail.com";
            TestItem.PhoneNumber = "123456789";
            TestItem.Address = "le4 4ft";
            TestItem.CreatedAt = DateTime.Now;
            TestItem.IsSubscribed = true;
            //set ThisAddress to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.Name = "sam";
            TestItem.Email = "sam@gmail.com";
            TestItem.PhoneNumber = "123456789";
            TestItem.Address = "le4 4ft";
            TestItem.CreatedAt = DateTime.Now;
            TestItem.IsSubscribed = true;
            //set ThisAddress to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //modify the test record
            TestItem.CustomerId = 5;
            TestItem.Name = "jasmine";
            TestItem.Email = "jasmine@gmail.com";
            TestItem.PhoneNumber = "012345678";
            TestItem.Address = "le3 3lj";
            TestItem.CreatedAt = DateTime.Now;
            TestItem.IsSubscribed = false;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.Name = "sam";
            TestItem.Email = "sam@gmail.com";
            TestItem.PhoneNumber = "123456789";
            TestItem.Address = "le4 4ft";
            TestItem.CreatedAt = DateTime.Now;
            TestItem.IsSubscribed = true;
            //set ThisAddress to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //Delete the record
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPhoneNumberMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomers.ReportByPhoneNumber("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByPhoneNumberNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a phone number that doesn't exist
            FilteredCustomers.ReportByPhoneNumber("88888888888");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByPhoneNumberTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //variable to store the outcome
            Boolean OK = true;
            FilteredCustomers.ReportByPhoneNumber("076389923");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check to see that the first record is 6
                if (FilteredCustomers.CustomerList[0].CustomerId != 3)
                {
                    OK = false;
                }
                if (FilteredCustomers.CustomerList[1].CustomerId != 11)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

