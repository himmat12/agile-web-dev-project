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
        //create new instance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //get data from session object
        AnOrder = (clsOrders)Session["AnOrder"];
        //display the data
        Response.Write(AnOrder.OrderID);
        Response.Write(AnOrder.OrderDate);
        Response.Write(AnOrder.OrderStatus);
        Response.Write(AnOrder.OrderTotalPrice);
        Response.Write(AnOrder.CustomerID);
        Response.Write(AnOrder.StaffID);
        Response.Write(AnOrder.OrderPaid);
    }
}