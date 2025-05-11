using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsProduct
        clsProduct AnProduct = new clsProduct();
        //capture the product id
        AnProduct.ProductID = Convert.ToInt32(txtProductID.Text);
        //capture the product name
        AnProduct.Name = txtName.Text;
        //capture the product category
        AnProduct.Category = txtCategory.Text;
        //capture the product price
        AnProduct.Price = Convert.ToDecimal(txtPrice.Text);
        //capture the product size
        AnProduct.Size = txtSize.Text;
        //capture the product in stock
        AnProduct.InStock = chkInStock.Checked;
        //capture the product release date
        AnProduct.ReleasedDate = Convert.ToDateTime(txtReleasedDate.Text);
        //store the product in the session object
        Session["AnProduct"] = AnProduct;
        //navigate to the view page
        Response.Redirect("ProductViewer.aspx");

    }
}