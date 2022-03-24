using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerDefault : System.Web.UI.Page
{
     Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list above
            DisplayCustomers();

        }
    }
    void DisplayCustomers()
    {
        //create an instance of the customer collection
        ClassLibrary.clsCustomerCollection Customers = new ClassLibrary.clsCustomerCollection();
        //set the data source to the list of customers in the collection
        lstCustomers.DataSource = Customers.CustomersList;
        //set the name of the primary key
        lstCustomers.DataValueField = "CustomerID";
        //se the data field to display
        lstCustomers.DataTextField = "CustomerPostCode";
        //bind the data to the list
        lstCustomers.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ACustomer.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var store the primary key value of the record to be edited
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("ACustomer.aspx");
        }
        else  //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("DeleteCustomer.aspx");
        }
        else  //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
        Int32 DisplayCustomer(string PostCodeFilter)
        {
            //declare the varibales 
            Int32 CustomerID;
            string CustomerFirstName;
            string CustomerAddress;
            string CustomerPostCode;

            //create a new instance of the clsAddress
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            CustomerBook.ReportByPostCode(PostCodeFilter);
            //var to store the count of records
            Int32 RecordCount;
            Int32 Index = 0;
            RecordCount = CustomerBook.Count; //get the count of records from the tblcustomer table
            lstCustomers.Items.Clear();
            while (Index < RecordCount) //while there are records to process
            {
                CustomerID = CustomerBook.CustomersList[Index].CustomerID; // get the customer id 
                CustomerFirstName = CustomerBook.CustomersList[Index].CustomerFirstName; //get the firstname
                CustomerAddress = CustomerBook.CustomersList[Index].CustomerAddress; //get the address
                CustomerPostCode = CustomerBook.CustomersList[Index].CustomerPostCode; //get the postcode

                //create the new enetry for the list box
                ListItem NewEntry = new ListItem(CustomerFirstName + " " + CustomerAddress + " " + CustomerPostCode, CustomerID.ToString());
                lstCustomers.Items.Add(NewEntry); //add customer to the list
                Index++; //move the index to the next record
            }
            return RecordCount; //return the count of records found 
        }


    protected void btnApply_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayCustomer(txtPostCode.Text);
        lblError.Text = RecordCount + "records found";
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayCustomer("");
        lblError.Text = RecordCount + "records in the database";
        txtPostCode.Text = "";
    }
}




