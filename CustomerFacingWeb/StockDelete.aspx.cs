using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StockDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 StockID;

    //event handler for the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be deleted from the session object 
        StockID = Convert.ToInt32(Session["StockID"]);
    }
    void DeleteStock()
    {
        //funcation to delete the selected record 

        //create a new instance of the address book
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to delete
        StockBook.ThisStock.Find(StockID);
        //delete teh record 
        StockBook.Delete();
    }

    //event handler for the yes button 
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete teh record
        DeleteStock();
        //redirect back to the main page 
        Response.Redirect("StockDefault.aspx");
    }
}