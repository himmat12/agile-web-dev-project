using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsProduct
        clsProduct AnProduct = new clsProduct();
        //get the data from the session object
        AnProduct = (clsProduct)Session["AnProduct"];
        //dispaly all product details
        Response.Write("Product ID: " + AnProduct.ProductID + "<br>");
        //convert to string,formats price as currency
        Response.Write("Price: " + AnProduct.Price.ToString("C") + "<br>"); 
        Response.Write("Size: " + AnProduct.Size + "<br>");
        Response.Write("Category: " + AnProduct.Category + "<br>");
        //Ternary conditional operator shows yes if true, no if false, instead of if else statement
        Response.Write("In Stock: " + (AnProduct.InStock ? "Yes" : "No") + "<br>");
        Response.Write("Release date: " + AnProduct.ReleasedDate.ToShortDateString() + "<br>");
        Response.Write("Product name: " + AnProduct.Name + "<br>");



    }
}