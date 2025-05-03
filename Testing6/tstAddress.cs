using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsAddress AnAddress = new clsAddress();
            Assert.IsNotNull(AnAddress);
        }
    }
}
