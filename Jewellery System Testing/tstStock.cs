using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jewellery_System_Testing
{

    [TestClass]
    public class tstStock
    {
        //good test data 
        //create some test data to pass to the method 
        string StockItem = "Mens SunGlasses";
        //string StockQuantity = "50";
        string StockDate = DateTime.Now.Date.ToString();

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
            Boolean Found = true;
            //create some test data to use with the method 
            Int32 StockID = 1;
            //invoke the method 
            Found = AnStock.Find(StockID);
            //test to see if the result is true
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void TestStockIDFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search 
            Boolean Found = true;
            //boolean variabke to record if data is OK (assume it is)
            Boolean OK = false;
            //create some test data to use with the method 
            Int32 StockID = 1;
            //invoke the method 
            Found = AnStock.Find(StockID);
            //check the address no
            if (AnStock.StockID != 1)
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStockDateFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            Boolean Found = true;
            //boolean variabke to record if data is OK (assume it is)
            Boolean OK = false;
            //create some test data to use with the method 
            Int32 StockID = 1;
            //invoke the method 
            Found = AnStock.Find(StockID);
            //check the address no
            if (AnStock.StockDate != Convert.ToDateTime("14/01/2020"))
            {
                OK = true;
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
        [TestMethod]
        public void TestStockQuantityFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search 
            Boolean Found = true;
            //boolean variabke to record if data is OK (assume it is)
            Boolean OK = false;
            //create some test data to use with the method 
            Int32 StockID = 1;
            //invoke the method 
            Found = AnStock.Find(StockID);
            //check the address no
            if (AnStock.StockQuantity != 50)
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStock.Valid(StockItem,StockDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");


        }
        public void StockItemMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockItem = "x"; //this should be ok
             //invoke the method
            Error = AnStock.Valid(StockItem, StockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockItemMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockItem = "xx"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(StockItem, StockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockItemMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockItem = "xxxxxxxxxxxxxxxxxxx"; //this should be ok
            Error = AnStock.Valid(StockItem, StockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockItemMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockItem = "xxxxxxxxxxxxxxxxxxxx"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(StockItem, StockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockItemMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockItem = "xxxxxxxxxxxxxxxxxxxxx"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(StockItem, StockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockItemMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockItem = ""; //this should be ok
            Error = AnStock.Valid(StockItem, StockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockItemMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockItem = "xxxxxxxxxx"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(StockItem, StockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockItemExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockItem = ""; //this should be ok
            StockItem = StockItem.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnStock.Valid(StockItem, StockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string StockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(StockItem, StockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string StockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(StockItem, StockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockDateMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(StockItem, StockDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string StockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(StockItem, StockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string StockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(StockItem, StockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instace of the class we want to create 
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string StockItem = "Mens SunGlasses";
            //set the DateAdded to a non date value 
            string StockDate = "this is not a date!";
            //invoke the method
            Error = AnStock.Valid(StockItem, StockDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
