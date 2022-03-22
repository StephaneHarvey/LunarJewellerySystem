using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffDelete : System.Web.UI.Page
{

    //var to store pk value of record to be deleted
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of staff to be deleted from the session object
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    void DeleteStaff()
    {
        //function to delete the selected record

        //create a new instance of jewellery system
        clsStaffCollection JewellerySystem = new clsStaffCollection();
        //find the record to delete
        JewellerySystem.ThisStaff.Find(StaffID);
        //delete the record
        JewellerySystem.Delete();
    }



    protected void btnYesDelete_Click(object sender, EventArgs e)
    {
        //delete record
        DeleteStaff();
        //redirect to main page
        Response.Redirect("StaffDefault.aspx");
    }
}