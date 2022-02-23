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
            //create an instance of the class that we want to create
            clsOrder AOrder = new clsOrder();
            //test to see that is exists 
            Assert.IsNotNull(AOrder);
        }
        [TestMethod]
        public void OrderNameOK()
        {
            //create an instnace of the class that we want to create 
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to property 
            string TestData = "Cross Ring";
            //assign the data to the property 
            AOrder.OrderName = TestData;
            //test to see that is exists 
            Assert.AreEqual(AOrder.OrderName, TestData);
        }
        [TestMethod]
        public void OrderNoOK()
        {
            //create an instance of the class
            clsOrder AOrder = new clsOrder();
            //create test data to assign to property 
            string TestData = "012345";
            //assign the data to the property
            AOrder.OrderNo = TestData;
            //test to see that it exist 
            Assert.AreEqual(AOrder.OrderNo, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 21;
            //invoke the method
            Found = AOrder.Find(ProductNo);
            //check the orderno
            if (AOrder.ProductNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method 
            Found = AOrder.Find(OrderNo);
            //check the property
            if (AOrder.DateAdded != Convert.ToDateTime("16/08/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
    }
}
