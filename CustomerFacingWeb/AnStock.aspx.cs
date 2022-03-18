﻿using System;
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
        AnStock.StockItem= txtStockItem.Text;
        Session["AnStock"] = AnStock;
        //display the house number for this entry
        Response.Redirect("StockViewer.aspx");
    }
}