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
        clsProduct AnProduct = new clsProduct();
        AnProduct.Find(ProductID);

        txtProductID.Text = AnProduct.ProductID.ToString();
        txtName.Text = AnProduct.Name;
        txtPrice.Text = AnProduct.Price.ToString("0.00");
        chkInStock.Checked = AnProduct.InStock;
        txtCategory.Text = AnProduct.Category;
        txtSize.Text = AnProduct.Size;
        txtReleasedDate.Text = AnProduct.ReleasedDate.ToString("yyyy-MM-dd");
    }




    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsProduct
        clsProduct AnProduct = new clsProduct();
        //set a defoult ProductID for new records
        int ProductID = -1;
        //if the product id is not -1 then it is an existing record
        if (Session["ProductID"] != null && Session["ProductID"].ToString() != "-1")
        {
            try
            {
                ProductID = Convert.ToInt32(txtProductID.Text);
            }
            catch
            {
                lblError.Text = "Invalid Product ID.";
                return;
            }
        }
        //capture the product id
        //int ProductID = Convert.txtProductID.Text;
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

        //validate input
        if (!string.IsNullOrEmpty(txtProductID.Text))
        {
            try
            {
                //create a variable to store the PK
                Int32 ProductID = Convert.ToInt32(txtProductID.Text);

                //create a variable to store the found status
                Boolean Found = AnProduct.Find(ProductID);

                //if found
                if (Found == true)
                {
                    //display the values of the properties
                    txtName.Text = AnProduct.Name;
                    txtPrice.Text = AnProduct.Price.ToString();
                    chkInStock.Checked = AnProduct.InStock;
                    txtCategory.Text = AnProduct.Category;
                    txtSize.Text = AnProduct.Size;
                    txtReleasedDate.Text = AnProduct.ReleasedDate.ToString();
                    lblError.Text = ""; // clear error
                }
                else
                {
                    lblError.Text = "Product not found.";
                }
            }
            catch (FormatException)
            {
                lblError.Text = "Product ID must be a number.";
            }
        }
        else
        {
            lblError.Text = "Please enter a Product ID.";
        }
    }
}
