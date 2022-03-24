using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AStaff : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the staff id number to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //populate the list
            DisplayStaffNames();
            //if this sint a new record
            if (StaffID != -1)
            {
                //display current data for the record
                DisplayStaffNames();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (StaffID == -1)
        {
            Add();
        }
        else
        {
            Update();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //rediect to default page
        Response.Redirect("StaffDefault.aspx");
    }

    protected void btnStaffFind_Click(object sender, EventArgs e)
    {
        //create a new instance of cls staff
        clsStaff AStaff = new clsStaff();
        //variable to store PK
        Int32 StaffID;
        //variable to store result of find
        Boolean Found = false;
        //get PK entered by user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find record
        Found = AStaff.Find(StaffID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form 
            txtStaffFirstName.Text = AStaff.StaffFirstName;
            txtStaffLastName.Text = AStaff.StaffLastName;
            txtStaffAddress.Text = AStaff.StaffAddress;
            txtStaffContactNo.Text = AStaff.StaffContactNo;
            txtStaffDOB.Text = AStaff.StaffDOB.ToString();
        }

    }

    //function to add new records
    void Add()
    {
        //create an instance of jewellery system 
        clsStaffCollection JewellerySystem = new clsStaffCollection();
        //validate the data on the web form
        String Error = JewellerySystem.ThisStaff.Valid(txtStaffFirstName.Text, txtStaffLastName.Text, txtStaffDOB.Text, txtStaffContactNo.Text, txtStaffAddress.Text);
        //if data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            JewellerySystem.ThisStaff.StaffFirstName = txtStaffFirstName.Text;
            JewellerySystem.ThisStaff.StaffLastName = txtStaffLastName.Text;
            JewellerySystem.ThisStaff.StaffDOB = Convert.ToDateTime(txtStaffDOB.Text);
            JewellerySystem.ThisStaff.StaffContactNo = txtStaffContactNo.Text;
            JewellerySystem.ThisStaff.StaffAddress = txtStaffAddress.Text;
            //add record
            JewellerySystem.Add();
            //redirect to main page once finished
            Response.Redirect("StaffDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void Update()
    {
        //create an instance of the staff jewellery system
        clsStaffCollection JewellerySystem = new clsStaffCollection();
        //validate the data on the web form
        String Error = JewellerySystem.ThisStaff.Valid(txtStaffFirstName.Text, txtStaffLastName.Text, txtStaffDOB.Text, txtStaffContactNo.Text, txtStaffAddress.Text);
        //if data is OK then add it to the object
        if (Error == "")
        {
            //find record to update
            JewellerySystem.ThisStaff.Find(StaffID);
            //get the data entered by the user
            JewellerySystem.ThisStaff.StaffFirstName = txtStaffFirstName.Text;
            JewellerySystem.ThisStaff.StaffLastName = txtStaffLastName.Text;
            JewellerySystem.ThisStaff.StaffDOB = Convert.ToDateTime(txtStaffDOB.Text);
            JewellerySystem.ThisStaff.StaffContactNo = txtStaffContactNo.Text;
            JewellerySystem.ThisStaff.StaffAddress = txtStaffAddress.Text;
            //update record
            JewellerySystem.Update();
            //redirect to main page once finished
            Response.Redirect("StaffDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }

    }

    void DisplayStaffNames()
    {
        {
            //create an instance of the staffcollection
            clsStaffCollection Staff = new clsStaffCollection();
            //find the record to update
            Staff.ThisStaff.Find(StaffID);
            //display data for this record
            txtStaffFirstName.Text = Staff.ThisStaff.StaffFirstName;
            txtStaffLastName.Text = Staff.ThisStaff.StaffLastName;
            txtStaffDOB.Text = Staff.ThisStaff.StaffDOB.ToString("dd/mm/yyyy");
            txtStaffContactNo.Text = Staff.ThisStaff.StaffContactNo;
            txtStaffAddress.Text = Staff.ThisStaff.StaffAddress;
        }

    }
}