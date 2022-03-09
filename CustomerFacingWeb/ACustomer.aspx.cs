using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class ACustomer : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            DisplayCustomer();
            if (CustomerID != -1)
            {
                DisplayCustomer();
            }
            //else
            //{
            //    txtCustomerDOB.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
            //}
        }

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (CustomerID == -1)
        {
            //add the new record
            Add();

            Response.Redirect("CustomerDefault");
        }
        else
        {
            //update the record
            Update();
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
        if (Found == true)
        {
            //display the values of the properties in the form
            //txtCustomerID.Text = Convert.ToInt32(ACustomer.CustomerID);
            txtCustomerFirstName.Text = ACustomer.CustomerFirstName;
            txtCustomerSurname.Text = ACustomer.CustomerSurname;
            txtCustomerDOB.Text = ACustomer.CustomerDOB.ToString();
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
            txtPostCode.Text = ACustomer.CustomerPostCode;
            txtMobileNumber.Text = ACustomer.CustomerMobileNumber;
            txtEmail.Text = ACustomer.CustomerEmail;
        }
    }
    //function for adding new records
    void Add()
    {
        //create an instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //validate the data on the web form
        String Error = CustomerBook.ThisCustomer.Valid(txtCustomerFirstName.Text, txtCustomerSurname.Text, txtCustomerDOB.Text, txtCustomerAddress.Text, txtPostCode.Text, txtMobileNumber.Text, txtEmail.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            CustomerBook.ThisCustomer.CustomerFirstName = txtCustomerFirstName.Text;
            CustomerBook.ThisCustomer.CustomerSurname = txtCustomerSurname.Text;
            CustomerBook.ThisCustomer.CustomerDOB = Convert.ToDateTime(txtCustomerDOB.Text);
            CustomerBook.ThisCustomer.CustomerAddress = txtCustomerAddress.Text;
            CustomerBook.ThisCustomer.CustomerPostCode = txtPostCode.Text;
            CustomerBook.ThisCustomer.CustomerMobileNumber = txtMobileNumber.Text;
            CustomerBook.ThisCustomer.CustomerEmail = txtEmail.Text;
            CustomerBook.ThisCustomer.Active = chkActive.Checked;
            //add the record
            CustomerBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("CustomerDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

    void DisplayCustomer()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //create an instance of the customers collection
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtCustomerFirstName.Text = CustomerBook.ThisCustomer.CustomerFirstName;
        txtCustomerSurname.Text = CustomerBook.ThisCustomer.CustomerSurname;
        txtCustomerDOB.Text = CustomerBook.ThisCustomer.CustomerDOB.ToString("dd/MM/yyyy");
        txtCustomerAddress.Text = CustomerBook.ThisCustomer.CustomerAddress;
        txtPostCode.Text = CustomerBook.ThisCustomer.CustomerPostCode;
        txtMobileNumber.Text = CustomerBook.ThisCustomer.CustomerMobileNumber;
        txtEmail.Text = CustomerBook.ThisCustomer.CustomerEmail;
        chkActive.Checked = CustomerBook.ThisCustomer.Active;
    }
    void Update()
        {
            //create an instance of the customer book
            ClassLibrary.clsCustomerCollection CustomerBook = new ClassLibrary.clsCustomerCollection();
            //validate the data on the web form
            String Error = CustomerBook.ThisCustomer.Valid(txtCustomerFirstName.Text, txtCustomerSurname.Text, txtCustomerDOB.Text, txtCustomerAddress.Text, txtPostCode.Text, txtMobileNumber.Text, txtEmail.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //Find the record to update
                CustomerBook.ThisCustomer.Find(CustomerID);
                //get the data entered by the user
                CustomerBook.ThisCustomer.CustomerFirstName = txtCustomerFirstName.Text;
                CustomerBook.ThisCustomer.CustomerSurname = txtCustomerSurname.Text;
                CustomerBook.ThisCustomer.CustomerDOB = Convert.ToDateTime(txtCustomerDOB.Text);
                CustomerBook.ThisCustomer.CustomerAddress = txtCustomerAddress.Text;
                CustomerBook.ThisCustomer.CustomerPostCode = txtPostCode.Text;
                CustomerBook.ThisCustomer.CustomerMobileNumber = txtMobileNumber.Text;
                CustomerBook.ThisCustomer.CustomerEmail = txtEmail.Text;
                CustomerBook.ThisCustomer.Active = chkActive.Checked;
                //add the record
                CustomerBook.Update();
                //all done so redirect back to the main page
                Response.Redirect("CustomerDefault.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered" + Error;
            }

        }
}
