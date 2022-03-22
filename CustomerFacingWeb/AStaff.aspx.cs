using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ////create new instance of cls Staff
        //clsStaff AStaff = new clsStaff();
        ////capture StaffFirstName
        //string StaffFirstName = txtStaffFirstName.Text;
        ////capture lastname
        //string StaffLastName = txtStaffLastName.Text;
        ////capture DOB
        //string StaffDOB = txtStaffDOB.Text;
        ////capture contactno
        //string StaffContactNo = txtStaffContactNo.Text;
        ////capture address
        //string StaffAddress = txtStaffAddress.Text;
        ////variable to store error message 
        //string Error = "";
        ////validate data
        //Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffContactNo, StaffAddress);
        //if (Error == "")
        //{
        //    //Capture first name 
        //    AStaff.StaffFirstName = StaffFirstName;
        //    //capture last name
        //    AStaff.StaffLastName = StaffLastName;
        //    //capture address
        //    AStaff.StaffAddress = StaffAddress;
        //    //capture contact no
        //    AStaff.StaffContactNo = StaffContactNo;
        //    //capture dob
        //    AStaff.StaffDOB = Convert.ToDateTime(StaffDOB);
        //    //Store staff in session object
        //    Session["AStaff"] = AStaff;
        //    //redirect to viewer page
        //    Response.Write("AddressViewer.aspx");
        //}

        //else
        //{
        //    //display error
        //    lblError.Text = Error;
        //}



        ////store staffID in session object
        //Session["AStaff"] = AStaff;
        ////redirect to the viewer page
        //Response.Write("StaffViewer.aspx");


        //add new record
        Add();
        //redirect back to main page
        Response.Redirect("StaffDefault.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

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
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }
}