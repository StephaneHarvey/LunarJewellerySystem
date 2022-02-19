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
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the First Name of the Customer
        string CustomerFirstName = txtCustomerFirstName.Text;
        //capture the Surname of the Customer
        string CustomerSurname = txtCustomerSurname.Text;
        //capture the Address of the Customer
        string CustomerAddress = txtCustomerAddress.Text;
        //capture the Post Code of the Customer
        string CustomerPostCode = txtPostCode.Text;
        //capture the Date Of Birth of the Customer
        string CustomerDOB = txtCustomerDOB.Text;
        //capture the Email of the Customer
        string CustomerEmail = txtEmail.Text;
        //capture the Mobile Number of the Customer
        string CustomerMobileNumber = txtMobileNumber.Text;
        //variable to store any error messages
        string Error= "";
        //validate the data 
        Error = ACustomer.Valid(CustomerFirstName, CustomerSurname, CustomerAddress, CustomerPostCode, CustomerDOB, CustomerEmail,CustomerMobileNumber);
        if (Error == "")
        {
            //capture the First Name of the Customer
            ACustomer.CustomerFirstName = txtCustomerFirstName.Text;
            //capture the Surname of the Customer
            ACustomer.CustomerSurname = txtCustomerSurname.Text;
            //capture the Address of the Customer
            ACustomer.CustomerAddress = txtCustomerAddress.Text;
            //capture the Post Code of the Customer
            ACustomer.CustomerPostCode = txtPostCode.Text;
            //capture the Date Of Birth of the Customer
            ACustomer.CustomerDOB = Convert.ToDateTime(txtCustomerDOB.Text);
            //capture the Email of the Customer
            ACustomer.CustomerEmail = txtEmail.Text;
            //capture the Mobile Number of the Customer
            ACustomer.CustomerMobileNumber = txtMobileNumber.Text;
            //store the customer in the session object
            Session["ACustomer"] = ACustomer;
            //redirect to the viewer page 
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display the error message 
            lblError.Text = Error;
        }
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