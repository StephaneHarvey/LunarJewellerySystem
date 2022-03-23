using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private sata member for thisStaff
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stores proc
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate array list 
            PopulateArray(DB);  
        }

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }

            set
            {
                //set private data
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                //return count of list
                return mStaffList.Count;
            }
            set
            {
                //

            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                //get private data
                return mThisStaff;
            }
            set
            {
                //set private data
                mThisStaff = value;
            }

        }

        public int Add()
        {
            //adds new record to db based on mThisStaff values
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set thee parameters for sproc
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffDOB", mThisStaff.StaffDOB);
            DB.AddParameter("@StaffContactNo", mThisStaff.StaffContactNo);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            //execute sproc returning the pk value
            return DB.Execute("sproc_tblStaff_Insert");

        }

        public void Delete()
        {
            ////deletes record pointed to by thisStaff
            /////connect to db
            clsDataConnection DB = new clsDataConnection();
            //set parameters
            DB.AddParameter("StaffID", mThisStaff.StaffID);
            //execute sproc
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //update exisitng records
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set thee parameters for sproc
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffDOB", mThisStaff.StaffDOB);
            DB.AddParameter("@StaffContactNo", mThisStaff.StaffContactNo);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            //execute sproc
            DB.Execute("sproc_tblStaff_Update");

        }

        public void ReportByStaffFirstName(string StaffFirstName)
        {
            //filters records based on full or partial first name
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //send postcode param to the db
            DB.AddParameter("@StaffFirstName", StaffFirstName);
            //execute sproc
            DB.Execute("sproc_tblStaff_FilterByFirstName");
            //populate array list
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //var for index 
            Int32 Index = 0;
            //var to store record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //WHILE THERE ARE RECORDS TO PROCESS
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStaff AStaff = new clsStaff();
                //read in the fields from the cyurrent record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstName"]);
                AStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["StaffLastName"]);
                AStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                AStaff.StaffContactNo = Convert.ToString(DB.DataTable.Rows[Index]["StaffContactNo"]);
                AStaff.StaffDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDOB"]);
                //add the record to the private member
                mStaffList.Add(AStaff);
                //point to next record
                Index++;
            }
                
            
        }
    }
}