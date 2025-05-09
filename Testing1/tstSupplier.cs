using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsSupplier Supplier = new clsSupplier();
            Assert.IsNotNull(Supplier);
        }

        [TestMethod]
        public void ActivePropertyOk() {
            clsSupplier Supplier = new clsSupplier();   
            Boolean TestData = true;
            Supplier.Active = TestData;

            Assert.AreEqual(Supplier.Active,TestData);
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
    }
}
