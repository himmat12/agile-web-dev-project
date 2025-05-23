using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstSupplierUser
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIdPropertyOk()
        {
            clsSupplierUser AnUser = new clsSupplierUser();

            Int32 TestData = 1;

            AnUser.UserId = TestData;

            Assert.AreEqual(AnUser.UserId, TestData);
        }

        [TestMethod]
        public void UsernamePropertyOk()
        {
            clsSupplierUser AnUser = new clsSupplierUser();

            String TestData = "Himmat";

            AnUser.Username = TestData;

            Assert.AreEqual(AnUser.Username, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOk()
        {
            clsSupplierUser AnUser = new clsSupplierUser();

            String TestData = "himmat123";

            AnUser.Password = TestData;

            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOk()
        {
            clsSupplierUser AnUser = new clsSupplierUser();

            String TestData = "Supplier";

            AnUser.Department = TestData;

            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOk()
        {
            clsSupplierUser AnUser = new clsSupplierUser();

            Boolean Found = false;

            String Username = "Himmat";
            String Password = "himmat123";

            Found = AnUser.FindUser(Username, Password);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUsernamePWFound()
        {
            clsSupplierUser AnUser = new clsSupplierUser();

            Boolean Found = false;

            Boolean OK = true;

            String Username = "Himmat";
            String Password = "himmat123";

            Found = AnUser.FindUser(Username, Password);

            if (AnUser.Username != Username && AnUser.Password != Password)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
