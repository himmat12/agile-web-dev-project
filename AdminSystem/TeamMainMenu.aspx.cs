using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnSupplier_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierLogin.aspx");
    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");

    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderLogin.aspx");

    }


    protected void btnProduct_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductLogin.aspx");

    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffLogin.aspx");

    }
}