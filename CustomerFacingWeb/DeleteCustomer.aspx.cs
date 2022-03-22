using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of the recird to be deleted
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }


void DeleteCustomer()
{
    //function to delete the selected record

    //create a new instance of the address book
    clsCustomerCollection CustomerBook = new clsCustomerCollection();
    //find the record to delete
    CustomerBook.ThisCustomer.Find(CustomerID);
    //delete the record
    CustomerBook.Delete();
}

    protected void btnYes_Click1(object sender, EventArgs e)
    {
        //delete the record
        DeleteCustomer();
        //redirrect back to the main page
        Response.Redirect("CustomerDefault.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirrect back to the main page
        Response.Redirect("CustomerDefault.aspx");
    }
}