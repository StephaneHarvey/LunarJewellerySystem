using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Jewellery_System_Testing
{
    [TestClass]
    public class tstStockCollection
    {
        public class clsStockCollection
        {
            //private data member for the list
            List<clsStock> mStockList = new List<clsStock>();
            //private data member thisStock
            clsStock mThisStock = new clsStock();


            //public property for ThisStock
            public clsStock ThisStock
            {
                get
                {
                    //return the private data 
                    return mThisStock;
                }
                set
                {
                    //set the private data
                    mThisStock = value;
                }
            }

            public int Add()
            {
                //add a new record to the database based on the values of mThisStock
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedue
                DB.AddParameter("@StockItem", mThisStock.StockItem);
                DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
                DB.AddParameter("@StockDate", mThisStock.StockDate);
                DB.AddParameter("@Active", mThisStock.Active);
                //excute the quary returning the primary key value 
                return DB.Execute("sproc_tblStock_Insert");
            }
            public void Delete()
            {
                //deletes the record pointed to by thisStock
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedue
                DB.AddParameter("@StockID", mThisStock.StockID);
                //excute the stored procedure
                DB.Execute("sproc_tblStock_Delete");

            }
            public void Update()
            {
                //update an existing record based on the values of mThisStock
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedue
                DB.AddParameter("@StockID", mThisStock.StockID);
                DB.AddParameter("@StockItem", mThisStock.StockItem);
                DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
                DB.AddParameter("@StockDate", mThisStock.StockDate);
                DB.AddParameter("@Active", mThisStock.Active);
                //execute the stored procedure
                DB.Execute("sproc_tblStock_Update");
            }


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
                Int32 SomeCount = 2;
                //assign the data to the property
                AllStocks.Count = SomeCount;
                //test to see that 2 values are the same
                Assert.AreEqual(AllStocks.Count, SomeCount);

            }
            [TestMethod]
            public void ThisStockPropertyOK()
            {
                //create an instance of the property we want ot create 
                clsStockCollection AllStocks = new clsStockCollection();
                //create some test data to assign to the property
                clsStock TestStock = new clsStock();
                //set teh properties of the test object 
                TestStock.Active = true;
                TestStock.StockID = 1;
                TestStock.StockQuantity = 50;
                TestStock.StockItem = "Mens SunGlasses";
                TestStock.StockDate = DateTime.Now.Date;
                //assign thr data to the property 
                AllStocks.ThisStock = TestStock;
                //test to see that two values are the same 
                Assert.AreEqual(AllStocks.ThisStock, TestStock);

            }
            [TestMethod]
            public void ListAndCountOK()
            {
                //create an instance of the class we want to create
                clsStockCollection AllStocks = new clsStockCollection();
                //create some test data to assign to the property
                //in this case the data needs to be list of objects
                List<clsStock> TestList = new List<clsStock>();
                //add an item to the list
                //create the item of the test data
                clsStock TestStock = new clsStock();
                //set teh properties of the test object 
                TestStock.Active = true;
                TestStock.StockID = 1;
                TestStock.StockQuantity = 50;
                TestStock.StockItem = "Mens SunGlasses";
                TestStock.StockDate = DateTime.Now.Date;
                //add the item to the test list
                TestList.Add(TestStock);
                //assign the data to the property
                AllStocks.StockList = TestList;
                //test to see that the two values are the same
                Assert.AreEqual(AllStocks.Count, TestList.Count);
            }
            [TestMethod]
            public void TwoRecordPresent()
            {
                clsStockCollection AllStock = new clsStockCollection();
                Assert.AreEqual(AllStock.Count, 2);
            }
            [TestMethod]
            public void CountPropertyOK()
            {
                clsStockCollection AllStock = new clsStockCollection();
                Int32 SomeCount = 2;
                AllStock.Count = SomeCount;
                Assert.AreEqual(AllStock.Count, SomeCount);
            }
            [TestMethod]
            public void AddMethodOK()
            {
                //create an instande of the class we want to create 
                clsStockCollection AllStocks = new clsStockCollection();
                //create item of the test data 
                clsStock TestItem = new clsStock();
                //var to store the primary key 
                Int32 PrimaryKey = 0;
                //set its propeties 
                TestItem.Active = true;
                TestItem.StockID = 1;
                TestItem.StockQuantity = 50;
                TestItem.StockItem = "Mens SunGlasses";
                TestItem.StockDate = DateTime.Now.Date;
                //set ThisStock to the test date 
                AllStocks.ThisStock = TestItem;
                //add the record 
                PrimaryKey = AllStocks.Add();
                //set the primary key the test dATA
                TestItem.StockID = PrimaryKey;
                //find the record
                AllStocks.ThisStock.Find(PrimaryKey);
                //test to see that two values are the same 
                Assert.AreEqual(AllStocks.ThisStock, TestItem);
            }
            [TestMethod]
            public void DeleteMethodOK()
            {
                //create an instande of the class we want to create 
                clsStockCollection AllStocks = new clsStockCollection();
                //create item of the test data 
                clsStock TestItem = new clsStock();
                //var to store the primary key 
                Int32 PrimaryKey = 0;
                //set its propeties 
                TestItem.Active = true;
                TestItem.StockID = 1;
                TestItem.StockQuantity = 50;
                TestItem.StockItem = "Mens SunGlasses";
                TestItem.StockDate = DateTime.Now.Date;
                //set ThisStock to the test date 
                AllStocks.ThisStock = TestItem;
                //add the record 
                PrimaryKey = AllStocks.Add();
                //set the primary key the test data
                TestItem.StockID = PrimaryKey;
                //find the record
                AllStocks.ThisStock.Find(PrimaryKey);
                //delete the record
                AllStocks.Delete();
                //now find the record 
                Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
                //test to see that the record was not found
                Assert.IsFalse(Found);
            }
            [TestMethod]
            public void UpdateMethodOK()
            {
                //create an instande of the class we want to create 
                clsStockCollection AllStocks = new clsStockCollection();
                //create item of the test data 
                clsStock TestItem = new clsStock();
                //var to store the primary key 
                Int32 PrimaryKey = 0;
                //set its propeties 
                TestItem.Active = true;
                TestItem.StockID = 1;
                TestItem.StockQuantity = 50;
                TestItem.StockItem = "Mens SunGlasses";
                TestItem.StockDate = DateTime.Now.Date;
                //set ThisStock to the test date 
                AllStocks.ThisStock = TestItem;
                //add the record 
                PrimaryKey = AllStocks.Add();
                //set the primary key the test data
                TestItem.StockID = PrimaryKey;
                //modify the test data 
                TestItem.Active = false;
                TestItem.StockQuantity = 70;
                TestItem.StockDate = DateTime.Now.Date;
                TestItem.StockItem = "UniSexChains";
                //set teh record based on teh new test data 
                AllStocks.ThisStock = TestItem;
                //update teh record 
                AllStocks.Update();
                //find the record 
                AllStocks.ThisStock.Find(PrimaryKey);
                //test to see ThiStock matches the test data 
                Assert.AreEqual(AllStocks.ThisStock, TestItem);
            }
        }
    }
}



