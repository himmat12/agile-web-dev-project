using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstCustomerUser
    {
        /***********INSTANCE OF THE CLASS TEST************/
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerUser AnUser = new clsCustomerUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
        /**********PROPERTY OK TESTS************/
        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);

        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Sam";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "sam123";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Customer";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }
        /**********FIND METHOD TEST***********/
        [TestMethod]
        public void FindUserMethodOK()
        {
            clsCustomerUser AnUser = new clsCustomerUser();
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Sam";
            string Password = "sam123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            // Create an instance of the class we want to test
            clsCustomerUser AnUser = new clsCustomerUser();
            //create a Boolean variable to store the result
            Boolean Found = false;
            //create a boolean to record if data is okay 
            Boolean OK = true;
            //create some test data to use with the FindUser method
            string UserName = "Sam";
            string Password = "sam123";
            //invoke the FindUser method
            Found = AnUser.FindUser(UserName, Password);
            //check the user id property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                //if the user name and password are not found, set Found to false
                OK = false;
            }
           
            //test that the result is true
            Assert.IsTrue(OK);
        }
    }
}

