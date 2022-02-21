using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jewellery_System_Testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it existss
            Assert.IsNotNull(AStaff);
        }
    }

    class clsStaff
    {

    }
}
