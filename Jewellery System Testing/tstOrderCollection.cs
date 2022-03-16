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
        

    }
}
