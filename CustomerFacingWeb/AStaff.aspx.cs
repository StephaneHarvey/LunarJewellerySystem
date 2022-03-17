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
        //create new instance of cls Staff
        clsStaff AStaff = new clsStaff();
        //capture StaffFirstName
        AStaff.StaffFirstName = txtStaffFirstName.Text;
        //store staffID in session object
        Session["AStaff"] = AStaff;
        //redirect to the viewer page
        Response.Redirect("StaffViewer.aspx");

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
}