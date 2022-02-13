using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clscustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the customerNo
        ACustomer.CustomerFirstName = txtCustomerFirstName.Text;
        //store the ID in the session object
        Session["ACustomer"] = ACustomer;
        //redirect to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found==true)
        {
            //display the values of the properties in the form
           // txtCustomerID.Text = ACustomer.CustomerID;
            txtCustomerFirstName.Text = ACustomer.CustomerFirstName;
            txtCustomerSurname.Text = ACustomer.CustomerSurname;
            txtCustomerDOB.Text = ACustomer.CustomerDOB.ToString();
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
            txtPostCode.Text = ACustomer.CustomerPostCode;
            txtMobileNumber.Text = ACustomer.CustomerMobileNumber;
            txtEmail.Text = ACustomer.CustomerEmail;
        }

    }
}