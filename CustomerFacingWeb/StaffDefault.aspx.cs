using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
