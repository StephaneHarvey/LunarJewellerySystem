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
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AOrder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrder.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AOrder.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrder.DateAdded, TestData);
        }
        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrder.OrderNo, TestData);
        }
        [TestMethod]
        public void StatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AOrder.Status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrder.Status, TestData);
        }
        public void OrderNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Cross Ring";
            //assign the data to the property
            AOrder.OrderName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrder.OrderName, TestData);
        }
        public void ProductNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "12";
            //assign the data to the property
            AOrder.ProductNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrder.ProductNo, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = true;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //check the orderno
            if (AOrder.OrderNo != 1)
            {
                OK = true;
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
            Boolean Found = true;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 3;
            //invoke the method 
            Found = AOrder.Find(OrderNo);
            //check the property
            if (AOrder.DateAdded != Convert.ToDateTime("16/08/2015"))
            {
                OK = true;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = true;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 3;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //check the property
            if (AOrder.Active != true)
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderNameFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = true;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 3;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //check the property
            if (AOrder.OrderName != "Cross Ring")
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestStatusFound()
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
            if (AOrder.Status != "Delivered")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestProductNoFound()
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
            if (AOrder.ProductNo != "012345")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }
}
