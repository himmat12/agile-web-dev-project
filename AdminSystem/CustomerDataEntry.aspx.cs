using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Configuration;
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

    protected void BtnOK_Click(object sender, EventArgs e)
    {

        //create a new instance of clsCustomer
        clsCustomer Customer = new clsCustomer();
        //capture customer id
        string CustomerId = txtCustomerId.Text;
        //capture the customer name
        string CustomerName = txtName.Text;
        //capture the customer email
        string CustomerEmail = txtEmail.Text;
        //create the customer phone number
        string CustomerPhoneNumber = txtPhoneNumber.Text;
        //capture if Subscribed check box
        bool CustomerIsSubscribed = chkIsSubscribed.Checked;
        //capture address
        string CustomerAddress = txtAddress.Text;
        //capture created at
        string CustomerCreatedAt = txtCreatedAt.Text;


        //capture customer name
        Customer.Name = CustomerName;
        //capture customer email
        Customer.Email = CustomerEmail;
        //capture if subscribed
        Customer.IsSubscribed = chkIsSubscribed.Checked;
        //capture phone number
        Customer.PhoneNumber = CustomerPhoneNumber;
        //capture the creation date
        Customer.CreatedAt = Convert.ToDateTime(DateTime.Now);
        //capture customer id
        //Customer.customerId = Convert.ToInt32(CustomerId);
        //capture address
        Customer.Address = CustomerAddress;

        //store the customer in the session 
        Session["customer"] = Customer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");

    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
    }      
}
