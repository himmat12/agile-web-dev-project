using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()

        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(Staff);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            Staff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffId, TestData);
        }
        [TestMethod]
        public void ActivePropertyOk()
        {
            clsStaff Staff = new clsStaff();
            Boolean TestData = true;
            Staff.Active = TestData;
            Assert.AreEqual(Staff.Active, TestData);
        }

        [TestMethod]
        public void EmploymentDate()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Staff.EmploymentDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.EmploymentDate, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "maya@gmail.com";
            //assign the data to the property
            Staff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.Email, TestData);
        }
        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "maya";
            //assign the data to the property
            Staff.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.Name, TestData);
        }
        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            int TestData = 250;
            //assign the data to the property
            Staff.Salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.Salary, TestData);
        }

        [TestMethod]
        public void ContactNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            Staff.ContactNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.ContactNumber, TestData);
        }
    }
}
