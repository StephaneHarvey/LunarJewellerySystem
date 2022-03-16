using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public class clsStaff
    {
        //private data members
        private Int32 mStaffID;
        private string mStaffFirstName;
        private string mStaffLastName;
        private string mStaffAddress;
        private string mStaffContactNo;
        private DateTime mStaffDOB;
        public string StaffAddress
        {
            get
            {
                //send data out of the property
                return mStaffAddress;
            }
            set
            {
                //allow data into the property
                mStaffAddress = value;
            }
        }
        public string StaffContactNo
        {
            get
            {
                //send data out of the property
                return mStaffContactNo;
            }
            set
            {
                //allow data into the property
                mStaffContactNo = value;
            }
        }
        public string StaffFirstName
        {
            get
            {
                //send data out of the property
                return mStaffFirstName;
            }
            set
            {
                //allow data into the property
                mStaffFirstName = value;
            }
        }
        public string StaffLastName
        {
            get
            {
                //send data out of the property
                return mStaffLastName;
            }
            set
            {
                //allow data into the property
                mStaffLastName = value;
            }
        }
        public Int32 StaffID
        {
            get
            {
                //send data out of the property
                return mStaffID;
            }
            set
            {
                //allow data into the property
                mStaffID = value;
            }
        }

        public DateTime StaffDOB
        {
            get
            {
                //send data out of the property
                return mStaffDOB;
            }
            set
            {
                //allow data into the property
                mStaffDOB = value;
            }
        }



        public bool Find(int StaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for StaffID to search for
            DB.AddParameter("@StaffID", StaffID);
            //execute sproc
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the db to the private data member
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]); 
                mStaffLastName = Convert.ToString(DB.DataTable.Rows[0]["StaffLastName"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mStaffContactNo = Convert.ToString(DB.DataTable.Rows[0]["StaffContactNo"]);
                mStaffDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDOB"]);
                //return that everything worked
                return true;
            }
            //if record can't be found     
            else
            {
                //return false so we know there is an issue
                return false;
            }
        }
    }

    public class clsStock
    {
    }
}
