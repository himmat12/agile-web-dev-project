using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{

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
            //add the details to session
            //add session to record user information
            Session["AnUser"] = AnUser;

            //check department
            //wrong department
            if (AnUser.Department != "Orders")
            {
                lblError.Text = "This user belongs to the wrong department - Please return to the main menu.";
                
            }
            //right department
            else 
            {
                //redirects to list page
                Response.Redirect("OrderList.aspx");
            }
                
        }
        else if (Found == false)
        {
            lblError.Text += "Login details are incorrect. Please try again ";
        }
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}