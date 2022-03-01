﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //    //update the list above
            //DisplayCustomers();
        
            if(CustomerID != -1)
            {
                DisplayCustomers();
            }
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
        lstCustomers.DataTextField = "CustomerID";
        //bind the data to the list
        lstCustomers.DataBind();
        //clsCustomerCollection AllCustomers = new clsCustomerCollection();
        ////create an instance of the customers collection
        //CustomerBook.ThisCustomer.Find(CustomerID);
        ////display the data for this record
        //txtCustomerFirstName.Text = CustomerBook.ThisCustomer.CustomerFirstName;
        //txtCustomerSurname.Text = CustomerBook.ThisCustomer.CustomerSurname;
        //txtCustomerDOB.Text = CustomerBook.ThisCustomer.CustomerDOB;
        //txtAddress.Text = CustomerBook.ThisCustomer.CustomerAddress;
        //txtPostCode.Text = CustomerBook.ThisCustomer.CustomerPostCode;
        //txtMobileNumber.Text = CustomerBook.ThisCustomer.CustomerMobileNumber;
        //txtEmail.Text = CustomerBook.ThisCustomer.CustomerEmail;
        //txtActive.Text = CustomerBook.ThisCustomer.Active;
    }
    


    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ACustomer.aspx");
    }
    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {//var to store the primary key value of the record to be deleted
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
}