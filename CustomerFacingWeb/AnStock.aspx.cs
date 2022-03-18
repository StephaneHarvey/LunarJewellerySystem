using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AnStock : System.Web.UI.Page
{



    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //get the data from the session object
        AnStock.StockItem= txtStockID.Text;
        Session["AnStock"] = AnStock;
        //display the house number for this entry
        Response.Redirect("StockViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock AnStock = new clsStock();
        //variable to store the primary key 
        Int32 StockID;
        //variable o store the result of the find operation 
        Boolean Found = true;
        //get the primary key entered by the user 
        StockID = Convert.ToInt32(txtStockID.Text);
        //Find the record 
        Found = AnStock.Find(StockID);
        //if found
        if (Found == true)
        {
            //display the values of the property in the form
            txtStockItem.Text = AnStock.StockItem;
            txtStockDate.Text = AnStock.StockDate.ToString();
            txtStockQuantity.Text = AnStock.StockQuantity.ToString();
        }
    }
}