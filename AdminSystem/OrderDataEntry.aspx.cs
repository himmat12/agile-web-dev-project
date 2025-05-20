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
        string OrderDate = txtPlacementDate.Text;
        //capture the order status
        string OrderStatus = txtOrderStatus.Text;
        //capture order total price
        string OrderTotalPrice = txtTotalPrice.Text;
        //capture customer id
        string CustomerID = txtCustomerID.Text;
        //capture the staff id
        string StaffID = txtStaffID.Text;
        //capture paid check box
        string Paid = chkIsPaid.Text;

        string Error = "";
        Error = AnOrder.Valid(OrderStatus, OrderDate, OrderTotalPrice);
        if (Error == "")
        {
            //capture the placement date
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //capture the order status
            AnOrder.OrderStatus = OrderStatus;
            //capture the total price
            AnOrder.OrderTotalPrice = (float)Convert.ToDecimal(OrderTotalPrice);
            //capture customer id
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            //capture staff id
            AnOrder.StaffID = Convert.ToInt32(StaffID);
            //capture paid
            AnOrder.OrderPaid = chkIsPaid.Checked;
            //create a new instance of the order collection
            clsOrdersCollection OrderList = new clsOrdersCollection();
            //set the ThisOrder property
            OrderList.ThisOrder = AnOrder;
            //add the new record
            OrderList.Add();
            //navigate to view page
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
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