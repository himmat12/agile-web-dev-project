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
        public void IsActivePropertyOk()
        {
            clsStaff Staff = new clsStaff();
            Boolean TestData = true;
            Staff.IsActive = TestData;
            Assert.AreEqual(Staff.IsActive, TestData);
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
            Staff.IntSalary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.IntSalary, TestData);
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
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a Boolean variable to store the resuls of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = Staff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            clsStaff Staff = new clsStaff();
            //create a Boolean variable to store the resuls of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method

            Int32 StaffId = 1;

            //invoke the method
            Found = Staff.Find(StaffId);
            //check the address id
            if (Staff.StaffId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmploymentDateFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the date added property
            if (Staff.EmploymentDate != Convert.ToDateTime("2/05/2025"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestContactNumberFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the house no property
            if (Staff.ContactNumber != "123")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the street property
            if (Staff.Email != "maya@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the post code property
            if (Staff.Name != "Maya")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the town property
            if (Staff.Salary != "250")

            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestIsActiveFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the active property
            if (Staff.IsActive != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



    }
}
    

