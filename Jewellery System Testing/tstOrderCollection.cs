using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Jewellery_System_Testing
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item of the lsit 
            //cerate the item of test data 
            clsOrder TestItem = new clsOrder();
            //set its properties 
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.Status = "delivered";
            TestItem.OrderName = "Cross Ring";
            TestItem.ProductNo = "123H";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);


        }
        
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of hte class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property 
            clsOrder TestOrders = new clsOrder();
            //sert the properties of the test object
            TestOrders.Active = true;
            TestOrders.OrderNo = 1;
            TestOrders.Status = "delivered";
            TestOrders.OrderName = "Cross Ring";
            TestOrders.ProductNo = "123H";
            TestOrders.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrders;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.ThisOrder, TestOrders);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item of test data 
            //create the item of test data 
            clsOrder TestItem = new clsOrder();
            //set its properties 
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.Status = "delivered";
            TestItem.OrderName = "Cross Ring";
            TestItem.ProductNo = "123H";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data 
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.Status = "delivered";
            TestItem.OrderName = "Cross Ring";
            TestItem.ProductNo = "123H";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisOrder to the test data 
            AllOrders.ThisOrder = TestItem;
            //add the record 
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data 
            TestItem.OrderNo = PrimaryKey;
            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data 
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.Status = "delivered";
            TestItem.OrderName = "Cross Ring";
            TestItem.ProductNo = "123H";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisOrder to the test data 
            AllOrders.ThisOrder = TestItem;
            //add the record 
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data 
            TestItem.OrderNo = PrimaryKey;
            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record 
            AllOrders.Delete();
            //now find the record 
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data 
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.Status = "delivered";
            TestItem.OrderName = "Cross Ring";
            TestItem.ProductNo = "123H";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record 
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data 
            TestItem.OrderNo = PrimaryKey;
            //modify the test data 
            TestItem.Active = false;
            TestItem.OrderNo = 55;
            TestItem.Status = "not delivered";
            TestItem.OrderName = "Fire Ring";
            TestItem.ProductNo = "432S";
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the new test data 
            AllOrders.ThisOrder = TestItem;
            //update the record 
            AllOrders.Update();
            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data 
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }
        [TestMethod]
        public void ReportByProductNoMethodOK()
        {
            //create an instance of the class containing unfiltered results 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data 
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records);
            FilteredOrders.ReportByProductNo("");
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByProductNoNoneFound()
        {
            //create an instance of the filtered data 
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a product no that doesn't exist 
            FilteredOrders.ReportByProductNo("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByProductNoTestDataFound()
        {
            //create an instance of the filtered data 
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to store outcome 
            Boolean OK = true;
            //apply a product no that doesn't exist 
            FilteredOrders.ReportByProductNo("xxx");
            //check that the correct number of records are found 
            if (FilteredOrders.Count == 2)
            {
                //check that the first record is ID 12
                if (FilteredOrders.OrderList[0].OrderNo != 16)
                {
                    OK = false;
                }
                //check that the first record is ID 13
                if (FilteredOrders.OrderList[1].OrderNo != 17)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records 
            Assert.IsTrue(OK);
        }


    }
}
