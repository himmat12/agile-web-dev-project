using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 ProductID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get hte number of the product to be deleted from the session object
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the product collection
        clsProductCollection ProductList = new clsProductCollection();
        //find the record to delete
        ProductList.ThisProduct.Find(ProductID);
        //delete the record
        ProductList.Delete();
        //redirect back to the product list page
        Response.Redirect("ProductList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the product list page
        Response.Redirect("ProductList.aspx");
    }
}