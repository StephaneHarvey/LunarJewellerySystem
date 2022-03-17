using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jewellery_System_Testing
{

    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //test to see that is exists 
            Assert.IsNotNull(AnStock);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Bollean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 StockID = 1;
            //invoke the method 
            Found = AnStock.Find(StockID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStockIDFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variabke to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StockID = 1;
            //invoke the method 
            Found = AnStock.Find(StockID);
            //check the address no
            if (AnStock.StockID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStockDateFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            //boolean variabke to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StockID = 1;
            //invoke the method 
            Found = AnStock.Find(StockID);
            //check the address no
            if (AnStock.StockDate != Convert.ToDateTime("14/01/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStockItemFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            Boolean Found = true;
            //boolean variable to record is data is ok (assume it is)
            Boolean OK = false;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method 
            Found = AnStock.Find(StockID);
            //check the address no
            if (AnStock.StockItem != "Mens SunGlasses")
            {
                OK = true;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        public void TestStockQuantityFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variabke to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StockID = 1;
            //invoke the method 
            Found = AnStock.Find(StockID);
            //check the address no
            if (AnStock.StockQuantity != 50)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnStock = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = true;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = AnStock.Find(StockID);
            //check the property
            if (AnStock.Active != true)
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instancer of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            AnStock.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.Active, TestData);

        }
        [TestMethod]
        public void StockDatePropertyOK()
        {
            //create an instancer of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AnStock.StockDate = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.StockDate, TestData);

        }

        public void StockQuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.StockQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StockQuantity, TestData);
        }
        public void StockIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.StockID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StockID, TestData);

        }
        [TestMethod]
        public void StockItemPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Mens SunGlasses";
            //assign the data to the property
            AnStock.StockItem = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StockItem, TestData);
        }

    }
}
