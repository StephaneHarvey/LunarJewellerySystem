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
    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["StockID"] = -1;
            //redirect to the data entry page 
            Response.Redirect("AnStock.aspx");



    }
    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted 
        Int32 StockID;
        //if a record has been from the list 
        if (lstStock.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            StockID = Convert.ToInt32(lstStock.SelectedValue);
            //store the data in the session object
            Session["StockID"] = StockID;
            //redirect to the delete page
            Response.Redirect("StockDefault.aspx");
        }
        else //if no record has been selected 
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
    //event handler for the edit button
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited 
        Int32 StockID;
        //if a record has been selected from the list 
        if (lstStock.SelectedIndex != -1)
        {
            //get the primary key value of the recorded to edit
            StockID = Convert.ToInt32(lstStock.SelectedValue);
            //store the data in the session object 
            Session["StockID"] = StockID;
            //redirect to the edit page
            Response.Redirect("AnStock.aspx");
        }
        else //if no record has been selected 
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}