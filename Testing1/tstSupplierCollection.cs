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

        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();

            clsSupplier TestItem = new clsSupplier();

            Int32 PrimaryKey = 0;

            TestItem.Id = 1;
            TestItem.Name = "Charly Ryl";
            TestItem.Email = "charlryl@gmail.com";
            TestItem.Phone = "5684351335";
            TestItem.Address = "Manchester";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Active = true;

            AllSupplier.ThisSupplier = TestItem;

            PrimaryKey = AllSupplier.Add();

            TestItem.Id = PrimaryKey;

            AllSupplier.ThisSupplier.Find(PrimaryKey);

            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();

            clsSupplier TestItem = new clsSupplier();

            Int32 PrimaryKey = 0;

            TestItem.Name = "Charly Ryl";
            TestItem.Email = "charlryl@gmail.com";
            TestItem.Phone = "5684351335";
            TestItem.Address = "Manchester";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Active = true;

            AllSupplier.ThisSupplier = TestItem;

            PrimaryKey = AllSupplier.Add();

            TestItem.Id = PrimaryKey;

            // updating the properties

            TestItem.Name = "Charly Pop";
            TestItem.Email = "charlryl@example.com";
            TestItem.Phone = "2222222222";
            TestItem.Address = "Nepal";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Active = true;

            AllSupplier.ThisSupplier = TestItem;

            AllSupplier.Update();

            AllSupplier.ThisSupplier.Find(PrimaryKey);

            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();

            clsSupplier TestItem = new clsSupplier();

            Int32 PrimaryKey = 0;

            TestItem.Name = "Charly Ryl";
            TestItem.Email = "charlryl@gmail.com";
            TestItem.Phone = "5684351335";
            TestItem.Address = "Manchester";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Active = true;

            AllSupplier.ThisSupplier = TestItem;

            PrimaryKey = AllSupplier.Add();

            TestItem.Id = PrimaryKey;

            AllSupplier.ThisSupplier.Find(PrimaryKey);

            AllSupplier.Delete(PrimaryKey);

            Boolean Found = AllSupplier.ThisSupplier.Find(PrimaryKey);

            Assert.IsFalse( Found );
        }
    }
}
