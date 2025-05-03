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
            //create an instance
            clsProduct Anroduct = new clsProduct();

            //test that it exists
            Assert.IsNotNull(Anroduct);

        }
    }
}
