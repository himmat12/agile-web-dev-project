using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class SupplierLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = "";
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsSupplierUser AnUser = new clsSupplierUser();
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;

        Boolean Found = false;

        Username = Convert.ToString(txtUsername.Text);
        Password = Convert.ToString(txtPassword.Text);

        Found = AnUser.FindUser(Username, Password);

        if (txtUsername.Text == "")
        {
            lblError.Text = "Enter a username";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a password";
        }
        else if (Found == true)
        {
            Session.Add("username", Username);

            Response.Redirect("SupplierList.aspx");
        }
    }

    protected void btnCancle_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");

    }
}