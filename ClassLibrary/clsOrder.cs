using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrder
    {
        //public string Valid (string orderName,
        //                     string productNo,
        //                     string status,
        //                     string dateAdded)
        
        public string StatusNo { get; set; }
        //public string OrderName { get; set; }
        //public string OrderNo { get; set; }

        public bool Find(int OrderNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the orderno to search for 
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the store procedure 
            DB.Execute("sproc_tblOrderNo_FilterByOrderNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderName = Convert.ToString(DB.DataTable.Rows[0]["OrderName"]);
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mProductNo = Convert.ToString(DB.DataTable.Rows[0]["ProductNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mStatus = Convert.ToString(DB.DataTable.Rows[0]["Status"]);
                //always return true
                return true;
            }
           //if no record was found 
           else
            {
                //return false indicating a problem 
                return false;
            }
            
        }
        private string mOrderName;
        public string OrderName
        {
            get
            {
                return mOrderName;
            }
            set
            {
                mOrderName = value;
            }
        }
        private Int32 mOrderNo;
        public int OrderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }
        private string mProductNo;
        public string ProductNo
        {
            get
            {
                //this line if code sends data out of the property 
                return mProductNo;
            }
            set
            {
                //this line of code allows data into the property 
                mProductNo = value;
            }
        }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        private Boolean mActive;
        public bool Active
        {
            get
            {
                //this line if code sends data out of the property 
                return mActive;
            }
            set
            {
                //this line of code allows data into the property 
                mActive = value;
            }
        }
        private string mStatus;
        public string Status
        {
            get
            {
                //this line if code sends data out of the property 
                return mStatus;
            }
            set
            {
                //this line of code allows data into the property 
                mStatus = value;
            }
        }

        public string Valid(string productNo, string orderName, string status, string dateAdded)
        {
            //create a string variable to store the error 
            String Error = "";
            //create a temporary variable to store date values 
            DateTime DateTemp;
            //if the ProductNo is blank
            if (productNo.Length == 0)
            {
                //record the error 
                Error = Error + "The product no may not be blank : ";
            }
            //if the product no is greater than 6 characters 
            if (productNo.Length > 6)
            {
                //record the error 
                Error = Error + "The product no must be less than 6 characters :";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable 
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in the past: ";
                }
                //check to see if the date is greater than today's date 
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "The date was not a valid date : ";
            }
            //is the product no blank 
            if (orderName.Length == 0)
            {
                //record the error 
                Error = Error + "The order name may not be blank :";
            }
            //if the product no is too long 
            if (orderName.Length > 50)
            {
                //record the error 
                Error = Error + "The order name must be less than 50 characters : ";
            }
            //is the status blank 
            if (status.Length == 0)
            {
                //record the error 
                Error = Error + "The status may not be blank :";
            }
            //if the status is too long 
            if (status.Length > 50)
            {
                //record the error 
                Error = Error + "The status must be less than 50 characters : ";

            }
                
           
            //return any error messages
            return Error;
        }
       
    }
       

        
    
}
