using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create new instance of user
        clsOrderUser AnUser = new clsOrderUser();
        //get data from the session
        AnUser = (clsOrderUser)Session["AnUser"];

        //if user is not part of orders department
        if (AnUser.Department != "Orders")
        {
            Response.Redirect("TeamMainMenu.aspx");
        }

        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();

            //populate status order drop down box dynamically
            //default value for the drop down box - index 0
            List<string> items = new List<string> { "--please select--"};
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

        }

        //if user is signed in
        if (AnUser != null)
        {
            Response.Write("Order Management System - Logged in as: " + AnUser.UserName);
        }
        //no user signed in
        else
        {
            Response.Redirect("TeamMainMenu.aspx");
        }
    }

    void DisplayOrders()
    {
        //create an instance of the orders collection
        clsOrdersCollection Orders = new clsOrdersCollection();
        //set the data source to the list of orders in the collection
        List<string> formattedOrders = new List<string>();
        foreach (clsOrders order in Orders.OrdersList)
        {
            string displayText = "Order: " + order.OrderID + " - " + order.OrderDate.ToShortDateString();
            formattedOrders.Add(displayText);
        }
        //set the data source to the list of orders in the collection
        lstOrdersList.DataSource = Orders.OrdersList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "OrderID";
        //set the data field to display: any field - placementDate
        lstOrdersList.DataTextField = "";
        //bind the data to the list
        lstOrdersList.DataBind();

        for (int i = 0; i < formattedOrders.Count; i++)
        {
            lstOrdersList.Items[i].Text = formattedOrders[i].ToString();
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
                //select item with the OrderID
                lstOrdersList.SelectedValue = OrderID.ToString();
            }
            else if (Found == false)
            {
                lblError.Text = "Value not Found.";
            }
        }
        catch
        {
            lblError.Text = "Order ID must be a number.";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 in the session object to indicate a new record
        Session["orderID"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderdataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be editted
        Int32 OrderID;
        //if a record has been selected from the list
        if(lstOrdersList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrdersList.SelectedValue);
            //store the data in the session object
            Session["orderID"] = OrderID;
            //redirect to edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 OrderID;
        if (lstOrdersList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderID = Convert.ToInt32(lstOrdersList.SelectedValue);
            //store the data in the session
            Session["orderID"] = OrderID;
            //redirect to confirm delete page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select the record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection object
        clsOrdersCollection AnOrder = new clsOrdersCollection();
        //retrieve the value of the order status from the presentation
        AnOrder.ReportByStatus(ddlOrderStatus.Text);
        if (ddlOrderStatus.SelectedIndex == 0)
        {
            lblError.Text = "Select an order status";
        }
        else
        {
            lblError.Text = "";

            List<string> formattedOrders = new List<string>();
            foreach (clsOrders order in AnOrder.OrdersList)
            {
                string displayText = "Order: " + order.OrderID + " - " + order.OrderDate.ToShortDateString();
                formattedOrders.Add(displayText);
            }
            //set the data source to the list of the orders in the collection
            lstOrdersList.DataSource = AnOrder.OrdersList;
            //set the name of the primary key
            lstOrdersList.DataValueField = "orderID";
            //set the name of the field to display
            //i want to show date and ID
            lstOrdersList.DataTextField = "";
            //bind the data to the list
            lstOrdersList.DataBind();

            for (int i = 0; i < formattedOrders.Count; i++)
            {
                lstOrdersList.Items[i].Text = formattedOrders[i].ToString();
            }
        }
            
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection object
        clsOrdersCollection AnOrder = new clsOrdersCollection();
        //set an empty string
        AnOrder.ReportByStatus("");
        //clear any existing filters to tidy up the interface
        ddlOrderStatus.SelectedIndex = 0;
        //clear error message
        lblError.Text = "";

        List<string> formattedOrders = new List<string>();
        foreach (clsOrders order in AnOrder.OrdersList)
        {
            string displayText = "Order: " + order.OrderID + " - " + order.OrderDate.ToShortDateString();
            formattedOrders.Add(displayText);
        }

        //set the data source to the list of the orders in the collection
        lstOrdersList.DataSource = AnOrder.OrdersList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "orderID";
        //set the name of the field to display
        //i want to show date and ID
        lstOrdersList.DataTextField = "";
        //bind the data to the list
        lstOrdersList.DataBind();
        for (int i = 0; i < formattedOrders.Count; i++)
        {
            lstOrdersList.Items[i].Text = formattedOrders[i].ToString();
        }
    }

    protected void btnLogOut_click(object sender, EventArgs e)
    {
        //new instance of user
        clsOrderUser AnUser = new clsOrderUser();  
        //update session information with blank details
        Session["AnUser"] = AnUser;
        //redirect
        Response.Redirect("TeamMainMenu.aspx");
    }
}