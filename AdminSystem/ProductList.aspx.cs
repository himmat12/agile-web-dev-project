using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class ProductList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayProducts();
        }

    }
    void DisplayProducts()
    {
        //create an instance of the product collection
        clsProductCollection Products = new clsProductCollection();
        //set the data source to the list of products in the collection
        lstProductList.DataSource = Products.ProductList;
        //set the name of the primary key
        lstProductList.DataValueField = "ProductID";
        //set the data field to display
        lstProductList.DataTextField = "DisplayInfo";
        //bind the data to the list
        lstProductList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 in the session object to indicate this is a new record
        Session["ProductID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ProductDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 ProductID;
        //if a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            //get the primary key value of the record to be edited
            ProductID = Convert.ToInt32(lstProductList.SelectedValue);
            //store the data in the session object
            Session["ProductID"] = ProductID;
            //redirect to the data entry page
            Response.Redirect("ProductDataEntry.aspx");
        }
        else
        {
            //display an error message
            lblError.Text = "Please select a record to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 ProductID;
        //if a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            //get the primary key value of the record to be deleted
            ProductID = Convert.ToInt32(lstProductList.SelectedValue);
            //store the data in the session object
            Session["ProductID"] = ProductID;
            //redirect to the data entry page
            Response.Redirect("ProductConfirmDelete.aspx");
        }
        else
        {
            //display an error message
            lblError.Text = "Please select a record to delete";
        }

    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //creat an inst6ance of the product object
        clsProductCollection Products = new clsProductCollection();
        //retrieve the value of category from presentation layer
        Products.ReportByCategory(txtFilterCategory.Text);
        //set the data source to the filtered list of products in the collection
        lstProductList.DataSource = Products.ProductList;
        //set the name of the primary key
        lstProductList.DataValueField = "ProductID";
        //set the data field to display
        lstProductList.DataTextField = "DisplayInfo";
        //bind the data to the list
        lstProductList.DataBind();

    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the product object
        clsProductCollection Products = new clsProductCollection();
        //set an empty string as the filter
        Products.ReportByCategory("");
        //clear any existing filter to tidy up the display
        txtFilterCategory.Text = "";
        //set the data source to the list of products in the collection
        lstProductList.DataSource = Products.ProductList;
        //set the name of the primary key
        lstProductList.DataValueField = "ProductID";
        //set the data field to display
        lstProductList.DataTextField = "Category";
        //bind the data to the list
        lstProductList.DataBind();
    }
}