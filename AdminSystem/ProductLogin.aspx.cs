using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class ProductLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an istance of the product user class
        clsProductUser ProductUser = new clsProductUser();
        //create a variable to store the username and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //create a variable to store the result of the FindUser method
        bool Found = false;
        //get the username entered by the user
        UserName = Convert.ToString(txtUserName.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = ProductUser.FindUser(UserName, Password);
        //if username and/or passwrod is empty
        if (txtUserName.Text =="")
        {
            //display a message to the user
            lblError.Text = "Please enter a username";
        }
        else if (txtPassword.Text == "")
        {
            //display a message to the user
            lblError.Text = "Please enter a password";
        }
        else if (Found == true)
        {
            //if the user is found, redirect to the product page
            Response.Redirect("ProductList.aspx");
        }
        else if (Found == false)
        {
            //if the user is not found, display an error message
            lblError.Text = "Invalid username or password. Please try again.";
        }
    }
}