using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsSupplier Supplier = new clsSupplier();
            Assert.IsNotNull(Supplier);
        }
    }
}
