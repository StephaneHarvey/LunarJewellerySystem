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
    }
}