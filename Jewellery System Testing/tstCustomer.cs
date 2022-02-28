using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jewellery_System_Testing
{
    [TestClass]
    public class tstCustomer
    {

        //good test data
        //create some test data to pass to the method
        string CustomerFirstName = "Liam";
        string CustomerSurname = "Richard";
        string CustomerMobileNumber = "07788745621";
        string CustomerDOB = DateTime.Now.Date.ToString();
        string CustomerAddress = "23 Rock Rd";
        string CustomerPostCode = "LE6 4ER";
        string CustomerEmail = "Liam@hotmail.com";
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
            Int32 TestData = 3;
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
            string TestData = "Liam";
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
            string TestData = "Richard";
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
            string TestData = "23 Rock Road";
            //assign the data to the property
            ACustomer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }
        [TestMethod]
        public void CustomerPostCodeOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE6 4ER";
            //assign the data to the property
            ACustomer.CustomerPostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerPostCode, TestData);
        }
        [TestMethod]
        public void CustomerMobileNumberOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "07788745621";
            //assign the data to the property
            ACustomer.CustomerMobileNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerMobileNumber, TestData);
        }
        [TestMethod]
        public void CustomerEmailOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Liam@hotmail.com";
            //assign the data to the property
            ACustomer.CustomerEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }
        [TestMethod]
        public void CustomerIDFindOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = true;
            //create some tesr data to use with the method
            Int32 CustomerID = 1;
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
            Boolean Found = true;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some tesr data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.CustomerID != 3)
            {
                OK = true;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCustomerDOBFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = true;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some tesr data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.CustomerDOB != Convert.ToDateTime("25/03/2002"))
            {
                OK = true;
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
            Boolean Found = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
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
            Boolean Found = true;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerFirstName != "Liam")
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerMobileNumberFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = true;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerMobileNumber != "07788745621")
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = true;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerEmail != "Liam@hotmail.com")
            {
                OK = true;
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
            Boolean Found = true;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerSurname != "Richard")
            {
                OK = true;
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
            Boolean Found = true;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerAddress != "23 Rock Rd")
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
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = true;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Active != true)
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerFirstNameMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string CustomerFirstName = "a"; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerFirstNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerFirstName = ""; //this should trigger an error
                                           //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string CustomerFirstName = "AA"; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerFirstNameMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string CustomerFirstName = "AAAAAAAAAAAAAAAAAAAA"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should fail 
            string CustomerFirstName = "AAAAAAAAAAAAAAAAAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string CustomerFirstName = "AAAAAAAAAAAAAAAAAAA"; //this should trigger an error
                                                              //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string CustomerFirstName = "AAAAAAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(150, 'a');
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerSurnameMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //Test data to pass to the method 
            string CustomerSurname = "A";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerSurnameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //Test data to pass to the method 
            string CustomerSurname = "";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //Test data to pass to the method 
            string CustomerSurname = "AA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerSurnameMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method  
            string CustomerSurname = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerSurnameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method  
            string CustomerSurname = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerSurnameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerSurname = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerSurnameMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerSurname = "AAAAAAAAAAAAAAAAAAAAAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerSurnameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string CustomerSurname = "";
            CustomerSurname = CustomerSurname.PadRight(150, 'A');
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerAddress = "A"; //this should trigger an error
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerAddress = "";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerAddress = "AA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //Test data to pass to the method 
            string CustomerAddress = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerAddress = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //Test data to pass to the method 
            string CustomerAddress = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"; //this should fail
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //Test data to pass to the method 
            string CustomerAddress = "AAAAAAAAAAAAAAAAAAAAAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this test should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(150, 'A');
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //Test data to pass to the method 
            string CustomerEmail = "A";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //Test data to pass to the method 
            string CustomerEmail = "";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerEmail = "AA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerEmail = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerEmail = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerEmail = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this test should pass
            string CustomerEmail = "AAAAAAAAAAAAAAAAAAAAAAAAA";
            CustomerEmail = CustomerEmail.PadRight(60, 'A');
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this test should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(200, 'c');
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerPostCode = "A";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerPostCode = "AA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerPostCode = "";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerPostCode = "AAAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerPostCode = "AAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerPostCode = "AAAAAAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerPostCode = "AAAA";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //tests should pass 
            string CustomerPostCode = "";
            CustomerPostCode = CustomerPostCode.PadRight(50, 'A');
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerMobileNumberMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method  
            string CustomerMobileNumber = "0";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerMobileNumberMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerMobileNumber = "";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerMobileNumberMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerMobileNumber = "01";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerMobileNumberMaxBoundary()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerMobileNumber = "01234567891";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerMobileNumberMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerMobileNumber = "0123456789";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerMobileNumberMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method 
            string CustomerMobileNumber = "0123445678910";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerMobileNumberMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //test data to pass to the method  
            string CustomerMobileNumber = "0123445";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerMobileNumberExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this test should pass 
            string CustomerMobileNumber = "";
            CustomerMobileNumber = CustomerMobileNumber.PadRight(100, '0');
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthInvalidData()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //string the Date Of Birth to a non date value 
            string CustomerDOB = "this is not a date!";
            //invoke the method 
            Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerMobileNumber, CustomerDOB, CustomerAddress, CustomerEmail, CustomerPostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
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
    }
}






