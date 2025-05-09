using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsSupplier Supplier = new clsSupplier();

        Supplier.Id = Convert.ToInt32(txtId.Text);
        Supplier.Name = txtName.Text;
        Supplier.Email = txtEmail.Text;
        Supplier.Phone = txtPhone.Text;
        Supplier.Address = txtAddress.Text;
        Supplier.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        Supplier.Active = Convert.ToBoolean(checkActive.Checked);

        Session["Supplier"] = Supplier;

        Response.Redirect("SupplierViewer.aspx");
    }
}