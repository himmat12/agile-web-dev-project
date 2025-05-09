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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrders AnOrder = new clsOrders();
        //capture the placement date
        AnOrder.OrderDate = Convert.ToDateTime(DateTime.Now);
        //capture the order status
        AnOrder.OrderStatus = txtOrderStatus.Text;
        //capture the total price
        AnOrder.OrderTotalPrice = (float)Convert.ToDouble(txtTotalPrice);
        //capture customer id
        AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //capture staff id
        AnOrder.StaffID = Convert.ToInt32(txtStaffID.Text);
        //capture is paid check box
        AnOrder.OrderPaid = chkIsPaid.Checked;

        //store the order in the session
        Session["anOrder"] = AnOrder;
        //navigate to view page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}