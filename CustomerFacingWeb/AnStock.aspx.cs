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
        //add the new record 
        Add();
        //all done so redirect back to the main page
        Response.Redirect("StockDefault.aspx");
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //get the data from the session object
        ////  AnStock.StockItem= txtStockID.Text;
        //////  Session["AnStock"] = AnStock;
        //display the house number for this entry
        /// Response.Redirect("StockViewer.aspx");

        //capture the StockItem
        string StockItem = txtStockItem.Text;
        //capture the Quantity
        string StockQuantity = txtStockQuantity.Text;
        //Capture the StockDate
        string StockDate = txtStockDate.Text;
        //Variable to store any error messages 
        string Error = "";
        //valdiate the data
        Error = AnStock.Valid(StockItem, StockDate);
        if (Error =="")
        {
            //capture the Stock item 
            AnStock.StockItem = StockItem;

            //capture the stockdate
            AnStock.StockDate = Convert.ToDateTime(StockDate);
            //store the stock in the session object 
            Session["AnStock"] = AnStock;
            //redirect to the viewer page 
            Response.Write("StockViewer.aspx");
        }
        else
        {
            //display the error message 
            lblError.Text = Error;
        }
        if (StockID == -1)
        {
            //add the new record 
            Add();
        }
        else
        {
            //update the record
            Update();
        }
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
    //variable to store the primary key with the page level scope
    Int32 StockID;
    //event handler for the page load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Stocks being processed
        StockID = Convert.ToInt32(Session["StockID"]);
        if (IsPostBack == false)
        {
            //populate the list of Quantitys
            DisplayStockQuantity();
            //if this is not a new record 
            if (StockID != -1)
            {
                //display the current data for the record 
                DisplayStocks();
            }
        }
    }
    //funcaion for adding new recordds 
    void Add()
    {
        //create an instance of the Stock
        clsStockCollection StockBook = new clsStockCollection();
        //validate the data on the web form 
        String Error = StockBook.ThisStock.Valid(txtStockID.Text, txtStockDate.Text);
        //if the data is OK then add it to the object 
        if (Error == "")
        {
            //get the data entered by the user/Manager
            StockBook.ThisStock.StockItem = txtStockItem.Text;
            StockBook.ThisStock.StockDate = Convert.ToDateTime(txtStockDate.Text);
            StockBook.ThisStock.Active = chkActive.Checked;
           //// StockBook.ThisStock.StockQuantity = Convert.ToInt32(ddlStockQuantity.SelectedValue);
            //add the record
            StockBook.Add();
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }
        //funcaion for updating  recordds 
        void Update()
        {
            //create an instance of the Stock
            ClassLibrary.clsStockCollection StockBook = new ClassLibrary.clsStockCollection();
            //validate the data on the web form 
            String Error = StockBook.ThisStock.Valid(txtStockID.Text, txtStockDate.Text);
            //if the data is OK then add it to the object 
            if (Error == "")
            {
                //find the record to update
                StockBook.ThisStock.Find(StockID);
                //get the data entered by the user/Manager
                StockBook.ThisStock.StockItem = txtStockItem.Text;
                StockBook.ThisStock.StockDate = Convert.ToDateTime(txtStockDate.Text);
                StockBook.ThisStock.Active = chkActive.Checked;
               /// StockBook.ThisStock.StockQuantity = Convert.ToInt32(ddlStockQuantity.SelectedValue);
                //update the record
                StockBook.Update();
                //all done so redirect back to the main page 
                Response.Redirect("StockDefault.aspx");
            }
            else
            {
                //report an error 
                lblError.Text = "There were problems with the data entered" +
                    Error;
            }
        }

        void DisplayStocks()
        {
        //create an instacne for the stock book
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to update 
        StockBook.ThisStock.Find(StockID);
        //display the data for the record 
        txtStockItem.Text = StockBook.ThisStock.StockItem;
        txtStockDate.Text = StockBook.ThisStock.StockDate.ToString();
        chkActive.Checked = StockBook.ThisStock.Active;
       //// ddlStockQuantity.SElectedVAlue = StockBook.ThisStock.StockQuantity.ToString();
    }
    }
        
