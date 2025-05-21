using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["customerID"]);
    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {

        //create a new instance of clsCustomer
        clsCustomer Customer = new clsCustomer();
        //capture customer id
        Customer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //capture the customer name
        Customer.Name = txtName.Text;
        //capture the customer email
        Customer.Email = txtEmail.Text;
        //create the customer phone number
        Customer.PhoneNumber = txtPhoneNumber.Text;
        //capture if Subscribed check box
        Customer.IsSubscribed = chkIsSubscribed.Checked;
        //capture address
        Customer.Address = txtAddress.Text;

        //capture created at
        string CustomerCreatedAt = txtCreatedAt.Text;

    }

    

    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer Customer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user 
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        Found = Customer.Find(CustomerId);
        if (Found == true)
        {
            //display the values of the properties in the form
            txtAddress.Text = Customer.Address;
            txtCreatedAt.Text = Customer.CreatedAt.ToString("dd-mm-yyyy");
            txtEmail.Text = Customer.Email;
            txtPhoneNumber.Text = Customer.PhoneNumber;
            chkIsSubscribed.Checked = Customer.IsSubscribed;
            txtPhoneNumber.Text = Customer.PhoneNumber;
        }
        else
        {
            lblError.Text = "Customer not found";
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    { 
    }
}
