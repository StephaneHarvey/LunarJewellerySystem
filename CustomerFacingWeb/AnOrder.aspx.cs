using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AnOrder : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed 
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        if (IsPostBack == false)
        {

            DisplayOrders();
            //if this is not a new record 
            if (OrderNo != -1)
            {
                //display the current data for the record 
                DisplayOrders();
            }
        }

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (OrderNo == -1)
        {
            //add the new record 
            Add();
        }
        else
        {
            //update the record
            Update();
        }
        ////add the new record 
        //Add();
        ////all done so redirect back to the main page 
        //Response.Redirect("OrderDefault.aspx");
        ////create a new instance of clsOrder
        //clsOrder AnOrder = new clsOrder();
        ////capture the order name
        //string OrderName = txtOrderName.Text;
        ////capture the product no 
        //string ProductNo = txtProductNo.Text;
        ////capture the date added
        //string DateAdded = txtDateAdded.Text;
        ////capture the statusno
        //string Status = txtStatus.Text;
        //string Error = "";
        ////validate the data 
        //Error = AnOrder.Valid(ProductNo, OrderName, Status, DateAdded);
        //if (Error == "")
        //{
        //    //capture the order name 
        //    AnOrder.OrderName = OrderName;
        //    //capture the product  no
        //    AnOrder.ProductNo = ProductNo;
        //    //capture the date added 
        //    AnOrder.DateAdded = Convert.ToDateTime(DateAdded);
        //    //store the order in the session object 
        //    Session["AnOrder"] = AnOrder;
        //    //redirect to the viewer page
        //    Response.Redirect("OrderViewer.aspx");
        //}
        //else
        //{
        //    //display the error message 
        //    lblError.Text = Error;
        //}
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderNo;
        //variable to store the result of the find operation 
        Boolean Found = false;
        //get the primary key entered by the user 
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //find the record 
        Found = AOrder.Find(OrderNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtDateAdded.Text = AOrder.DateAdded.ToString();
            txtOrderName.Text = AOrder.OrderName.ToString();
            txtStatus.Text = AOrder.Status;
            txtProductNo.Text = AOrder.ProductNo;

            
        }
    }
    //function for adding new records
    void Add()
    {
        //create an instance of the order book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //validate the data on the web form
        String Error = OrderBook.ThisOrder.Valid(txtProductNo.Text, txtOrderName.Text, txtStatus.Text, txtDateAdded.Text);
        //if the data is OK then add it to the object 
        if (Error == "")
        {
            //get the data entered by the user
            OrderBook.ThisOrder.ProductNo = txtProductNo.Text;
            OrderBook.ThisOrder.OrderName = txtOrderName.Text;
            OrderBook.ThisOrder.Status = txtStatus.Text;
            OrderBook.ThisOrder.DateAdded = Convert.ToDateTime(txtProductNo.Text);
            OrderBook.ThisOrder.Active = chkActive.Checked;
            //add the record 
            OrderBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("OrderDefault.aspx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }
    //function for updading recordds
    void Update()
    {
        //create an instance of the order book
        ClassLibrary.clsOrderCollection OrderBook = new ClassLibrary.clsOrderCollection();
        //validate the data on the web form
        String Error = OrderBook.ThisOrder.Valid(txtProductNo.Text, txtOrderName.Text, txtStatus.Text, txtDateAdded.Text);
        //if the data  is OK then add it to the object 
        if (Error == "")
        {
            //find the record to update 
            OrderBook.ThisOrder.Find(OrderNo);
            //get the data entered by the user 
            OrderBook.ThisOrder.ProductNo = txtProductNo.Text;
            OrderBook.ThisOrder.OrderName = txtOrderName.Text;
            OrderBook.ThisOrder.Status = txtStatus.Text;
            OrderBook.ThisOrder.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            OrderBook.ThisOrder.Active = chkActive.Checked;
            //update the record 
            OrderBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("OrderCancel.aspx");
        }
        else
        {
            //reprot an error 
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }
    void DisplayOrders()
    {
        //create an instance of the order book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to update 
        OrderBook.ThisOrder.Find(OrderNo);
        //display the data for this record 
        txtProductNo.Text = OrderBook.ThisOrder.ProductNo;
        txtOrderName.Text = OrderBook.ThisOrder.OrderName;
        txtStatus.Text = OrderBook.ThisOrder.Status;
        txtDateAdded.Text = OrderBook.ThisOrder.DateAdded.ToString();
        chkActive.Checked = OrderBook.ThisOrder.Active;
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderDefault.aspx");
    }
}