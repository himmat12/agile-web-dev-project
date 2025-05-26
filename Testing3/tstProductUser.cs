using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstProductUser

    //Property testing for clsProductUser class//
    {

        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to test
            clsProductUser productUser = new clsProductUser();
            // Test that the instance is not null
            Assert.IsNotNull(productUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            // Create an instance of the class we want to test
            clsProductUser productUser = new clsProductUser();
            // Create a test value for the UserID property
            int testUserID = 3;
            // Assign the test value to the UserID property
            productUser.UserID = testUserID;
            // Test that the UserID property is set correctly
            Assert.AreEqual(testUserID, productUser.UserID);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            // Create an instance of the class we want to test
            clsProductUser productUser = new clsProductUser();
            // Create a test value for the UserName property
            string testUserName = "Sandra";
            // Assign the test value to the UserName property
            productUser.UserName = testUserName;
            // Test that the UserName property is set correctly
            Assert.AreEqual(testUserName, productUser.UserName);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            // Create an instance of the class we want to test
            clsProductUser productUser = new clsProductUser();
            // Create a test value for the Password property
            string testPassword = "sandra321";
            // Assign the test value to the Password property
            productUser.Password = testPassword;
            // Test that the Password property is set correctly
            Assert.AreEqual(testPassword, productUser.Password);
        }

        [TestMethod]

        public void DepartmentPropertyOK()
        {
            // Create an instance of the class we want to test
            clsProductUser productUser = new clsProductUser();
            // Create a test value for the Department property
            string testDepartment = "Products";
            // Assign the test value to the Department property
            productUser.Department = testDepartment;
            // Test that the Department property is set correctly
            Assert.AreEqual(testDepartment, productUser.Department);
        }

        //FindUser method testing for clsProductUser class//

        [TestMethod]
        public void FindUserMethodOK()
        {
            // Create an instance of the class we want to test
            clsProductUser productUser = new clsProductUser();
            //create a Boolean variable to store the result
            Boolean Found = false;
            //create some test data to use with the FindUser method
            string UserName = "Sandra";
            string Password = "sandra321";
            //invoke the FindUser method
            Found = productUser.FindUser(UserName, Password);
            //test that the result is true
            Assert.IsTrue(Found);
             
        }

        // user name and password can be found//
        [TestMethod]
        public void TestUserNamePWFound()
        {
            // Create an instance of the class we want to test
            clsProductUser productUser = new clsProductUser();
            //create a Boolean variable to store the result
            Boolean Found = false;
            //create a boolean to record if data is okay 
            Boolean OK = true;
            //create some test data to use with the FindUser method
            string UserName = "Sandra";
            string Password = "sandra321";
            //invoke the FindUser method
            Found = productUser.FindUser(UserName, Password);
            //check the user id property
            if(productUser.UserName != UserName && productUser.Password != Password)
            {
                //if the user name and password are not found, set Found to false
                Found = false;
            }
            else
            {
                //if the user name and password are found, set Found to true
                Found = true;
            }
            //test that the result is true
            Assert.IsTrue(Found);
        }

    }
}
