using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrderUser
    {
        /******************DATA******************/
        //create instance of the class
        clsOrderUser AnUser = new clsOrderUser();
        //test data
        Int32 TestUserID = 1;
        string TestUN = "Lucy";
        string TestPW = "lucy123";
        string TestDep = "Orders";
        Boolean Found = false;

        /******************INSTANCE OF THE CLASS TEST******************/
        [TestMethod]
        public void InstanceOK()
        {
            //test to see if it exists
            Assert.IsNotNull(AnUser);
        }

        /******************PROPERTY OK TESTS******************/
        [TestMethod]
        public void UserIDProprtyOK()
        {
            //assign data to property
            AnUser.UserID = TestUserID;
            //test if the two values are the same
            Assert.AreEqual(AnUser.UserID, TestUserID);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        { 
            //assign the data to the property
            AnUser.UserName = TestUN;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestUN);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //assign the data to the property
            AnUser.Password = TestPW;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestPW);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //assign the data to the property
            AnUser.Department = TestDep;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestDep);
        }

        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindUserMethodOK()
        {
            Found = AnUser.FindUser(TestUN, TestPW);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            Boolean OK = true;
            Found = AnUser.FindUser(TestUN, TestPW);
            //check the user id property
            if(AnUser.UserName != TestUN && AnUser.UserName != TestPW)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUNPW2()
        {
            clsOrderUser AnUser2 = new clsOrderUser();
            Boolean Found2 = false;
            Boolean OK2 = true;
            string UN2 = "Lucy";
            string PW2 = "lucy123";
            Found2 = AnUser2.FindUser(UN2, PW2);
            //check the user id property
            if (AnUser2.UserName != UN2 && AnUser2.UserName != PW2)
            {
                OK2 = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK2);
        }
    }
 }
