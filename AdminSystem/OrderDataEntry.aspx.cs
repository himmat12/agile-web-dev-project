using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        /** VALIDATION  **/
        //create new instance of user
        clsOrderUser AnUser = new clsOrderUser();
        AnUser.Department = ""; //set to null
        //get data from the session
        AnUser = (clsOrderUser)Session["AnUser"];

        //if user is not part of orders department or null
        if (AnUser.Department != "Orders" || AnUser.Department == "")
        {
            //redirect to main menu
            Response.Redirect("TeamMainMenu.aspx");
        }

        //get the number of the order to be processed
        OrderID = Convert.ToInt32(Session["orderID"]);
        if (IsPostBack == false)
        {
            //** POPULATING DROP DOWN LISTS **//
            //STATUS
            //default value for the drop down box
            List<string> items = new List<string> { "--please select--" };
            //populate the list further
            //create class instance
            clsOrdersCollection orders = new clsOrdersCollection();
            //call populate status function
            orders.PopulateStatusDDL();

            for (int i = 0; i < orders.PopulateList.Count; i++)
            {
                items.Add(orders.PopulateList[i].ToString());
            }
            //adds items to drop down box
            foreach (string item in items)
            {
                ddlOrderStatus.Items.Add(new ListItem(item));
            }
            //CUSTOMER
            //default value for the drop down box
            items = new List<string> { "--please select--" };
            //populate the list further
            //clear orders collection 
            orders = new clsOrdersCollection();
            //call populate status function
            orders.PopulateCustomerDDL();

            for (int i = 0; i < orders.PopulateList.Count; i++)
            {
                items.Add(orders.PopulateList[i].ToString());
            }
            //adds items to drop down box
            foreach (string item in items)
            {
                ddlCustomerID.Items.Add(new ListItem(item));
            }
            //STAFF
            //default value for the drop down box
            items = new List<string> { "--please select--" };
            //populate the list further
            //clear orders collection 
            orders = new clsOrdersCollection();
            //call populate status function
            orders.PopulateStaffDDL();

            for (int i = 0; i < orders.PopulateList.Count; i++)
            {
                items.Add(orders.PopulateList[i].ToString());
            }
            //adds items to drop down box
            foreach (string item in items)
            {
                ddlStaffID.Items.Add(new ListItem(item));
            }

            //**  Displaying data in form  **//
            //if this is not a new record
            if (OrderID != -1)
            {
                //display the current data for the record
                DisplayOrder();
                //OrderID can be accessed
                txtOrderID.ReadOnly = false;
                //find can be accessed
                btnFind.Enabled = true;
            }
            //if it is a new record
            if (OrderID == -1)
            {
                //orderID cannot be accessed - changed
                txtOrderID.ReadOnly = true;
                //find button cannot be accessed
                btnFind.Enabled = false;
            }
        }
    }

    void DisplayOrder()
    {
        //create an instance of the order collection
        clsOrdersCollection Orders = new clsOrdersCollection();
        //find the record to update
        Orders.ThisOrder.Find(OrderID);
        //display the data for the record
        txtOrderID.Text = Orders.ThisOrder.OrderID.ToString();
        txtPlacementDate.Text = Orders.ThisOrder.OrderDate.ToString();
        ddlOrderStatus.Text = Orders.ThisOrder.OrderStatus.ToString();
        txtTotalPrice.Text = Orders.ThisOrder.OrderTotalPrice.ToString();
        ddlCustomerID.Text = Orders.ThisOrder.CustomerID.ToString();
        ddlStaffID.Text = Orders.ThisOrder.StaffID.ToString();
        chkIsPaid.Checked = Orders.ThisOrder.OrderPaid;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrders AnOrder = new clsOrders();
        //capture the placement date
        string OrderDate = txtPlacementDate.Text;
        //capture the order status
        string OrderStatus = ddlOrderStatus.Text;
        //capture order total price
        string OrderTotalPrice = txtTotalPrice.Text;
        //capture customer id
        string CustomerID = ddlCustomerID.Text;
        //capture the staff id
        string StaffID = ddlStaffID.Text;
        //capture paid check box
        string Paid = chkIsPaid.Text;

        string Error = "";
        Error = AnOrder.Valid(OrderStatus, OrderDate, OrderTotalPrice, CustomerID, StaffID); //include customer and staff ID edit for drop downs - update tests
        if (Error == "")
        {
            //capture the order id
            AnOrder.OrderID = OrderID; //DONT MISS THIS BIT
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

            //if this is a new record - OrderID = -1 then add data
            if (OrderID == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderID);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
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
        //create a new instance of clsOrder
        clsOrders AnOrder = new clsOrders();
        //create a variable to store the primary key
        Int32 OrderID;
        //create a variable to store the result of find
        Boolean Found = false;
        try
        {
            //get the primary key entered by the user
            OrderID = Convert.ToInt32(txtOrderID.Text);
            //invoke find
            Found = AnOrder.Find(OrderID);
            //if found
            if (Found == true)
            {
                //display the values of the properties in the form
                txtPlacementDate.Text = AnOrder.OrderDate.ToString();
                ddlOrderStatus.Text = AnOrder.OrderStatus.ToString();
                txtTotalPrice.Text = AnOrder.OrderTotalPrice.ToString();
                ddlCustomerID.Text = AnOrder.CustomerID.ToString();
                ddlStaffID.Text = AnOrder.StaffID.ToString();
                chkIsPaid.Checked = AnOrder.OrderPaid;
            }
            else if(Found == false)
            {
                lblError.Text = "Value not Found.";
            }
        }
        catch
        {
            lblError.Text = "Order ID must be a number";
        }
        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }


    protected void btnLogOut_click(object sender, EventArgs e)
    {
        //new instance of user
        clsOrderUser AnUser = new clsOrderUser();
        //update session information with blank details
        Session["AnUser"] = AnUser;
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    
}