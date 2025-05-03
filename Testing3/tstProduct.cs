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
    }
}
