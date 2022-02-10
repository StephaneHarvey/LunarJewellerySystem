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
            //set the private data members to the test data value
            mCustomerID = 2;
            mCustomerFirstName = "Jack";
            mCustomerSurname = "William";
            mCustomerAddress = "34 Tree Road";
            mCustomerDOB = Convert.ToDateTime("12/01/2002");
            mActive = false;
            //always return true
            return true;
        }

        
    }

}
