using System;
using System.Security.Cryptography.X509Certificates;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstProduct

    {
        //good test data
        string Name = "Boots";
        string Size = "UK 4";
        string Category = "Kids";
        string Price = "24.99";
        string ReleasedDate = DateTime.Now.ToShortDateString();


        /************************************************ INSTANCE OF THE CLASS TEST *************/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsProduct AnProduct = new clsProduct();
            //test that it exists
            Assert.IsNotNull(AnProduct);

        }

        /*********************************************** PROPERTIES OK TESTS *********************/
        [TestMethod]
        public void InStockPropertyOK()
        {
            //create an instance of the class
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnProduct.InStock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.InStock, TestData);

        }
        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //create an instance of the class
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnProduct.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.ProductID, TestData);
        }
        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            string TestData = "Product Name";
            //assign the data to the property
            AnProduct.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.Name, TestData);
        }
        [TestMethod]
        public void CategoryPropertyOK()
        {
            //create an instance of the class
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            string TestData = "Product Category";
            //assign the data to the property
            AnProduct.Category = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.Category, TestData);
        }

        [TestMethod]
        public void SizePropertyOK()
        {
            //create an instance of the class
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            string TestData = "Product Size";
            //assign the data to the property
            AnProduct.Size = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.Size, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            decimal TestData = 19.99m;
            //assign the data to the property
            AnProduct.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.Price, TestData);
        }

        [TestMethod]
        public void ReleasedDatePropertyOK()
        {
            //create an instance of the class
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            DateTime TestData = Convert.ToDateTime("25/05/2025");
            //assign the data to the property
            AnProduct.ReleasedDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.ReleasedDate, TestData);
        }


        /*********************************************** FIND METHOD TEST  *********************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create test data to use with the method
            Int32 ProductID = 2;
            //invoke the method
            Found = AnProduct.Find(ProductID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        /************************************************ PROPERTY DATA TESTS  *********************/

        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is OK)
            Boolean OK = true;
            //create test data to use with the method
            Int32 ProductID = 41;
            //invoke the method
            Found = AnProduct.Find(ProductID);
            //check the product ID
            if (AnProduct.ProductID != 41)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReleasedDateFound()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is OK)
            Boolean OK = true;
            //create test data to use with the method
            Int32 ProductID = 41;
            //invoke the method
            Found = AnProduct.Find(ProductID);
            //checked the released date property
            if (AnProduct.ReleasedDate != Convert.ToDateTime("23/05/2025"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is OK)
            Boolean OK = true;
            //create test data to use with the method
            Int32 ProductID = 41;
            //invoke the method
            Found = AnProduct.Find(ProductID);
            //check the in stock property
            if (AnProduct.InStock != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is OK)
            Boolean OK = true;
            //create test data to use with the method
            Int32 ProductID = 41;
            //invoke the method
            Found = AnProduct.Find(ProductID);
            //check the price property
            if (AnProduct.Price != 24.99m) //m is used to indicate a decimal
            {
                OK = false;

            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSizeFound()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is OK)
            Boolean OK = true;
            //create test data to use with the method
            Int32 ProductID = 41;
            //invoke the method
            Found = AnProduct.Find(ProductID);
            //check the size property
            if (AnProduct.Size != "UK 4")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCategoryFound()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is OK)
            Boolean OK = true;
            //create test data to use with the method
            Int32 ProductID = 41;
            //invoke the method
            Found = AnProduct.Find(ProductID);
            //check the category property
            if (AnProduct.Category != "Kids")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is OK)
            Boolean OK = true;
            //create test data to use with the method
            Int32 ProductID = 41;
            //invoke the method
            Found = AnProduct.Find(ProductID);
            //check the name property
            if (AnProduct.Name != "Boots")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }


        /*********************************************** VALID METHOD TESTS  *********************/


        [TestMethod]
        public void ValidMethodOK()
        {
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }

        /****** NAME *******/

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Name = ""; //less than 2 characters
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Name = "A"; //less than 2 characters
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Name = "AB"; 
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxMinOne() {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(49, 'A'); //less than 50 characters
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Name = ""; //less than 50 characters
            Name = Name.PadRight(50, 'A');
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Name = ""; 
            Name = Name.PadRight(51, 'A');
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(25, 'A');
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Name = ""; 
            Name = Name.PadRight(500, 'A');
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }

        /****** SIZE *******/

        [TestMethod]
        public void SizeMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Size = ""; 
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SizeMin()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Size = "4"; //valid size
            //invoke the method
            Error = AnProduct.Valid(Name,Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SizeMinPlusOne()
        {
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Size = "44"; //valid size
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SizeMaxMinOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Size = "";
            Size = Size.PadRight(49, '4'); //valid size
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMax()
        {
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Size = "";
            Size = Size.PadRight(50, '4'); 
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }

  
        [TestMethod]
        public void SizeMaxPlusOne()
        
            { clsProduct AnProduct = new clsProduct();
                //string variable to store the error
                string Error = "";
                //create some test data to pass to the method
                string Size = "";
                Size = Size.PadRight(51, 'A'); 
                //invoke the method
                Error = AnProduct.Valid(Name,Size, Category, Price, ReleasedDate);
                //test to see if the result is true
                Assert.AreNotEqual(Error, "");
            }

        [TestMethod]
            public void SizeMid()
            {

                //create an instance of the class we want to create
                clsProduct AnProduct = new clsProduct();
                //string variable to store the error
                string Error = "";
                //create some test data to pass to the method
                string Size = "";
                Size = Size.PadRight(25, '4'); 
                //invoke the method
                Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
                //test to see if the result is true
                Assert.AreEqual(Error, "");
            }
        [TestMethod]
            public void SizeExtremeMax()
            {
                //create an instance of the class we want to create
                clsProduct AnProduct = new clsProduct();
                //string variable to store the error
                string Error = "";
                //create some test data to pass to the method
                string Size = "";
                Size = Size.PadRight(500, '4'); 
                //invoke the method
                Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
                //test to see if the result is true
                Assert.AreNotEqual(Error, "");
            }

        /****** CATEGORY *******/

        [TestMethod]
        public void CategoryMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Category = "";
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CategoryMin()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Category = "A"; //valid
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CategoryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Category = "AB"; //valid
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CategoryMaxMinOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Category = "";
            Category = Category.PadRight(49, 'A'); //valid
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CategoryMax()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Category = "";
            Category = Category.PadRight(50, 'A'); //valid
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CategoryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Category = "";
            Category = Category.PadRight(51, 'A'); //valid
            //invoke the method
                Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CategoryMid()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Category = "";
            Category = Category.PadRight(25, 'A'); //valid
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CategoryExtremeMax()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Category = "";
            Category = Category.PadRight(500, 'A'); //valid
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }

        /****** PRICE *******/
        [TestMethod]
        public void PriceNegative()
        {
            clsProduct AnProduct = new clsProduct();
            string TestPrice = "-1"; //override the defoult price
            string Error = AnProduct.Valid(Name,Size, Category, TestPrice, ReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsProduct AnProduct = new clsProduct();
            string TestPrice = "0"; //override the defoult price
            string Error = AnProduct.Valid(Name, Size, Category, TestPrice, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsProduct AnProduct = new clsProduct();
            string TestPrice = "0.01"; //override the defoult price
            string Error = AnProduct.Valid(Name, Size, Category, TestPrice, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            clsProduct AnProduct = new clsProduct();
            string TestPrice = "9999.99"; //override the defoult price
            string Error = AnProduct.Valid(Name, Size, Category, TestPrice, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsProduct AnProduct = new clsProduct();
            string TestPrice = "10000.01"; //override the defoult price
            string Error = AnProduct.Valid(Name, Size, Category, TestPrice, ReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            clsProduct AnProduct = new clsProduct();
            string TestPrice = "5000"; //override the defoult price
            string Error = AnProduct.Valid(Name, Size, Category, TestPrice, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceExtremeMax()
        {
            clsProduct AnProduct = new clsProduct();
            string TestPrice = "9999999999.99"; //override the defoult price, unrealisticly high price
            string Error = AnProduct.Valid(Name, Size, Category, TestPrice, ReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceInvalidData()
        {
            clsProduct AnProduct = new clsProduct();
            string TestPrice = "Ten pounds"; //override the defoult price
            string Error = AnProduct.Valid(Name, Size, Category, TestPrice, ReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }

        /****** RELEASED DATE *******/
        [TestMethod]
        public void ReleasedDateExtremeMin()
        {
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the data to date minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date to a string
            string TestReleasedDate = TestDate.ToString();
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, TestReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateMinLessOne()
        {
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the data to date minus 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date to a string
            string TestReleasedDate = TestDate.ToString();
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, TestReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ReleasedDateMin()
        {
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date to a string
            string TestReleasedDate = TestDate.ToString();
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, TestReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ReleasedDateMinPlusOne()
        {
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the data to date plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date to a string
            string TestReleasedDate = TestDate.ToString("dd/MM/yyyy");
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, TestReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ReleasedDateExtremeMax()
        {
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the data to date plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date to a string
            string TestReleasedDate = TestDate.ToString();
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, TestReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ReleasedDateInvalidData()
        {
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string TestReleasedDate = "Not a date"; //invalid date
            //invoke the method
            Error = AnProduct.Valid(Name, Size, Category, Price, TestReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }


        }
    }





