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
        Customer.CustomerId = Convert.ToInt32(CustomerId);
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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer customer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user 
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        Found = customer.Find(CustomerId);
        if (Found == true)
        {
            //display the values of the properties in the form
            txtAddress.Text = customer.Address;
            txtCreatedAt.Text = customer.CreatedAt.ToString();
            txtEmail.Text = customer.Email;
            txtPhoneNumber.Text = customer.PhoneNumber;
            chkIsSubscribed.Checked = customer.IsSubscribed;
            txtPhoneNumber.Text = customer.PhoneNumber;
        }


    }
}
