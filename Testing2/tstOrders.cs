using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
        public class tstOrder
        {
            [TestMethod]
            public void InstanceOK()
            {
                //create instance of class
                clsOrders AnOrder = new clsOrders();
                //does it exist
                Assert.IsNotNull(AnOrder);
            }

        }
    }
