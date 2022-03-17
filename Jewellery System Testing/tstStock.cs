using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jewellery_System_Testing
{
    [TestClass]
    public class tstStock
    {
        //[TestMethod]
        //public void ActivePropertyOK()
        //  {
        //create an instancer of the class we want to create
        //  clsStock AnStockID = new clsStock();
        //create some test data to assign to the property 
        //  Boolean TestData = true;
        //assign the data to the property 
        //  AnStockID.Active = TestData;
        //test to see that the two values are the same 
        //   Assert.AreEqual(AnStockID.Active, TestData);

        //  }

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
    }
}
