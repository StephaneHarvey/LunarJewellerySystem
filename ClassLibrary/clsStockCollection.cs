using ClassLibrary;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        public clsStockCollection()
        {
            //var for he index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock
                clsStock AnStock = new clsStock();
                //read in the fields from the current record 
                AnStock.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStock.StockItem = Convert.ToString(DB.DataTable.Rows[Index]["StockItem"]);
                AnStock.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                AnStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                AnStock.StockDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StockDate"]);
                //add the record to the private data member 
                mStockList.Add(AnStock);
                //point at the next record 
                Index++;
            }
        }
        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }



        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
public clsStock ThisStock { get; set; }
        List<clsStock> mStockList = new List<clsStock>();
    }
}