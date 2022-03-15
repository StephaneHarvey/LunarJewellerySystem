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



        public bool Find(int staffID)
        {
            //set private data members to the test data value
            mStaffID = 21;
            mStaffFirstName = "Gwenyth";
            mStaffLastName = "Paltrow";
            mStaffAddress = "67 Cross Close";
            mStaffContactNo = "07763890134";
            mStaffDOB = Convert.ToDateTime("10/10/1999");
            //return true
            return true;
        }
    }

    public class clsStock
    {
    }
}
