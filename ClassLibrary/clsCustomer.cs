using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public class clsCustomer
    {
        //customerID private member variable
        private Int32 mCustomerID;
        //CustomerID public property
        public int CustomerID
        {
            get
            {
                //this line of code send data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }

        //CustomerDOB public property
        private DateTime mCustomerDOB;
        public DateTime CustomerDOB
        {
            get
            {
                //this line of code send data out of the property
                return mCustomerDOB;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerDOB = value;
            }
        }
        private Boolean mActive;
        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //private data member for CustomerFirstName
        private string mCustomerFirstName;
        //public property for house no
        public string CustomerFirstName
        {
            get
            {
                //return private data
                return mCustomerFirstName;
            }
            set
            {
                //set the private data
                mCustomerFirstName = value;
            }
        }
        //private data member for CustomerFirstName
        private string mCustomerEmail;
        //public property for house no
        public string CustomerEmail
        {
            get
            {
                //return private data
                return mCustomerEmail;
            }
            set
            {
                //set the private data
                mCustomerEmail = value;
            }
        }
        //private data member for CustomerFirstName
        private string mCustomerPostCode;
        //public property for house no
        public string CustomerPostCode
        {
            get
            {
                //return private data
                return mCustomerPostCode;
            }
            set
            {
                //set the private data
                mCustomerPostCode = value;
            }
        }
        //private data member for CustomerSurname
        private string mCustomerSurname;
        //public property for CustomerSurname
        public string CustomerSurname
        {
            get
            {
                //return private data
                return mCustomerSurname;
            }
            set
            {
                //set the private data
                mCustomerSurname = value;
            }
        }
        //private data member for CustomerMobileNumber
        private string mCustomerMobileNumber;
        //public property for CustomerMobileNumber
        public string CustomerMobileNumber
        {
            get
            {
                //return private data
                return mCustomerMobileNumber;
            }
            set
            {
                //set the private data
                mCustomerMobileNumber = value;
            }
        }
        //private data member for CustomerAddress
        private string mCustomerAddress;
        //public property for CustomerAddress
        public string CustomerAddress
        {
            get
            {
                //return private data
                return mCustomerAddress;
            }
            set
            {
                //set the private data
                mCustomerAddress = value;
            }
        }

        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer ID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerSurname = Convert.ToString(DB.DataTable.Rows[0]["CustomerSurname"]);
                mCustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerMobileNumber = Convert.ToString(DB.DataTable.Rows[0]["CustomerMobileNumber"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPostCode = Convert.ToString(DB.DataTable.Rows[0]["CustomerPostCode"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string customerFirstName, string customerSurname, string customerMobileNumber, string customerDOB, string customerAddress, string customerEmail, string customerPostCode)
        {

                //create a string variable to store the error
                String Error = "";
                //create a temporary variable to store date values
                DateTime DateTemp;

                //if the customers FirstName is blank
                if (customerFirstName.Length == 0)
                {
                    //record the error
                    Error = Error + "The Customer's FirstName may not be blank :";
                }
            //if the customers FirstName More than 20
            if (customerFirstName.Length > 20)
                {
                    //record the error
                    Error = Error + "The Customer's FirstName must be less than 20 characters :";
                }
            //if the customers Surname is blank
            if (customerSurname.Length == 0)
            {
                //record the error
                Error = Error + "The Customer's Surname may not be blank :";
            }
            //if the customers Surname is More than 50
            if (customerSurname.Length > 50)
            {
                //record the error
                Error = Error + "The Customer's Surname must be less than 50 characters :";
            }
            //if the customers Address is blank
            if (customerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Customer's Address may not be blank :";
            }
            //if the customers Surname is More than 50
            if (customerAddress.Length > 50)
            {
                //record the error
                Error = Error + "The Customer's Address must be less than 50 characters :";
            }
            //if the customers PostCode is blank
            if (customerPostCode.Length == 0)
            {
                //record the error
                Error = Error + "The Customer's PostCode may not be blank :";
            }
            //if the customers PostCode is more than 7
            if (customerPostCode.Length > 7)
            {
                //record the error
                Error = Error + "The Customer's PostCode must be less than 7 characters :";
            }
            //if the customers Email is blank
            if (customerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The Customer's Email may not be blank :";
            }
            //if the customers Email is more than 50
            if (customerEmail.Length > 50)
            {
                //record the error
                Error = Error + "The Customer's Email must be less than 50 characters :";
            }
            //if the customers MobileNumber is blank
            if (customerMobileNumber.Length == 0)
            {
                // record the error
                Error = Error + "The Customer's Mobile Number may not be blank :";
            }
            //if the customers MobileNumber is more than 11
            if (customerMobileNumber.Length > 11)
            {
                //record the error
                Error = Error + "The Customer's Mobile Number must be less than 11 characters :";
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(customerDOB);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    // record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the PostCode blank
            if (customerPostCode.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the PostCode is more than 7
            if (customerPostCode.Length > 7)
            {
                //record the error
                Error = Error + "The post code must be less than 7 characters : ";
            }
            //return any error messages
            return Error;
            }
        }

    public class clsStock
    {
    }
}













