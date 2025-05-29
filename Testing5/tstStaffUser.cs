using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
       
             public void InstanceOk()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIdPropertyOk()
        {
            clsStaffUser AnUser = new clsStaffUser();

            Int32 TestData = 1;

            AnUser.UserId = TestData;

            Assert.AreEqual(AnUser.UserId, TestData);
        }

        [TestMethod]
        public void UsernamePropertyOk()
        {
            clsStaffUser AnUser = new clsStaffUser();

            String TestData = "Maya";

            AnUser.Username = TestData;

            Assert.AreEqual(AnUser.Username, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOk() {

            clsStaffUser AnUser = new clsStaffUser();

            String TestData = "maya123";

            AnUser.Password = TestData;

            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOk()
        {
            clsStaffUser AnUser = new clsStaffUser();

            String TestData = "Staff";

            AnUser.Department = TestData;

            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOk()
        {
            clsStaffUser AnUser = new clsStaffUser();

            Boolean Found = false;

            String Username = "Maya";
            String Password = "maya123";

            Found = AnUser.FindUser(Username, Password);

            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUsernamePWFound()
        {
            clsStaffUser AnUser = new clsStaffUser();

            Boolean Found = false;

            Boolean OK = true;

            String Username = "Maya";
            String Password = "maya123";

            Found = AnUser.FindUser(Username, Password);

            if (AnUser.Username != Username && AnUser.Password != Password)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}

