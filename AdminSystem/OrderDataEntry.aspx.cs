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
        AnOrder.OrderTotalPrice = (float)Convert.ToDecimal(txtTotalPrice.Text);
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


    protected void btnFind_Click(object sender, EventArgs e)
    {       
        //no validation - check right input type and if the number is there

        //create a new instance of clsOrder
        clsOrders AnOrder = new clsOrders();
        //create a variable to store the primary key
        Int32 OrderID;
        //create a variable to store the result of find
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //invoke find
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtPlacementDate.Text = AnOrder.OrderDate.ToString();
            txtOrderStatus.Text = AnOrder.OrderStatus;
            txtTotalPrice.Text = AnOrder.OrderTotalPrice.ToString();
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtStaffID.Text = AnOrder.StaffID.ToString();
            chkIsPaid.Checked = AnOrder.OrderPaid;
        }
        else if(Found == false) //hard coded currently needs more refining
        {
                lblError.Text = "Value not Found.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}