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
            DisplaySuppliers();
        }
    }

    private void DisplaySuppliers()
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();

        // set the data source to list of suppliers in collection
        lstSupplierList.DataSource = Suppliers.SupplierList;

        // set the name of the primary key
        lstSupplierList.DataValueField = "Id";

        // set the data field to display
        lstSupplierList.DataTextField = "Name";

        // bind the data to the list
        lstSupplierList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierId"] = -1;

        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Int32 SupplierId;

        if(lstSupplierList.SelectedIndex != -1)
        {
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);

            Session["SupplierId"] = SupplierId;

            Response.Redirect("SupplierDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }


    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SupplierId;

        if(lstSupplierList.SelectedIndex != -1)
        {
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);

            Session["SupplierId"] = SupplierId;

            Response.Redirect("SupplierConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();

        Suppliers.ReportByAddress(txtAddress.Text);

        lstSupplierList.DataSource = Suppliers.SupplierList;

        // set the name of the primary key
        lstSupplierList.DataValueField = "Id";

        // set the data field to display
        lstSupplierList.DataTextField = "Address";


        lstSupplierList.DataBind();

    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();

        Suppliers.ReportByAddress("");

        txtAddress.Text = "";

        lstSupplierList.DataSource = Suppliers.SupplierList;

        // set the name of the primary key
        lstSupplierList.DataValueField = "Id";

        // set the data field to display
        lstSupplierList.DataTextField = "Address";


        lstSupplierList.DataBind();


    }
}