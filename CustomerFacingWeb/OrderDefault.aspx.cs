using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class OrderDefault : System.Web.UI.Page
{
    Int32 OrderNo;
    //this function handles the load event for the page 
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }

    }
    void DisplayOrders()
    {
        //create an instance of the collection 
        ClassLibrary.clsOrderCollection Orders = new ClassLibrary.clsOrderCollection();
        //set the data source to the list o
        lstOrders.DataSource = Orders.OrderList;
        //set the name of the primary key 
        lstOrders.DataValueField = "OrderNo";
        //set the data field to display 
        lstOrders.DataTextField = "OrderName";
        //blind the data to the list 
        lstOrders.DataBind();
    }
    //event handler for the add button
    protected void btnAddOrder_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["OrderNo"] = -1;
        //redirect to the data entry page 
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnCancelOrder_Click(object sender, EventArgs e)
    {
        //var to store the primary key values of the record to be deleted 
        Int32 OrderNo;
        //if a record has been selected from the list 
        if (lstOrders.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            OrderNo = Convert.ToInt32(lstOrders.SelectedValue);
            //store the data in the session object
            Session["OrderNo"] = OrderNo;
            //redirect to the delete page 
            Response.Redirect("OrderCancel.aspx");
        }
        else //if no record has been selected 
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    Int32 DisplayOrders(string OrderFilter)
    {
        //declare the varibales 
        Int32 OrderNo;
        string ProductNo;
        string OrderName;
        string Status;

        //create a new instance of the clsAddress
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ReportByProductNo(OrderFilter);
        //var to store the count of records
        Int32 RecordCount;
        Int32 Index = 0;
        RecordCount = OrderBook.Count; //get the count of records from the tblcustomer table
        lstOrders.Items.Clear();
        while (Index < RecordCount) //while there are records to process
        {
            OrderNo = OrderBook.OrderList[Index].OrderNo; // get the customer id 
            ProductNo = OrderBook.OrderList[Index].ProductNo; //get the firstname
            OrderName = OrderBook.OrderList[Index].OrderName; //get the address
            Status = OrderBook.OrderList[Index].Status; //get the postcode

            //create the new enetry for the list box
            ListItem NewEntry = new ListItem(ProductNo + " " + OrderName + " " + Status, OrderNo.ToString());
            lstOrders.Items.Add(NewEntry); //add customer to the list
            Index++; //move the index to the next record
        }
        return RecordCount; //return the count of records found 
    }
    //eventy handler for the edit button
    protected void btnEditOrder_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited 
        Int32 OrderNo;
        //if a record has been selected from the list 
        if (lstOrders.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            OrderNo = Convert.ToInt32(lstOrders.SelectedValue);
            //store the data in the session object 
            Session["OrderNo"] = OrderNo;
            //redirect to the edit page 
            Response.Redirect("AnOrder.aspx");
        }
        else //if no record has been selected 
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayOrders("");
        lblError.Text = RecordCount + "records in the database";
        txtProductNo.Text = "";
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayOrders(txtProductNo.Text);
        lblError.Text = RecordCount + "records found";
    }
}