using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jewellery_System_Testing
{
    
    [TestClass]
    public class tstStaff
    {

        //good test data
        //create some test data to pass to the method
        string StaffFirstName = "Gwenyth";
        string StaffLastName = "Paltrow";
        string StaffAddress = "67 Cross Close, LE4 5RG";
        string StaffContactNo = "07763890134";
        string StaffDOB ="10/10/1999";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffAddressPropertyOK()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to property
            string TestData = "67 Cross Close, LE4 5RG";
            //assign the data to the property
            AStaff.StaffAddress = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.StaffAddress, TestData);
        }

        [TestMethod]
        public void StaffContactNoPropertyOK()
        {
            //create an instance of the class 
            clsStaff AStaff = new clsStaff();
            //create test data to assign to property
            string TestData = "07763890134";
            //assign the data to the property
            AStaff.StaffContactNo = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.StaffContactNo, TestData);
        }

        [TestMethod]
        public void StaffDOBPropertyOK()
        {
            //create an instance of the class 
            clsStaff AStaff = new clsStaff();
            //create test data to assign to property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.StaffDOB = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.StaffDOB, TestData);
        }

        [TestMethod]
        public void StaffFirstNamePropertyOK()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to property
            string TestData = "Gwenyth";
            //assign the data to the property
            AStaff.StaffFirstName = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.StaffFirstName, TestData);
        }

        [TestMethod]
        public void StaffLastNamePropertyOK()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to property
            string TestData = "Paltrow";
            //assign the data to the property
            AStaff.StaffLastName = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.StaffLastName, TestData);
        }

        [TestMethod]
        public void StaffIDOK()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to property
            Int32 TestData = 6;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create instance of class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //test data to use with the method
            Int32 StaffID = 6;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create instance of class
            clsStaff AStaff = new clsStaff();
            //string variable to store the eroor messages 
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create instance of class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //test data to use with the method
            Int32 StaffID = 6;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check staffID 
            if (AStaff.StaffID != 6)
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffFirstNameFound()
        {
            //create instance of class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //test data to use with the method
            Int32 StaffID = 6;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check staffFirstName 
            if (AStaff.StaffFirstName != "Gwenyth")
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffLastNameFound()
        {
            //create instance of class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //test data to use with the method
            Int32 StaffID = 6;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check stafflasttName 
            if (AStaff.StaffLastName != "Paltrow")
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //test data to use
            Int32 StaffID = 6;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check address 
            if (AStaff.StaffAddress != "67 Cross Close, LE4 5RG")
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffContactNoFound()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //test data to use
            Int32 StaffID = 6;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check contactno 
            if (AStaff.StaffContactNo != "07763890134")
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffDOBFound()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //test data to use
            Int32 StaffID = 6;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check address 
            if (AStaff.StaffDOB != Convert.ToDateTime("10/10/1999"))
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void StaffFirstNameMinLessOne()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //test data
            string StaffFirstName = ""; // should give error
            //invoke the method 
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMin()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            // test data
            string StaffFirstName = "A";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMinPlusOne()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            // test data
            string StaffFirstName = "An";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        public void StaffFirstNameMaxLessOne()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            // test data
            string StaffFirstName = "mynameisanneannawayilikecheeseverymuchindubitably";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMax()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            // test data
            string StaffFirstName = "mynameisanneannawayilikecheesesverymuchindubitably";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMid()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            // test data
            string StaffFirstName = "Iamanneannawayilikecheese";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMaxPlusOne()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            // test data
            string StaffFirstName = "mynamesanneannawayandilikecheeseverymuchindubitably"; // should give error
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameExtremeMax()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            // test data
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(800, 'a'); //should fail
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBExtremeMin()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is -200 years ago
            TestDate = TestDate.AddYears(-200);
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMinLessOne()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 99 years
            TestDate = TestDate.AddYears(-99);
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMin()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMinPlusOne()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 99 years ago
            TestDate = TestDate.AddYears(-101);
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMaxLessOne()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 15 years
            TestDate = TestDate.AddYears(-15);
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMax()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is - 16 years
            TestDate = TestDate.AddYears(-16);
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMaxPlusOne()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is - 17 years
            TestDate = TestDate.AddYears(-17);
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBInvalidData()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            //set DOB to an invalid date value
            string StaffDOB = "The characters used cannot be accepted for 'Date of Birth', please insert a valid date. E.g. 23/09/1974";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMinLessOne()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //test data
            string StaffLastName = ""; // should give error
            //invoke the method 
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMin()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            // test data
            string StaffLastName = "A";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMinPlusOne()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            // test data
            string StaffLastName = "An";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        public void StaffLastNameMaxLessOne()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            // test data
            string StaffLastName = "mynameisanneannawayilikecheeseverymuchindubitably";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMax()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            // test data
            string StaffLastName = "mynameisanneannawayilikecheesesverymuchindubitably";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMid()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            // test data
            string StaffLastName = "Iamanneannawayilikecheese";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMaxPlusOne()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            // test data
            string StaffLastName = "mynamesanneannawayandilikecheeseverymuchindubitably"; // should give error
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameExtremeMax()
        {
            //instance of class
            clsStaff AStaff = new clsStaff();
            //string to store error msg
            String Error = "";
            // test data
            string StaffFirstName = "";
            StaffLastName = StaffFirstName.PadRight(800, 'a'); //should fail
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffContactNo, StaffDOB);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
