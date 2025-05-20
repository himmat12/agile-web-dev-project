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
        lstProductList.DataTextField = "Name";
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
}