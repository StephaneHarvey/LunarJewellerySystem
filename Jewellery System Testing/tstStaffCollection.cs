using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Jewellery_System_Testing
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class that we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class that we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //create itiem for test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 6;
            TestItem.StaffFirstName = "Gwenyth";
            TestItem.StaffLastName = "Paltrow";
            TestItem.StaffAddress = "67 Cross Close, LE4 5RG";
            TestItem.StaffContactNo = "07763890134";
            TestItem.StaffDOB = DateTime.Now.Date;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class that we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create test data to assign to property
            clsStaff TestStaff = new clsStaff();
            //set its properties
            TestStaff.StaffID = 6;
            TestStaff.StaffFirstName = "Gwenyth";
            TestStaff.StaffLastName = "Paltrow";
            TestStaff.StaffAddress = "67 Cross Close, LE4 5RG";
            TestStaff.StaffContactNo = "07763890134";
            TestStaff.StaffDOB = DateTime.Now.Date;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //Test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class that we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //create itiem for test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 6;
            TestItem.StaffFirstName = "Gwenyth";
            TestItem.StaffLastName = "Paltrow";
            TestItem.StaffAddress = "67 Cross Close, LE4 5RG";
            TestItem.StaffContactNo = "07763890134";
            TestItem.StaffDOB = DateTime.Now.Date;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class that we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to stopre pk
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 6;
            TestItem.StaffFirstName = "Sam";
            TestItem.StaffLastName = "Smith";
            TestItem.StaffAddress = "628 Crack Close, LE27 2JG";
            TestItem.StaffContactNo = "07912600134";
            TestItem.StaffDOB = Convert.ToDateTime("09/04/2020");
            //set ThisStaff to test data
            AllStaff.ThisStaff = TestItem;
            //add record
            PrimaryKey = AllStaff.Add();
            //set the pk of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class that we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to stopre pk
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 6;
            TestItem.StaffFirstName = "Sam";
            TestItem.StaffLastName = "Smith";
            TestItem.StaffAddress = "628 Crack Close, LE27 2JG";
            TestItem.StaffContactNo = "07912600134";
            TestItem.StaffDOB = Convert.ToDateTime("09/04/2020");
            //set ThisStaff to test data
            AllStaff.ThisStaff = TestItem;
            //add record
            PrimaryKey = AllStaff.Add();
            //set the pk of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //Test to see that the record wasnt found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class that we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store pk
            Int32 PrimaryKey = 0;
            //set its properties
            
            TestItem.StaffFirstName = "Sam";
            TestItem.StaffLastName = "Smith";
            TestItem.StaffAddress = "628 Crack Close, LE27 2JG";
            TestItem.StaffContactNo = "07912600134";
            TestItem.StaffDOB = Convert.ToDateTime("09/04/2020");
            //set ThisStaff to test data
            AllStaff.ThisStaff = TestItem;
            //add record
            PrimaryKey = AllStaff.Add();
            //set the pk of the test data
            TestItem.StaffID = PrimaryKey;
            //modify the test data
            //TestItem.StaffID = 2;
            TestItem.StaffFirstName = "Samuel";
            TestItem.StaffLastName = "Smithereens";
            TestItem.StaffAddress = "628 Crackhead Close, LE27 2JG";
            TestItem.StaffContactNo = "07912609134";
            TestItem.StaffDOB = DateTime.Now.Date;
            //set recors based on new test data
            AllStaff.ThisStaff = TestItem;
            //update record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //Test to see that ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void ReportByStaffFirstNameMethodOK()
        {
            //create an instance of the class that we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply blank string (should return all records)
            FilteredStaff.ReportByStaffFirstName("");
            //test to see that 2 values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);

        }

        [TestMethod]
        public void ReportByStaffFirstNameNoneFound()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply blank string that doesnt exist 
            FilteredStaff.ReportByStaffFirstName("xxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);

        }

        [TestMethod]
        public void ReportByStaffFirstNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a first name that doesnt exist
            FilteredStaff.ReportByStaffFirstName("Chloe");
            //check that the correct number of records found
            if (FilteredStaff.Count == 2)
            {
                if (FilteredStaff.StaffList[0].StaffID != 3)
                {
                    OK = false;
                }
                if (FilteredStaff.StaffList[1].StaffID != 61)
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
