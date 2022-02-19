using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class CustomerViewer : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list above
            DisplayCustomers();
        }
    }
        void DisplayCustomers()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the customers collection
            ClassLibrary.clsCustomerCollection Customers = new ClassLibrary.clsCustomerCollection();
            //set the data source to the list of customers in the collection
            lstCustomers.DataSource = Customers.CustomersList;
            //set the name of the primary key
            lstCustomers.DataValueField = "CustomerID";
            //set the data field to display
            lstCustomers.DataTextField = "CustomerPostCode";
            //bind the data to the list
            lstCustomers.DataBind();

        }
    }
