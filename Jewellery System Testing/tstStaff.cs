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
            string TestData = "67 Cross Close";           
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

        //[TestMethod]
        //public void StaffDOBPropertyOK()
        //{
        //    //create an instance of the class 
        //    clsStaff AStaff = new clsStaff();
        //    //create test data to assign to property
        //    DateTime TestData = "07763890134";
        //    //assign the data to the property
        //    AStaff.StaffDOB = TestData;
        //    //test to see that it exists
        //    Assert.AreEqual(AStaff.StaffContactNo, TestData);
        //}

        [TestMethod]
        public void StaffFirstNamePropertyOK()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to property
            string TestData = "Chandler";
            //assign the data to the property
            AStaff.StaffFirstName = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.StaffFirstName, TestData);
        }

        [TestMethod]
        public void StaffIDOK()
        {
            //create an instance of the class that we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to property
            Int32 TestData = 1;
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
            Int32 StaffID = 2618936;
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
            Int32 StaffID = 2618936;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check staffID 
            if (AStaff.StaffID != 2618936)
            {
                OK = false;
            }
            //test to see if result is true
            Assert.IsTrue(OK);
        }
    }

   
}
