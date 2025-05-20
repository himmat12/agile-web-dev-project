using System;
using System.Collections.Generic;
using System.Drawing;
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
        string ProductID = txtProductID.Text;
        //capture the product name
        string Name = txtName.Text;
        //capture the product category
        string Category = txtCategory.Text;
        //capture the product price
        string Price = txtPrice.Text;
        //capture the product size
        string Size = txtSize.Text;
        //capture the product in stock
        string InStock = chkInStock.Text;
        //capture the product release date
        string ReleasedDate = txtReleasedDate.Text;
        // variable for error message
        string Error = "";
        //validate the data on the web form
        Error = AnProduct.Valid(Name, Size, Category, Price, ReleasedDate);
        if (Error == "")
        {
            //capture the name
            AnProduct.Name = Name;
            //capture the size
            AnProduct.Size = Size;
            //capture the category
            AnProduct.Category = Category;
            //convert and capture the price
            AnProduct.Price = Convert.ToDecimal(Price);
            //capture the release date
            AnProduct.ReleasedDate = Convert.ToDateTime(ReleasedDate);
            //capture the in stock status
            AnProduct.InStock = chkInStock.Checked;
            //create a new instance of the product collection
            clsProductCollection ProductList = new clsProductCollection();
            //set the ThisProduct property
            ProductList.ThisProduct = AnProduct;
            //add the new record
            ProductList.Add();
            //redirect to the list page
            Response.Redirect("ProductList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = "There were problems with the data entered: " + Error;
        }
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



    protected void txtProductID_TextChanged(object sender, EventArgs e)
    {

    }
}
