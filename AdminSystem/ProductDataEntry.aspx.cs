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
    //variable to store the primary key with page level scope
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get thr number of the product to be processed
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ProductID != -1)
            {
                //display the current data for the record
                DisplayProduct();
            }
        }


    }

    private void DisplayProduct()
    {
        clsProductCollection Products = new clsProductCollection();
        //Products.ThisProduct = new clsProduct();
        Products.ThisProduct.Find(ProductID);

        txtProductID.Text = Products.ThisProduct.ProductID.ToString();
        txtName.Text = Products.ThisProduct.Name.ToString();
        txtPrice.Text = Products.ThisProduct.Price.ToString("0.00");
        chkInStock.Checked = Products.ThisProduct.InStock;
        txtCategory.Text = Products.ThisProduct.Category.ToString();
        txtSize.Text = Products.ThisProduct.Size.ToString();
        txtReleasedDate.Text = Products.ThisProduct.ReleasedDate.ToString("yyyy-MM-dd");
    }



    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsProduct
        clsProduct AnProduct = new clsProduct();
        //capture the product id
        int ProductID = Convert.ToInt32(txtProductID.Text);
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
            //capture the product id
            AnProduct.ProductID = ProductID;
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
            // if this is a new record 
            if (ProductID == -1)
            {
                //set the ThisProduct property
                ProductList.ThisProduct = AnProduct;
                //add the new record
                ProductList.Add();
            }
            else
            {
                //find the record to be updated
                ProductList.ThisProduct.Find(ProductID);
                //set the ThisProduct property
                ProductList.ThisProduct = AnProduct;
                //update the record
                ProductList.Update();
            }
            //redirect to the list page
            Response.Redirect("ProductList.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = "There were problems with the data entered: " + Error;
            //display the error message in red
            lblError.ForeColor = Color.Red;
            //display the error message in bold
            lblError.Font.Bold = true;
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
            txtReleasedDate.Text = AnProduct.ReleasedDate.ToString();
        }
        else
        {
            lblError.Text = "Product not found.";
        }
    }
}

