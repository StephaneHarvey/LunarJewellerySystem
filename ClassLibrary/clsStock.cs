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
        private Boolean mActive;

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
        //stockItem public property
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;

            }
            set
            {
                //this loine of the code allows daa into the property 
                mActive = value;
            }
        }


        public bool Find(int stockID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock id to search for
            DB.AddParameter("@StockID", StockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockID");
            //IF ONBE RECORD IS FOUND (THERESHOULD BE EITHER ONE OR ZERO!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mStockItem = Convert.ToString(DB.DataTable.Rows[0]["StockItem"]);
                mStockDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StockDate"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                // return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicting a problem
                return false;
            }




        }
    }
}






