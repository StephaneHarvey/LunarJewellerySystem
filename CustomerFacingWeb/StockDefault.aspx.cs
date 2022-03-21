using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStocks();
        }
    }
    void DisplayStocks()
    {
        ClassLibrary.clsStockCollection Stock = new ClassLibrary.clsStockCollection();
        lstStock.DataSource = Stock.StockList;
        lstStock.DataValueField = "StockID";
        lstStock.DataTextField = "StockItem";
        lstStock.DataBind();
    }
}