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

        public int Count { get; set; }

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
       public string Valid(string staffFirstName, string staffLastName, string staffAddress, string staffContactNo, string staffDOB)
        {
            string Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            //if first name is empty, return error message
            if (staffFirstName.Length == 0)
            {
                Error = Error + "The First Name may not be blank : ";
            }
            //if first name is above limit, return error message
            if (staffFirstName.Length > 50)
            {
                Error = Error + "The First Name may not be more than 50 characters : ";
            }

            //if last name is empty, return error message
            if (staffLastName.Length == 0)
            {
                Error = Error + "The Last Name may not be blank : ";
            }
            //if last name is above limit, return error message
            if (staffLastName.Length > 50)
            {
                Error = Error + "The Last Name may not be more than 50 characters : ";
            }

            //if address is empty, return error message
            if (staffAddress.Length == 0)
            {
                Error = Error + "Address may not be blank : ";
            }
            //if address is above limit, return error message
            if (staffAddress.Length > 100)
            {
                Error = Error + "Address may not be more than 100 characters : ";
            }

            //if ContactNo empty, return error message
            if (staffContactNo.Length == 0)
            {
                Error = Error + "Contact Number may not be blank : ";
            }
            //if ContactNo is above limit, return error message
            if (staffContactNo.Length > 12)
            {
                Error = Error + "Contact Number may not be more than 12 characters : ";
            }

            try
            {
                //copy the DOB value to the DateTemp variable
                DateTemp = Convert.ToDateTime(staffDOB);
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {

                    //record the error
                    Error = Error + "Staff age may not be over 100 : ";
                }
                //check to see if the date is greater than
                if (DateTemp > DateTime.Now.Date.AddYears(-16))
                {
                    //record error
                    Error = Error + "Staff age may not be younger than 16 : ";
                }
            }
            catch
            {
                //record error
                Error = Error + "The characters used cannot be accepted for 'Date of Birth', please insert a valid date. E.g. 23/09/1974 : ";
            }
                //return any error messages
                return Error;
            
        }

       
    }
}
    

