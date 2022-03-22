using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class OrderDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderNo;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be canceled from the session object 
        OrderNo = Convert.ToInt32(Session["OrderNo"]);

    }
    void CancelOrder()
    {
        //function to cancel the record 

        //create a new instance of the order book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to cancel
        OrderBook.ThisOrder.Find(OrderNo);
        //cancel the record 
        OrderBook.Delete();
    }
    //event handler for the yes button
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record 
        CancelOrder();
        //redirect back to main page 
        Response.Redirect("OrderDefault.aspx");
    }
}