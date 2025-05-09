using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstSupplier
    {
        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOk()
        {
            clsSupplier Supplier = new clsSupplier();
            Assert.IsNotNull(Supplier);
        }

        /******************PROPERTY OK TESTS******************/

        [TestMethod]
        public void ActivePropertyOk() {
            clsSupplier Supplier = new clsSupplier();   
            Boolean TestData = true;
            Supplier.Active = TestData;

            Assert.AreEqual(Supplier.Active,TestData);
        }

        [TestMethod]
        public void IdPropertyOk()
        {
            clsSupplier Supplier = new clsSupplier();
            Int32 TestData = 1;
            Supplier.Id = TestData;

            Assert.AreEqual(Supplier.Id, TestData);
        }

        [TestMethod]
        public void NamePropertyOk()
        {
            clsSupplier Supplier = new clsSupplier();
            String TestData = "Bob";
            Supplier.Name = TestData;

            Assert.AreEqual(Supplier.Name, TestData);
        }

        [TestMethod]
        public void EmailPropertyOk()
        {
            clsSupplier Supplier = new clsSupplier();
            String TestData = "bob2025@gmail.com";
            Supplier.Email = TestData;

            Assert.AreEqual(Supplier.Email, TestData);
        }

        [TestMethod]
        public void PhonePropertyOk()
        {
            clsSupplier Supplier = new clsSupplier();
            String TestData = "123456789";
            Supplier.Phone = TestData;

            Assert.AreEqual(Supplier.Phone, TestData);
        }

        [TestMethod]
        public void AddressPropertyOk()
        {
            clsSupplier Supplier = new clsSupplier();
            String TestData = "Gateway House, LE19BH";
            Supplier.Address = TestData;

            Assert.AreEqual(Supplier.Address, TestData);
        }


        [TestMethod]
        public void DatePropertyOk()
        {
            clsSupplier Supplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            Supplier.DateAdded = TestData;

            Assert.AreEqual(Supplier.DateAdded, TestData);
        }

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOk()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;

            Int32 SupplierId = 1;

            Found = Supplier.Find(SupplierId);

            Assert.IsTrue(Found);

        }

        /******************PROPERTY DATA TESTS******************/

        [TestMethod]
        public void TestIdFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean OK = true;
            Boolean Found = false;
           Int32 SupplierId = 1;

             Found = Supplier.Find(SupplierId);

            if (Supplier.Id != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestNameFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean OK = true;
            Boolean Found = false;
            Int32 SupplierId = 11;

            Found = Supplier.Find(SupplierId);

            if (Supplier.Name != "Himmat")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestEmailFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean OK = true;
            Boolean Found = false;
            Int32 SupplierId = 11;

            Found = Supplier.Find(SupplierId);

            if (Supplier.Email != "himmat@gmail.com")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPhoneFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean OK = true;
            Boolean Found = false;
            Int32 SupplierId = 11;

            Found = Supplier.Find(SupplierId);

            if (Supplier.Phone != "123")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAddressFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean OK = true;
            Boolean Found = false;
            Int32 SupplierId = 11;

            Found = Supplier.Find(SupplierId);

            if (Supplier.Address != "Leicester")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestActiveFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean OK = true;
            Boolean Found = false;
            Int32 SupplierId = 11;

            Found = Supplier.Find(SupplierId);

            if (Supplier.Active != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean OK = true;
            Boolean Found = false;
            Int32 SupplierId = 11;

            Found = Supplier.Find(SupplierId);

            if (Supplier.DateAdded !=Convert.ToDateTime("09/05/2025"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
