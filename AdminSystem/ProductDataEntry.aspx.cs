using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public bool Found { get; private set; }

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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the product class
        clsProduct AnProduct = new clsProduct();
        //create a vartiable to store the PK
        Int32 ProductID;
        //reate a variable to store the found status
        Boolean Found = false;
        //get the PK entered by the user
        ProductID = Convert.ToInt32(txtProductID.Text);
        //find the record
        Found = AnProduct.Find(ProductID);
        //if found
        if (Found == true)
        {
            //dispaly the values of the properties
            txtName.Text = AnProduct.Name;
            txtPrice.Text = AnProduct.Price.ToString();
            chkInStock.Checked = AnProduct.InStock;
            txtCategory.Text = AnProduct.Category;
            txtSize.Text = AnProduct.Size;
            txtReleasedDate.Text = AnProduct.ReleasedDate.ToString("yyyy-MM-dd");
        }
        else
        {
            lblError.Text = "Product not found.";
        }
    }
    

    }
