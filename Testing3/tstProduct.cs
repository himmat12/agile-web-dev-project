using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsProduct AnProduct = new clsProduct();
            //test that it exists
            Assert.IsNotNull(AnProduct);

        }
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
        public void ImageURLPropertyOK()
        {
            //create an instance of the class
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            string TestData = "http://example.com/image.jpg";
            //assign the data to the property
            AnProduct.ImageURL = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.ImageURL, TestData);
        }
    }
}


