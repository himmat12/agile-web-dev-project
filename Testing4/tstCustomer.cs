using System;
using System.Net;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        string Name = "Sam";
        string Email = "Sam@gmail.com";
        string PhoneNumber = "1234567890";
        string Address = "Le4 4ft";
        string CreatedAt = DateTime.Now.ToShortDateString();
        // string for error messages
        //private String Error = "";






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
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Customer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CustomerId, TestData);
        }

        [TestMethod]
        public void NameOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "sam";
            //assign the data 
            Customer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.Name, TestData);
        }

        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data 
            string TestData = "sam@gmail.com";
            //assign the data to the property
            Customer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.Email, TestData);
        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data
            string TestData = "00000000";
            //assign the data to the property
            Customer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void IsSubscribedOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the propert
            Customer.IsSubscribed = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.IsSubscribed, TestData);
        }

        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data 
            string TestData = "Some Street";
            //assign the data
            Customer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.Address, TestData);
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


        /**************FIND METHOD TEST***************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = Customer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }
        /*********** PROPERTY DATA TESTS*****************/
        [TestMethod]
        public void CustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 4;
            //invoke the method
            Found = Customer.Find(CustomerId);
            if (Customer.CustomerId != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerCreatedAtFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 4;
            Found = Customer.Find(CustomerId);
            if (Customer.CreatedAt != Convert.ToDateTime("26/02/2025"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerNameFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 4;
            Found = Customer.Find(CustomerId);
            if (Customer.Name != "paula")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerEmailFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 4;
            Found = Customer.Find(CustomerId);
            if (Customer.Email != "Paula@gmail.com")
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerAddressFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 4;
            Found = Customer.Find(CustomerId);
            if (Customer.Address != "LE4 4FT")
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIsSubscribedFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 4;
            Found = Customer.Find(CustomerId);
            if (Customer.IsSubscribed != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerPhoneNumberFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = Customer.Find(CustomerId);
            if (Customer.PhoneNumber != "123456789")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        /********VALID METHOD*************/
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //invoke the method 
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        /*****NAME ******/
        [TestMethod]
        public void NameMin()
        {
            // create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Name = "a";
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Name = "aa";
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Name = "";
            Name = Name.PadRight(49, 'a'); //less than 50 characters
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Name = "";
            Name = Name.PadRight(50, 'a');
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Name = "";
            Name = Name.PadRight(51, 'a');
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Name = "";
            Name = Name.PadRight(25, 'a');
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        /*******EMAIL*******/

        [TestMethod]
        public void EmailMin()
        {
            // create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Email = "a";
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            // create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Email = "aa";
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            // create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Email = "";
            Email = Email.PadRight(60, 'a');
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Email = "";
            Email = Email.PadRight(61, 'a');
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Name = "";
            Name = Name.PadRight(30, 'a');
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        /*********PhoneNumber***********/
        [TestMethod]
        public void PhoneNumberMin()
        {
            // create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string PhoneNumber = "0";
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            // create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string PhoneNumber = "00";
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            clsCustomer Customer = new clsCustomer();
            string Error = "";
            //test data to pass to the method
            string Name = "";
            PhoneNumber = PhoneNumber.PadRight(15, '0');
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Name = "";
            PhoneNumber = PhoneNumber.PadRight(14, '0');
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Name = "";
            PhoneNumber = PhoneNumber.PadRight(500, '0');
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /*******ADDRESS*******/
        [TestMethod]
        public void AddressMin()
        {
            // create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Address = "a";
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            // create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Email = "aa";
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsCustomer Customer = new clsCustomer();
            //string variable to store the error
            string Error = "";
            //test data to pass to the method
            string Address = "aaaaaaaaaa";
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            string Error = "";
            //test data to pass to the method
            string Address = "";
            Name = Name.PadRight(91, 'a');
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsCustomer Customer = new clsCustomer();
            string Error = "";
            //test data to pass to the method
            string Address = "aaaa";
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /**********CREATED AT*********/

        [TestMethod]
        public void CreatedAtExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = Customer.Valid(Name, Email, PhoneNumber, Address, CreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

    }

    
}