using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection Staffs = new clsStaffCollection();

        lstStaffList.DataSource = Staffs.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "Name";
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Fix: Define and assign a value to StaffId before using it
         // Default value or retrieve the actual value as needed
        Session["StaffID"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffID;

        if (lstStaffList.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);

            Session["StaffID"] = StaffID;

            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();

        Staff.ReportByContactNumber(txtContactNumber.Text);

        lstStaffList.DataSource = Staff.StaffList;

        // set the name of the primary key
        lstStaffList.DataValueField = "StaffId";

        // set the data field to display
        lstStaffList.DataTextField = "ContactNumber";


        lstStaffList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();

        Staff.ReportByContactNumber("");

        txtContactNumber.Text = "";

        lstStaffList.DataSource = Staff.StaffList;

        // set the name of the primary key
        lstStaffList.DataValueField = "StaffId";

        // set the data field to display
        lstStaffList.DataTextField = "ContactNumber";


        lstStaffList.DataBind();
    }
}
