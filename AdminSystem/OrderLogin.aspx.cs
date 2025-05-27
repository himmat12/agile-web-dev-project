using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    //TODO: add authenication, add cancel to go to main menu when implemented

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create instance of the user class
        clsOrderUser AnUser = new clsOrderUser();
        //store the username and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //create variable to store the result of find user
        Boolean Found = false;
        //get the username and password entered by user
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(UserName, Password);
        //if username or password empty
        if (txtUserName.Text == "")
        {
            lblError.Text += "Enter a username ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text += "Enter a password ";
        }
        //if found
        if (Found == true)
        {
            //redirects to list page
            Response.Redirect("OrderList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text += "Login details are incorrect. Please try again ";
        }
    }
}