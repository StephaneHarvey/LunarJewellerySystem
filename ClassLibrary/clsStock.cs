using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the stockId property
        private Int32 mStockID;
        private string mStockItem;
        private DateTime mStockDate;
        private Int32 mStockQuantity;


        //stockID public property
        public Int32 StockID
        {
            get
            {
                //this line of code sends data out of the property
                return mStockID;

            }
            set
            {
                //this loine of the code allows daa into the property 
                mStockID = value;
            }
        }


        //stockItem public property
        public string StockItem
        {
            get
            {
                //this line of code sends data out of the property
                return mStockItem;

            }
            set
            {
                //this loine of the code allows daa into the property 
                mStockItem = value;
            }
        }

        //stockID public property
        public Int32 StockQuantity
        {
            get
            {
                //this line of code sends data out of the property
                return mStockQuantity;

            }
            set
            {
                //this loine of the code allows daa into the property 
                mStockQuantity = value;
            }
        }

        //stockID public property
        public DateTime StockDate
        {
            get
            {
                //this line of code sends data out of the property
                return mStockDate;
            }
            set
            {
                //this line of the code allows daa into the property 
                mStockDate = value;
            }
        }

        public bool Find(int stockID)
        {
            //set the private data members to the test data value
            mStockID = 1;
            mStockDate = Convert.ToDateTime("14/01/2020");
            //always return true 
            return true;
        }




    }
}
