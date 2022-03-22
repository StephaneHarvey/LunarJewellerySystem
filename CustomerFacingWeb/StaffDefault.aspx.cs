using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffDefault : System.Web.UI.Page
{
    //variable to store pk with page level scope
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //populate the list
            DisplayStaffNames();
        }

       
    }

    void DisplayStaffNames()
    {
        {
            //create an instance of the staffcollection
            clsStaffCollection Staff = new clsStaffCollection();
            //set data source to the list of staff in the collection
            lstStaff.DataSource = Staff.StaffList;
            //set the name of the pk
            lstStaff.DataValueField = "StaffID";
            //set the data field to display
            lstStaff.DataTextField = "StaffFirstName";
            //bind the data to the list
            lstStaff.DataBind();

        }

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indiciate it is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AStaff.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store pk for deleted record
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //get the pk valueof the record to delete
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data int he session object
            Session["StaffID"] = StaffID;
            //redirect to delete page
            Response.Redirect("StaffDelete.aspx");
        }
        else //if no record has been selected
        {
            //display error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store pk for deleted record
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //get the pk valueof the record to edit
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data int the session object
            Session["StaffID"] = StaffID;
            //redirect to edit page
            Response.Redirect("AStaff.aspx");
        }
        else //if no record has been selected
        {
            //display error 
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}
