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
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Active = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerFirstName = "Liam";
            TestCustomer.CustomerSurname = "Richard";
            TestCustomer.CustomerAddress = "23 Rock Rd";
            TestCustomer.CustomerDOB = DateTime.Now.Date;
            TestCustomer.CustomerEmail = "Liam@hotmail.com";
            TestCustomer.CustomerMobileNumber = "07788745621";
            TestCustomer.CustomerPostCode = "LE6 4ER";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
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
        
       
        }
    }

