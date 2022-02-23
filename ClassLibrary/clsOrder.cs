using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrder
    {
        public string StatusNo { get; set; }
        //public string OrderName { get; set; }
        //public string OrderNo { get; set; }

        public bool Find(int ProductNo)
        {
            mOrderName = "Cross Ring";
            mOrderNo = "012345";
            mProductNo = 21;
            mDateAdded = Convert.ToDateTime("16/8/2015");
            //always return true
            return true;
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
        private string mOrderNo;
        public string OrderNo
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
        private Int32 mProductNo;
        public Int32 ProductNo
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
    }
       

        
    
}
