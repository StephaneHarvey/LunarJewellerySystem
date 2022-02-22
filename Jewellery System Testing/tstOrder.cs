using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

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
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            AnOrder.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AnOrder.DateAdded = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }
        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data assign to the property 
            Int32 TestData = 1;
            //assign the data the property 
            AnOrder.OrderNo = TestData;
            //test to see the two values are the same 
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }
        [TestMethod]
        public void ProductNoPropertyOK()
        {
            //create an instacne of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.ProductNo = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.ProductNo, TestData);
        }
        [TestMethod]
        public void StatusNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property 
            string TestData = "21b";
            AnOrder.StatusNo = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.StatusNo, TestData);
        }
        [TestMethod]
        public void OrderNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property 
            string TestData = "LE1 4AB";
            //assign the data to the property 
            AnOrder.OrderName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.OrderName, TestData);
        }
        [TestMethod]
        public void ProductTypeOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Some Product";
            //assign the data to the property 
            AnOrder.ProductType = TestData;
            //test to seee that the two values are the same 
            Assert.AreEqual(AnOrder.ProductType, TestData);
        }
        [TestMethod]
        public void ProductOK()
        {
            //create an instace of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property 
            AnOrder.Product = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Product, TestData);
        }


    }

    class clsOrder
    {
        public bool Active { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public int OrderNo { get; internal set; }
        public int ProductNo { get; internal set; }
        public string StatusNo { get; internal set; }
        public string OrderName { get; internal set; }
        public string ProductType { get; internal set; }
        public string Product { get; internal set; }
    }
}
