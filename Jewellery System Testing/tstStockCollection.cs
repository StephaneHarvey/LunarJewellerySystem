using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Jewellery_System_Testing
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instace of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see is it exists
            Assert.IsNotNull(AllStocks);
        }
        [TestMethod]
        public void StockListOK()
        {
            //create an instande of the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be alist of objets 
            List<clsStock> TestList = new List<clsStock>();
            //add item to the lsit 
            //create item of the test data 
            clsStock TestItem = new clsStock();
            //set its propeties 
            TestItem.Active = true;
            TestItem.StockID = 1;
            TestItem.StockQuantity = 50;
            TestItem.StockItem = "Mens SunGlasses";
            TestItem.StockDate = DateTime.Now.Date;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property ]
            AllStocks.StockList = TestList;
            //test to see that two values are the same 
            Assert.AreEqual(AllStocks.StockList, TestList);

        }
        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            // create an istance for the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data  assign to the property 
            Int32 SomeCount = 0;
            //assign the data to the property
            AllStocks.Count = SomeCount;
            //test to see that 2 values are the same
            Assert.AreEqual(AllStocks.Count, SomeCount);

        }
    }

}
