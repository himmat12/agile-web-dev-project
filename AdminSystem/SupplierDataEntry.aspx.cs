using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SupplierId;

    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierId = Convert.ToInt32(Session["SupplierId"]);

        if(IsPostBack == false)
        {
            if(SupplierId != -1)
            {
                DisplaySupplier();
            }
        }
    }

    void DisplaySupplier()
    {
        clsSupplierCollection SupplierList = new clsSupplierCollection();

        SupplierList.ThisSupplier.Find(SupplierId);

        txtId.Text = SupplierList.ThisSupplier.Id.ToString();
        txtName.Text = SupplierList.ThisSupplier.Name;
        txtEmail.Text = SupplierList.ThisSupplier.Email;
        txtPhone.Text = SupplierList.ThisSupplier.Phone;
        txtAddress.Text = SupplierList.ThisSupplier.Address;
        txtDateAdded.Text = SupplierList.ThisSupplier.DateAdded.ToString();
        checkActive.Checked = SupplierList.ThisSupplier.Active;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsSupplier Supplier = new clsSupplier();


        // validating input fields and only redirecting if the fields are not empty
        if (isValidInputFields() == true)
        {
            Supplier.Id = Convert.ToInt32(txtId.Text);
            Supplier.Name = txtName.Text;
            Supplier.Email = txtEmail.Text;
            Supplier.Phone = txtPhone.Text;
            Supplier.Address = txtAddress.Text;
            Supplier.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            Supplier.Active = Convert.ToBoolean(checkActive.Checked);

            clsSupplierCollection SupplierList = new clsSupplierCollection();


            if(SupplierId == -1)
            {
                SupplierList.ThisSupplier = Supplier;
                SupplierList.Add();
            }
            else
            {
                SupplierList.ThisSupplier.Find(SupplierId);

                SupplierList.ThisSupplier = Supplier;

                SupplierList.Update();
            }


            Session["Supplier"] = Supplier;
            Response.Redirect("SupplierList.aspx");
        }

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier Supplier = new clsSupplier();

        Int32 SupplierId;

        Boolean Found = false;

        // valid number regexp pattern
        String Pattern = @"^\d+$";

        if (txtId.Text.Length != 0)
        {

            if (Regex.IsMatch(txtId.Text, Pattern))
            {
            SupplierId = Convert.ToInt32(txtId.Text);
            Found = Supplier.Find(SupplierId);
            }
        }

        if (Found == true)
        {
            lblError.Text = "";
            txtId.Text = Convert.ToString(Supplier.Id);
            txtName.Text = Supplier.Name;
            txtPhone.Text = Supplier.Phone;
            txtEmail.Text = Supplier.Email;
            txtAddress.Text = Supplier.Address;
            txtDateAdded.Text = Convert.ToString(Supplier.DateAdded);
            checkActive.Checked = Supplier.Active;
        }
        else
        {
            resetFromFields();
            lblError.Text = "Data does not exists with the ID you are trying to find.";
        }
    }

    protected void resetFromFields()
    {
        txtId.Text = "";
        txtName.Text = "";
        txtEmail.Text =
        txtPhone.Text = "";
        txtAddress.Text = "";
        txtDateAdded.Text = "";
        checkActive.Checked = false;
        lblError.Text = "";
    }
    protected Boolean isValidInputFields()
    {
        if(txtId.Text.Length == 0)
        {
            lblError.Text = "Required field `ID` should not be empty.";
            return false;
        }
        else if (txtName.Text.Length == 0)
        {
            lblError.Text = "Required field `Name` should not be empty.";
            return false;
        }
        else
        if (txtEmail.Text.Length == 0)
        {
            lblError.Text = "Required field `Email` should not be empty.";
            return false;
        }
        else
        if (txtPhone.Text.Length == 0)
        {
            lblError.Text = "Required field `Phone` should not be empty.";
            return false;
        }
        else
        if (txtAddress.Text.Length == 0)
        {
            lblError.Text = "Required field `Address` should not be empty.";
            return false;
        }
        else
        if (txtDateAdded.Text.Length == 0)
        {
            lblError.Text = "Required field `Date Added` should not be empty.";
            return false;
        }
        else
        {
            lblError.Text = "";
            return true;
        }
    }

    protected void btnCancle_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierList.aspx");
    }
}