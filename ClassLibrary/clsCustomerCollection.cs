using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thiscustomer
        clsCustomer mThisCustomer = new clsCustomer();
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }
        //constructor for the class
        public clsCustomerCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerSurname", mThisCustomer.CustomerSurname);
            DB.AddParameter("@CustomerDateAdded", mThisCustomer.CustomerDateAdded);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerPostCode", mThisCustomer.CustomerPostCode);
            DB.AddParameter("@CustomerMobileNumber", mThisCustomer.CustomerMobileNumber);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }
        //public property for thiscustomer
        public List<clsCustomer> CustomersList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        //public property for this customer
        public int Count
        {
            get
            {
                //return the priavte data
                return mCustomerList.Count;
            }
            set
            {

            }
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //set the parameters for the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerSurname", mThisCustomer.CustomerSurname);
            DB.AddParameter("@CustomerDateAdded", mThisCustomer.CustomerDateAdded);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerPostCode", mThisCustomer.CustomerPostCode);
            DB.AddParameter("@CustomerMobileNumber", mThisCustomer.CustomerMobileNumber);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByPostCode(string CustomerPostCode)
        {
            //filters the records based on a full/partial postcode
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the postcode parameter to the database
            DB.AddParameter("@CustomerPostCode", CustomerPostCode);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByPostCode");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //object for the data connection
            RecordCount = DB.Count;
            //execute the stroed procedure
            mCustomerList = new List<clsCustomer>();
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
                ACustomer.CustomerDateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDateAdded"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerMobileNumber = Convert.ToString(DB.DataTable.Rows[Index]["CustomerMobileNumber"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }
    }
}
       
  
    



