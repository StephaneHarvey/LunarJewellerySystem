using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member ThisOrder
        clsOrder mThisOrder = new clsOrder();
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
            //object the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records 
            PopulateArray(DB);
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
        //public property for ThisOrder
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data 
                return mThisOrder;
            }
            set
            {
                //set the private data 
                mThisOrder = value;
            }
        }
        public int Add()
        {
            //adds a new record to the dataabse based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@ProductNo", mThisOrder.ProductNo);
            DB.AddParameter("@OrderName", mThisOrder.OrderName);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@Active", mThisOrder.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }
        public void Delete()
        {
            //deletes the record pointed to by thisAddress
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_Delete");

        }
        public void Update()
        {
            //update an existing record based on the values of ThisOrder
            //connect to the datebaase 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the store procedure 
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@ProductNo", mThisOrder.ProductNo);
            DB.AddParameter("@OrderName", mThisOrder.OrderName);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@Active", mThisOrder.Active);
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_Update");
        }

        public void ReportByProductNo(string ProductNo)
        {
            //filters the records based on a full or partial ProductNo
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the product no parameter to the database 
            DB.AddParameter("@ProductNo", ProductNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_FilterByProductNo");
            //populate the array list with the data table 
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index 
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount;
            //get the count of records 
            RecordCount = DB.Count;
            //clear the private array list 
            mOrderList = new List<clsOrder>();
            //while there are records to process 
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.ProductNo = Convert.ToString(DB.DataTable.Rows[Index]["ProductNo"]);
                AnOrder.Status = Convert.ToString(DB.DataTable.Rows[Index]["Status"]);
                AnOrder.OrderName = Convert.ToString(DB.DataTable.Rows[Index]["OrderName"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member 
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }

        }
    }
    
}