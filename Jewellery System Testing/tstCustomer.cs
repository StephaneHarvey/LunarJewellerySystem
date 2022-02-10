using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jewellery_System_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {

            //create an instance of the class we want to createe
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.Active = TestData;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Active, TestData);
        }
        public void CustomerDOBOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.CustomerDOB = TestData;
            //test to see that it exists
            Assert.AreEqual(ACustomer.CustomerDOB, TestData);
        }
        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }
        [TestMethod]
        public void CustomerFirstNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Jack";
            //assign the data to the property
            ACustomer.CustomerFirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerFirstName, TestData);
        }
        [TestMethod]
        public void CustomerSurnameOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Williams";
            //assign the data to the property
            ACustomer.CustomerSurname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerSurname, TestData);
        }
        [TestMethod]
        public void CustomerAddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "123 Rock Road, LE1 2RT";
            //assign the data to the property
            ACustomer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }
        [TestMethod]
        public void CustomerIDFindOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some tesr data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some tesr data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.CustomerID != 2)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some tesr data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.CustomerDOB != Convert.ToDateTime("04/02/2000"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerFirstName != "Jack")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerSurnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerSurname != "William")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerAddress != "34 Tree Road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Active != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }

}






