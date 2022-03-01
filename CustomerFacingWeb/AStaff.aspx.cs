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
}