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
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();

            List<string> items = new List<string>{"--please select--","pending", "shipped", "cancelled", "completed" };
            
            foreach (string item in items)
            {
                ddlOrderStatus.Items.Add(new ListItem(item));
            }
        }
    }

    void DisplayOrders()
    {
        //create an instance of the orders collection
        clsOrdersCollection Orders = new clsOrdersCollection();
        //set the data source to the list of orders in the collection
        lstOrdersList.DataSource = Orders.OrdersList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "OrderID";
        //set the data field to display: any field - placementDate
        lstOrdersList.DataTextField = "OrderDate";
        //bind the data to the list
        lstOrdersList.DataBind();
    }


    protected void lstOrdersList_SelectedIndexChanged(object sender, EventArgs e)
    {

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
            //set the data source to the list of the orders in the collection
            lstOrdersList.DataSource = AnOrder.OrdersList;
            //set the name of the primary key
            lstOrdersList.DataValueField = "orderID";
            //set the name of the field to display
            //i want to show date and ID
            lstOrdersList.DataTextField = "orderDate";
            //bind the data to the list
            lstOrdersList.DataBind();
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
        //set the data source to the list of the orders in the collection
        lstOrdersList.DataSource = AnOrder.OrdersList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "orderID";
        //set the name of the field to display
        //i want to show date and ID
        lstOrdersList.DataTextField = "orderDate";
        //bind the data to the list
        lstOrdersList.DataBind();
    }
}