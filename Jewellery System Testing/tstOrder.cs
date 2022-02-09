using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jewellery_System_Testing
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //test to see that is exists 
            Assert.IsNotNull(AnOrder);
        }
    }

    class clsOrder
    {
    }
}
