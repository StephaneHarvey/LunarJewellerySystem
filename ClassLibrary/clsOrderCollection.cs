using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //public property for the order list 
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data 
                return mOrderList;
            }
            set
            {
                //set the private data 
                mOrderList = value;
            }
        }
        //constructor for the class
        public clsOrderCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record 
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.ProductNo = Convert.ToString(DB.DataTable.Rows[Index]["ProductNo"]);
                AnOrder.OrderName = Convert.ToString(DB.DataTable.Rows[Index]["OrderName"]);
                AnOrder.Status = Convert.ToString(DB.DataTable.Rows[Index]["Status"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member 
                mOrderList.Add(AnOrder);
                //point at the next record 
                Index++;
            }
            //create the items of the test data 
            clsOrder TestItem = new clsOrder();
            //set its properties 
            TestItem.Active = true;
            TestItem.OrderNo = 1;
            TestItem.Status = "delivered";
            TestItem.OrderName = "Cross Ring";
            TestItem.ProductNo = "123H";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list 
            mOrderList.Add(TestItem);
            //re initialise the object for some new data 
            TestItem = new clsOrder();
            //set its properties 
            TestItem.Active = true;
            TestItem.OrderNo = 2;
            TestItem.Status = "not delivered";
            TestItem.OrderName = "Cross Ring";
            TestItem.ProductNo = "123Q";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list 
            mOrderList.Add(TestItem);

        }
        public int Count
        {
            get
            {
                //return the count of the list 
                return mOrderList.Count;
            }
            set
            {
                //later 
            }
        }
        public clsOrder ThisOrder { get; set; }
    }
    
}