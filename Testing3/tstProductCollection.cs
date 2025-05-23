using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //test to see that it exists
            Assert.IsNotNull(AllProducts);
        }

        [TestMethod]
        public void ProductListOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.InStock = true;
            TestItem.ProductID = 1;
            TestItem.Name = "Test Name";
            TestItem.Price = 9.99m;
            TestItem.Category = "Test Category";
            TestItem.Size = "M";
            TestItem.ReleasedDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ProductList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.InStock = true;
            TestItem.ProductID = 1;
            TestItem.Name = "Test Name";
            TestItem.Price = 9.99m;
            TestItem.Category = "Test Category";
            TestItem.Size = "M";
            TestItem.ReleasedDate = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            clsProduct TestProduct = new clsProduct();
            //set its properties
            TestProduct.InStock = true;
            TestProduct.ProductID = 1;
            TestProduct.Name = "Test Name";
            TestProduct.Price = 9.99m;
            TestProduct.Category = "Test Category";
            TestProduct.Size = "M";
            TestProduct.ReleasedDate = DateTime.Now.Date;
            //assign the data to the property
            AllProducts.ThisProduct = TestProduct;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.InStock = true;
            TestItem.ProductID = 1;
            TestItem.Name = "Test Name";
            TestItem.Price = 9.99m;
            TestItem.Category = "Test Category";
            TestItem.Size = "M";
            TestItem.ReleasedDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }

        //ADD METHOD//

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.InStock = true;
            TestItem.ProductID = 1;
            TestItem.Name = "Test Name";
            TestItem.Price = 9.99m;
            TestItem.Category = "Test Category";
            TestItem.Size = "M";
            TestItem.ReleasedDate = DateTime.Now;
            //set ThisProduct to the test data
            AllProducts.ThisProduct = TestItem;
            //add the recored
            int PrimaryKey = AllProducts.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

        //UPDATE METHOD//

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStock = true;
            TestItem.ProductID = 1;
            TestItem.Name = "Test Name";
            TestItem.Price = 9.99m;
            TestItem.Category = "Test Category";
            TestItem.Size = "M";
            TestItem.ReleasedDate = DateTime.Now;
            //set ThisProduct to the test data
            AllProducts.ThisProduct = TestItem;
            //add the recored
            PrimaryKey = AllProducts.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //modify the test data
            TestItem.InStock = false;
            TestItem.Name = "Test Name 2";
            TestItem.Price = 19.99m;
            TestItem.Category = "Test Category 2";
            TestItem.Size = "L";
            TestItem.ReleasedDate = DateTime.Now;
            //set ThisProduct to the test data
            AllProducts.ThisProduct = TestItem;
            //update the record
            AllProducts.Update();
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

        //DELETE METHOD//

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStock = true;
            TestItem.ProductID = 1;
            TestItem.Name = "Test Name";
            TestItem.Price = 9.99m;
            TestItem.Category = "Test Category";
            TestItem.Size = "M";
            TestItem.ReleasedDate = DateTime.Now;
            //set ThisProduct to the test data
            AllProducts.ThisProduct = TestItem;
            //add the recored
            PrimaryKey = AllProducts.Add();
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //delete the record
            AllProducts.Delete();
            //now find the record again
            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the two values are different
            Assert.IsFalse(Found);
        }
    }
}
