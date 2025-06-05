using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsStaffUser AnUser = new clsStaffUser();
        string Username = txtUserName.Text;
        string Password = txtPassword.Text;

        Boolean Found = false;

        Username = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);

        Found = AnUser.FindUser(Username, Password);

        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a username";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a password";
        }
        else if (Found == true)
        {
            Response.Redirect("CustomerList.aspx");
        }
    } 
}
