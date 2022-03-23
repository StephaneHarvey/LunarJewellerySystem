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

    //Int32 DisplayStaff(string FirstNameFilter)
    //{
    //    //declare variables
    //    Int32 StaffID;
    //    string StaffFirstName;
    //    string StaffLastName;
    //    DateTime StaffDOB;
    //    string StaffContactNo;
    //    string StaffAddress;

    //    //instance of clsStaff
    //    clsStaffCollection JewellerySystem = new clsStaffCollection();
    //    JewellerySystem.ReportByStaffFirstName(FirstNameFilter);
    //    //var to store record count
    //    Int32 RecordCount;
    //    Int32 Index = 0;
    //    RecordCount = JewellerySystem.Count; //get the count of records from the tblstaff table
    //    lstStaff.Items.Clear();
    //    while (Index < RecordCount) //while there are records to process
    //    {
    //        //get these attributes
    //        StaffID = JewellerySystem.StaffList[Index].StaffID; 
    //        StaffFirstName = JewellerySystem.StaffList[Index].StaffFirstName; 
    //        StaffLastName = JewellerySystem.StaffList[Index].StaffLastName; 
    //        StaffDOB = Convert.ToDateTime(JewellerySystem.StaffList[Index].StaffDOB); 
    //        StaffContactNo = JewellerySystem.StaffList[Index].StaffContactNo; 
    //        StaffAddress = JewellerySystem.StaffList[Index].StaffAddress; 
    //        //create the new entry for the list box
    //        ListItem NewEntry = new ListItem(StaffFirstName + " " + StaffLastName + " " + StaffDOB + " " + StaffContactNo + " " + StaffAddress, StaffID.ToString());
    //        lstStaff.Items.Add(NewEntry); //add staff to the list
    //        Index++; //move the index to the next record
    //    }

    //}

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




    //protected void btnApply_Click(object sender, EventArgs e)
    //{
    //    Int32 RecordCount;
    //    RecordCount = DisplayStaff(txtFirstName.Text);
    //    lblError.Text = RecordCount + "records found";
    //}

    //protected void btnDisplayAll_Click(object sender, EventArgs e)
    //{
    //    Int32 RecordCount;
    //    RecordCount = DisplayStaff("");
    //    lblError.Text = RecordCount + "records in the database";
    //    txtFirstName.Text = "";
    //}
}
