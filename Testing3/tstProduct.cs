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
        //create some test data to pass to the method
        string Size = "UK 4";
        string Name = "Boots";
        string Category = "Kids";
        string Price = "24.99";
        string InStock = "true";
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
            Int32 ProductID = 5;
            //invoke the method
            Found = AnProduct.Find(ProductID);
            //check the product ID
            if (AnProduct.ProductID != 5)
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
            Int32 ProductID = 5;
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
            Int32 ProductID = 5;
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
            Int32 ProductID = 5;
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
            Int32 ProductID = 5;
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
            Int32 ProductID = 5;
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
            Int32 ProductID = 5;
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
            Error = AnProduct.Valid(Name, Price, InStock, Category, Size, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
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
            string Size = ""; //less than 2 characters
            //invoke the method
            Error = AnProduct.Valid(Size, Name, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SizeNoMin()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Size = "UK 4"; //valid size
            //invoke the method
            Error = AnProduct.Valid(Size, Name, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeNoMax()
        {
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Size = "UK 4"; //valid size
            //invoke the method
            Error = AnProduct.Valid(Size, Name, Category, Price, ReleasedDate);
            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeNoMinPlusOne()
        {
            clsProduct AnProduct = new clsProduct();
            //string variable to store the error
            string Error = "";
            //create some test data to pass to the method
            string Size = "UK 4"; //valid size
            //invoke the method
            Error = AnProduct.Valid(Size, Name, Category, Price, ReleasedDate);

        }
        [TestMethod]
        public void SizeNoMaxPlusOne() {
            { clsProduct AnProduct = new clsProduct();
                //string variable to store the error
                string Error = "";
                //create some test data to pass to the method
                string Size = "UK 4"; //valid size should fail
                //invoke the method
                Error = AnProduct.Valid(Size, Name, Category, Price, ReleasedDate);
                //test to see if the result is true
                Assert.AreEqual(Error, "");
            }

          











        }
    }

}



