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
    public int CustomerId { get; private set; }
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomer();
            }
        }
    }

    protected void DisplayCustomer()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ThisCustomer.Find(CustomerID);
        //display the data for the record
        txtCustomerId.Text = Customer.ThisCustomer.CustomerId.ToString();
        txtName.Text = Customer.ThisCustomer.Name.ToString();
        txtEmail.Text = Customer.ThisCustomer.Email.ToString();
        txtPhoneNumber.Text = Customer.ThisCustomer.PhoneNumber.ToString();
        chkIsSubscribed.Checked = Customer.IsSubscribed; 
        txtCreatedAt.Text = Customer.ThisCustomer.CreatedAt.ToString();

    }


protected void btnOK_Click(object sender, EventArgs e)
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
        Customer.CreatedAt = Convert.ToDateTime(DateTime.Now);


        // Declare the 'Error' variable before using it
        string Error = "";
        Error = Customer.Valid(Customer.Name, Customer.Email, Customer.PhoneNumber, Customer.Address, Customer.CreatedAt.ToString());

        if (Error == "")
        {
            Customer.CustomerId = CustomerId;  // DON'T MISS THIS BIT !!!!
            Customer.Name = txtName.Text;
            Customer.Email = txtEmail.Text;
            Customer.PhoneNumber = txtPhoneNumber.Text;
            Customer.IsSubscribed = chkIsSubscribed.Checked;
            Customer.Address = txtAddress.Text;
            Customer.CustomerId = Convert.ToInt32(CustomerId);
            Customer.CreatedAt = Convert.ToDateTime(DateTime.Now);
            clsCustomerCollection CustomertList = new clsCustomerCollection();
            
            //set the ThisCustomer
            if (CustomerId == -1)
            {
                CustomertList.ThisCustomer = Customer;
                //add the new record
                CustomertList.Add();
            }

            //otherwise it must be an update
            else
            {
                CustomertList.ThisCustomer.Find(CustomerId);
                CustomertList.ThisCustomer = Customer;
                //update the record
                CustomertList.Update();
            }


                //navigate to the view page
                Response.Redirect("CustomerList.aspx");
        }

        else
        {
            lblError.Text = "Error" + Error;

        }
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
            txtName.Text = Customer.Name;
            txtCustomerId.Text = CustomerId.ToString();
            txtAddress.Text = Customer.Address;
            txtCreatedAt.Text = Customer.CreatedAt.ToString("dd-mm-yyyy");
            txtEmail.Text = Customer.Email;
            txtPhoneNumber.Text = Customer.PhoneNumber;
            chkIsSubscribed.Checked = Customer.IsSubscribed;
            txtPhoneNumber.Text = Customer.PhoneNumber;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //navigate to the view page
        Response.Redirect("CustomerList.aspx");
    }
}
