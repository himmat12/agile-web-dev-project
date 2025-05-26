using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing5
{
    [TestClass]

    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.IsActive = true;
            TestItem.StaffId = 1;
            TestItem.Name = "Maya";
            TestItem.Salary = "Salary";
            TestItem.ContactNumber = "123";
            TestItem.Email = "maya@gmail.com";
            TestItem.EmploymentDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        //   [TestMethod]

        //     public void CountPropertyOK()
        //   {
        //    clsStaffCollection AllStaff = new clsStaffCollection();

        //  Int32 SomeCount = 2;

        //  AllStaff.Count = SomeCount;

        //   Assert.AreEqual(AllStaff.Count, SomeCount);
        //   }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set its properties
            TestStaff.IsActive = true;
            TestStaff.StaffId = 1;
            TestStaff.Name = "Maya";
            TestStaff.Salary = "Salary";
            TestStaff.ContactNumber = "123";
            TestStaff.Email = "maya@gmail.com";
            TestStaff.EmploymentDate = DateTime.Now.Date;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.IsActive = true;
            TestItem.StaffId = 1;
            TestItem.Name = "Maya";
            TestItem.Salary = "Salary";
            TestItem.ContactNumber = "123";
            TestItem.Email = "maya@gmail.com";
            TestItem.EmploymentDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
        //   [TestMethod]
        // public void TwoRecordsPresent()
        //    { 
        //  clsStaffCollection AllStaff = new clsStaffCollection();
        //  Assert.AreEqual(AllStaff.Count, 2);
        //     }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.StaffId = 4;
            TestItem.Name = "Yayy";
            TestItem.Email = "yuppp@gmail.com";
            TestItem.ContactNumber = "1234567";
            TestItem.Salary = "1000";
            TestItem.EmploymentDate = DateTime.Now;
            TestItem.IsActive = true;

            AllStaff.ThisStaff = TestItem;

            PrimaryKey = AllStaff.Add();

            TestItem.StaffId = PrimaryKey;

            AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.StaffId = 4;
            TestItem.Name = "Yayy";
            TestItem.Email = "yuppp@gmail.com";
            TestItem.ContactNumber = "1234567";
            TestItem.Salary = "1000";
            TestItem.EmploymentDate = DateTime.Now;
            TestItem.IsActive = true;

            AllStaff.ThisStaff = TestItem;

            PrimaryKey = AllStaff.Add();

            TestItem.StaffId = PrimaryKey;

            // updating the properties

            TestItem.StaffId = 5;
            TestItem.Name = "yash";
            TestItem.Email = "yash@gmail.com";
            TestItem.ContactNumber = "333333";
            TestItem.Salary = "600";
            TestItem.EmploymentDate = DateTime.Now;
            TestItem.IsActive = true;

            AllStaff.ThisStaff = TestItem;

            AllStaff.Update();

            AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.Name = "Yayy";
            TestItem.Email = "yuppp@gmail.com";
            TestItem.ContactNumber = "1234567";
            TestItem.Salary = "1000";
            TestItem.EmploymentDate = DateTime.Now;
            TestItem.IsActive = true;
            AllStaff.ThisStaff = TestItem;

            PrimaryKey = AllStaff.Add();

            TestItem.Id = PrimaryKey;

            AllStaff.ThisStaff.Find(PrimaryKey);

            AllStaff.Delete(PrimaryKey);

            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }
    }
}