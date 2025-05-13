using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstSupplier

    {
        /******************Test Data******************/
        String Name = "Himmat";
        String Email = "himmat@gmail.com";
        String Phone = "1234567898";
        String Address = "Leicester";
        String DateAdded = DateTime.Now.ToShortDateString();

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
            Int32 SupplierId = 1;

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
            Int32 SupplierId = 1;

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
            Int32 SupplierId = 1;

            Found = Supplier.Find(SupplierId);

            if (Supplier.Phone != "123456789")
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
            Int32 SupplierId = 1;

            Found = Supplier.Find(SupplierId);

            if (Supplier.Address != "Leicester, LE1 9BH")
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
            Int32 SupplierId = 1;

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
            Int32 SupplierId = 1;

            Found = Supplier.Find(SupplierId);

            if (Supplier.DateAdded !=Convert.ToDateTime("12/05/2025"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreEqual(Error, "");
        }


        /******************Parameter Tests******************/

        /******************Supplier Name Field******************/

        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String SupplierName = "";

            Error = Supplier.ValidData(SupplierName, Email, Phone, Address, DateAdded);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String SupplierName = "a";

            Error = Supplier.ValidData(SupplierName, Email, Phone, Address, DateAdded);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String SupplierName = "ab";

            Error = Supplier.ValidData(SupplierName, Email, Phone, Address, DateAdded);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String SupplierName = "";

            SupplierName = SupplierName.PadRight(49,'a');

            Error = Supplier.ValidData(SupplierName, Email, Phone, Address, DateAdded);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String SupplierName = "";

            SupplierName = SupplierName.PadRight(50, 'a');

            Error = Supplier.ValidData(SupplierName, Email, Phone, Address, DateAdded);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String SupplierName = "";

            SupplierName = SupplierName.PadRight(51, 'a');

            Error = Supplier.ValidData(SupplierName, Email, Phone, Address, DateAdded);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMid()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String SupplierName = "";

            SupplierName = SupplierName.PadRight(25, 'a');

            Error = Supplier.ValidData(SupplierName, Email, Phone, Address, DateAdded);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String SupplierName = "";

            SupplierName = SupplierName.PadRight(500, 'a');

            Error = Supplier.ValidData(SupplierName, Email, Phone, Address, DateAdded);

            Assert.AreNotEqual(Error, "");
        }

        /******************Email Field******************/

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String Email = "";

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String Email = "a";

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String Email = "aa";

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String Email = "";

            Email = Email.PadRight(49, 'a');

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String Email = "";

            Email = Email.PadRight(50, 'a');

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String Email = "";

            Email = Email.PadRight(51, 'a');

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String Email = "";

            Email = Email.PadRight(25, 'a');

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String Email = "";

            Email = Email.PadRight(500, 'a');

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreNotEqual(Error, "");
        }

        /******************Phone Field******************/
        [TestMethod]
        public void PhoneMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Phone = "";
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Phone = "a";
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Phone = "aa";
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMaxLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Phone = "";
            Phone = Phone.PadRight(19, 'a');
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Phone = "";
            Phone = Phone.PadRight(20, 'a');
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMaxPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Phone = "";
            Phone = Phone.PadRight(21, 'a');
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMid()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Phone = "";
            Phone = Phone.PadRight(10, 'a');
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Phone = "";
            Phone = Phone.PadRight(100, 'a');
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        /******************Address Field******************/
        [TestMethod]
        public void AddressMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Address = "";
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Address = "a";
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Address = "aa";
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(49, 'a');
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(50, 'a');
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(51, 'a');
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(25, 'a');
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(200, 'a');
            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        /******************Added Date Field******************/

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);

            String DateAdded = TestDate.ToString();

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-1);

            String DateAdded = TestDate.ToString();

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            String DateAdded = TestDate.ToString();

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(1);

            String DateAdded = TestDate.ToString();

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);

            String DateAdded = TestDate.ToString();

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsSupplier Supplier = new clsSupplier();

            String Error = "";

            String DateAdded = "this is not a date";

            Error = Supplier.ValidData(Name, Email, Phone, Address, DateAdded);

            Assert.AreNotEqual(Error, "");
        }
    }
}
