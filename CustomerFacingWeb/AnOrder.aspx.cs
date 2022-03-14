using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the statusno
        AnOrder.StatusNo = txtStatus.Text;
        //store the order in the session object 
        Session["AnOrder"] = AnOrder;
        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");

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
}