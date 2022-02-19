using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stroed procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                ACustomer.CustomerSurname = Convert.ToString(DB.DataTable.Rows[Index]["CustomerSurname"]);
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                ACustomer.CustomerPostCode = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPostCode"]);
                ACustomer.CustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDOB"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerMobileNumber = Convert.ToString(DB.DataTable.Rows[Index]["CustomerMobileNumber"]);
                //add the record to the private data member
                mCustomersList.Add(ACustomer);
                //point at the next record
                Index++;


            }
        }
        //private data member for the list
        List<clsCustomer> mCustomersList = new List<clsCustomer>();
        public List<clsCustomer> CustomersList 
        {
            get
            {
                //return the private data
                return mCustomersList;
            }
            set
            {
                //set the private data
                mCustomersList = value;
            }
         }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomersList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsCustomer ThisCustomer { get; set; }
        //public List<clsCustomer> mCustomersList { get; private set; }
    }


}
