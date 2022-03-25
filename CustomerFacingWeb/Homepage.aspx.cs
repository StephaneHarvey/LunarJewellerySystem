using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Homepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ImgBtnCustomer_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("CustomerDefault.aspx");
    }



    protected void ImgBtnInventory_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("StockDefault.aspx");
    }

    protected void ImgBtnOrder_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("OrderDefault.aspx");
    }

    protected void ImageBtnStaff_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("StaffDefault.aspx");
    }
}