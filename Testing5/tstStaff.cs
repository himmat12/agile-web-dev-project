using System;
using System.IO;
using System.Net;
using System.Security.Policy;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstStaff
    {
        //create some test data to use with the class
        string EmploymentDate = DateTime.Now.ToShortDateString();
        String Email = "maya@gmail.com";
        String Name = "Maya";
        String ContactNumber = "123";
        String Salary = "250";
        //create a string variable to store the error








        //instance test data
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
        public void EmploymentDatePropertyOK()
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
            if (Staff.EmploymentDate != Convert.ToDateTime("24/05/2025"))
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
        // *****Valid Method Tests****

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a string variable to store the error
            string Error = "";
            //create some test data to assign to the property
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the two values are the same
            Assert.AreEqual(Error, "");
        }
        public string Valid(string employmentDate, string email, string name, string contactNumber, string salary)
        {
            // Validation logic here
            return "";
        }

        //****Parameterised tests for the valid method****

        // Contact Number Tests

        [TestMethod]
        public void ContactNumberLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a string variable to store the error
            string Error = "";
            //create some test data to assign to the property
            string ContactNumber = "123";
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the two values are the same
            Assert.AreNotEqual(Error, "The contact number may not be blank");
        }

        [TestMethod]
        public void ContactNumberMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ContactNumber = "a"; //this should be ok
                                        //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aa"; //this should be ok
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ContactNumber = "aaaaa"; //this should be ok
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ContactNumber = "aaaaaa"; //this should be ok
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ContactNumber = "aaa"; //this should be ok
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void ContactNumberPlusOne()
        {
            clsStaff Staff = new clsStaff();
            //String variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ContactNumber = "aaaaaaa"; //this should be ok
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberExtremeMax()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            //create some test data to pass to the method
            string ContactNumber = ""; //this should be 
            ContactNumber = ContactNumber.PadRight(500, 'a'); // this should be fail
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "The Contact no must be less than 6 characters");
        }

        // ***** Dates test ******


        [TestMethod]

        public void EmploymentDateExtremeMin()
        {

            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            TestData = DateTime.Now.Date;
            TestData = TestData.AddYears(-100); //this should fail
            //invoke the method
            String EmploymentDate = TestData.ToString();
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "The employment date cannot be in the past");

        }
        [TestMethod]
        public void EmploymentDateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "The employment date cannot be in the past");
        }
        [TestMethod]
        public void EmploymentDateAddedMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmploymentDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "The employment date cannot be in the past");
        }

        [TestMethod]
        public void EmploymentDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct

            Assert.AreNotEqual(Error, "The employment date cannot be in the past");

        }
        [TestMethod]
        public void EmploymentDateInvalidDate()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmploymentDate = "This is not a date"; //this should fail
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /******************Email Field******************/

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";
            String Email = "";
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {

            clsStaff Staff = new clsStaff();
            String Error = "";
            String Email = "a";
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";
            String Email = "aa";
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {

            clsStaff Staff = new clsStaff();
            String Error = "";

            String Email = "";
            Email = Email.PadRight(49, 'a');
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            String Email = "";

            Email = Email.PadRight(50, 'a');
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            String Email = "";

            Email = Email.PadRight(51, 'a');
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";

            String Email = "";

            Email = Email.PadRight(25, 'a');
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            String Email = "";

            Email = Email.PadRight(500, 'a');
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreNotEqual(Error, "");
        }

        /******************Name Field******************/

        [TestMethod]
        public void NameMinLessOne()
        {
            clsStaff Staff = new clsStaff();


            String Error = "";

            String Name = "";

            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsStaff Staff = new clsStaff();


            String Error = "";

            String Name = "a";

            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsStaff Staff = new clsStaff();


            String Error = "";

            String Name = "ab";

            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            String Name = "";

            Name = Name.PadRight(49, 'a');

            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsStaff Staff = new clsStaff();


            String Error = "";

            String Name = "";

            Name = Name.PadRight(50, 'a');

            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsStaff Staff = new clsStaff();


            String Error = "";

            String Name = "";

            Name = Name.PadRight(51, 'a');

            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMid()
        {
            clsStaff Staff = new clsStaff();


            String Error = "";

            String Name = "";

            Name = Name.PadRight(25, 'a');

            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsStaff Staff = new clsStaff();


            String Error = "";

            String Name = "";

            Name = Name.PadRight(500, 'a');

            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreNotEqual(Error, "");
        }

        //***** Salary*******

        [TestMethod]
        public void SalaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Salary = "";
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "The Salary must be less than 9 characters");
        }


        [TestMethod]
        public void SalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Salary = "a";
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Salary = "aa";
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Salary = "aaaaaaaa";
            //invoke the method
            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

       


       

         

        [TestMethod]
        public void SalaryMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
                    //this should pass
                    string PostCode = "aaaaaaaaa";
                    //invoke the method
                    Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
                    //test to see that the result is correct
                    Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
                    //this should fail
                    string PostCode = "aaaaaaaaaa";
                    //invoke the method
                    Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
                    //test to see that the result is correct
                    Assert.AreNotEqual(Error, "The Salary may not be blank");
        }

        [TestMethod]
        public void SalaryMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
                    //this should pass
                    string PostCode = "aaaa";
                    //invoke the method
                    Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);
                    //test to see that the result is correct
                    Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryExtremeMax()
        {
            clsStaff Staff = new clsStaff();


            String Error = "";

            String Name = "";

            Salary = Salary.PadRight(500, 'a');

            Error = Staff.Valid(EmploymentDate, Email, Name, ContactNumber, Salary);

            Assert.AreNotEqual(Error, "");
        }





    }
        
}

            
        
