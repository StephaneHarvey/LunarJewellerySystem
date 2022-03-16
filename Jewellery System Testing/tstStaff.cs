using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jewellery_System_Testing
{
    [TestClass]
    public class tstStaff
    {
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
    }
}
