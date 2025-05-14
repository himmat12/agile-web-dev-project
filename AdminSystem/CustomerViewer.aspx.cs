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
        //create a new instance of clsCustomer
        clsCustomer Customer = new clsCustomer();
        //get data from session object
        Customer = (clsCustomer)Session["customer"];
        //display the data
        Response.Write(Customer.Name);
        Response.Write(Customer.Email);
        Response.Write(Customer.PhoneNumber);
        Response.Write(Customer.customerId);
        Response.Write(Customer.IsSubscribed);
        Response.Write(Customer.Address);
        Response.Write(Customer.CreatedAt);

    }
}