using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            
            Assert.IsNotNull(AllSupplier);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();

            List<clsSupplier> TestList = new List<clsSupplier>();

            clsSupplier TestItem = new clsSupplier();

            TestItem.Id = 1;
            TestItem.Name = "Himmat";
            TestItem.Email = "himmat@gmail.com";
            TestItem.Phone = "1234567898";
            TestItem.Address = "Leicester";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Active = true;

            TestList.Add(TestItem);

            AllSupplier.SupplierList = TestList;

            Assert.AreEqual(AllSupplier.SupplierList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    clsSupplierCollection AllSupplier = new clsSupplierCollection();

        //    Int32 SomeCount = 2;

        //    AllSupplier.Count = SomeCount;

        //    Assert.AreEqual(AllSupplier.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();

            clsSupplier TestSupplier = new clsSupplier();

            TestSupplier.Id = 1;
            TestSupplier.Name = "Himmat";
            TestSupplier.Email = "himmat@gmail.com";
            TestSupplier.Phone = "1234567898";
            TestSupplier.Address = "Leicester";
            TestSupplier.DateAdded = DateTime.Now;
            TestSupplier.Active = true;

            AllSupplier.ThisSupplier = TestSupplier;

            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();

            List<clsSupplier> TestList = new List<clsSupplier>();

            clsSupplier TestItem = new clsSupplier();

            TestItem.Id = 1;
            TestItem.Name = "Himmat";
            TestItem.Email = "himmat@gmail.com";
            TestItem.Phone = "1234567898";
            TestItem.Address = "Leicester";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Active = true;

            TestList.Add(TestItem);

            AllSupplier.SupplierList = TestList;

            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    clsSupplierCollection AllSupplier = new clsSupplierCollection();

        //    Assert.AreEqual(AllSupplier.Count, 2);

        //}
    }
}
