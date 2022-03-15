using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Jewellery_System_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerFirstName = "Liam";
            TestItem.CustomerSurname = "Richard";
            TestItem.CustomerAddress = "23 Rock Rd";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerEmail = "Liam@hotmail.com";
            TestItem.CustomerMobileNumber = "07788745621";
            TestItem.CustomerPostCode = "LE6 4ER";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomersList, TestList);

        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerFirstName = "Liam";
            TestItem.CustomerSurname = "Richard";
            TestItem.CustomerAddress = "23 Rock Rd";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerEmail = "Liam@hotmail.com";
            TestItem.CustomerMobileNumber = "07788745621";
            TestItem.CustomerPostCode = "LE6 4ER";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerFirstName = "aaaa";
            TestItem.CustomerSurname = "aaaa";
            TestItem.CustomerAddress = "26 Rock Rd";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerEmail = "AAlim@hotmail.com";
            TestItem.CustomerMobileNumber = "07098745621";
            TestItem.CustomerPostCode = "LE2 8BR";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 2;
            TestItem.CustomerFirstName = "Afseen";
            TestItem.CustomerSurname = "Alim";
            TestItem.CustomerAddress = "26 Rock Rd";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerEmail = "AAlim@hotmail.com";
            TestItem.CustomerMobileNumber = "07098745621";
            TestItem.CustomerPostCode = "LE2 8BR";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerFirstName = "Afseen";
            TestItem.CustomerSurname = "Alim";
            TestItem.CustomerAddress = "26 Rock Rd";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerEmail = "AAlim@hotmail.com";
            TestItem.CustomerMobileNumber = "07098745621";
            TestItem.CustomerPostCode = "LE2 8BR";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.CustomerFirstName = "Afseen";
            TestItem.CustomerSurname = "Alim";
            TestItem.CustomerAddress = "26 Rock Rd";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerEmail = "AAlim@hotmail.com";
            TestItem.CustomerMobileNumber = "07098745621";
            TestItem.CustomerPostCode = "LE2 8BR";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //delete the update
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the class containg unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records
            FilteredCustomers.ReportByPostCode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);

        }
        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            //create an instance of the class containg unfiltered results
            //clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records
            FilteredCustomers.ReportByPostCode("XXX XXX");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomers.Count);

        }
        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            //create an instance of the class containg unfiltered results
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a blank string (should return all records
            FilteredCustomers.ReportByPostCode("LE4 2WW");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 1)
            {
                //check that the first record is ID36
                if (FilteredCustomers.CustomersList[0].CustomerID != 1)
                {
                    OK = false;
                }

                //check that the first record is ID 37
                if (FilteredCustomers.CustomersList[1].CustomerID != 1)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsFalse(OK);
        }
    }
}



