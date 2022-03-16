using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        lstOrders.DataSource = Orders = new ClassLibrary.clsOrderCollection();
        //set the name of the primary key 
        lstOrders.DataValueField = "OrderNo";
        //set the data field to display 
        lstOrders.DataTextField = "OrderName";
        //blind the data to the list 
        lstOrders.DataBind();
    }
}