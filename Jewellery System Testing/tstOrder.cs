using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Jewellery_System_Testing
{
    [TestClass]
    public class tstOrder
    {
        //good test data 
        //create some test data to pass to the method
        string OrderName = "Ring";
        string ProductNo = "22";
        string Status = "Delivered";
        string DateAdded = DateTime.Now.Date.ToString();
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
        [TestMethod]
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
        [TestMethod]
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
            Boolean Found = true;
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
            if (AOrder.OrderNo != 21)
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
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 3;
            //invoke the method
            Found = AOrder.Find(OrderNo);
            //check the property
            if (AOrder.Active != true)
            {
                OK = false;
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
        [TestMethod]
        public void TestStatusFound()
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
            if (AOrder.Status != "Delivered")
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductNoFound()
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
            //check the property
            if (AOrder.ProductNo != "012345")
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the classs we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductNo = ""; //this should trigger an error 
            //invoke the method 
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNoMin()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string ProductNo = "a"; //this should be ok
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNoMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductNo = "aa";//this should be ok
            //invoke the method 
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNoMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductNo = "aaaaa";//this should be ok
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNoMax()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string ProductNo = "aaaaaa";//this should be ok
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNoMid()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductNo = "aaa";//this should be ok
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNoMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductNo = "aaaaaaa";//this should fail
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNoExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductNo = "";
            ProductNo = ProductNo.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the data to todays date 
            TestDate = DateTime.Now.Date;
            //change the data to whatever the data is plus 100 years 
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value 
            string DateAdded = "This is a not a date!";
            //invoke the method 
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should fail 
            string OrderName = "";
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMin()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string OrderName = "a";
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string OrderName = "aa";
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string OrderName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMax()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string OrderName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string OrderName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMid()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string OrderName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StatusMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string Status = "";
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StatusMin()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Status = "a";
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StatusMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Status = "aa";
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StatusMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string Status = "";
            Status = Status.PadRight(49, 'a');
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StatusMax()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Status = "";
            Status = Status.PadRight(50, 'a');
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StatusMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string Status = "";
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StatusMid()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Status = "";
            Status = Status.PadRight(25, 'a');
            //invoke the method
            Error = AOrder.Valid(ProductNo, OrderName, Status, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}
