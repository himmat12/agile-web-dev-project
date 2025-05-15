using System;
using System.Collections.Generic;
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
    protected void BtnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff Staff = new clsStaff();
        //capture the Name
        Staff.StaffId = Convert.ToInt32(txtStaffID.Text);
        Staff.Name = txtName.Text;
        Staff.Email = txtEmail.Text;
        Staff.ContactNumber = txtContactNumber.Text;
        //Staff.Salary = (int)Convert.ToDecimal(txtSalary.Text);
        Staff.EmploymentDate = Convert.ToDateTime(txtEmploymentDate.Text);
        //Staff.Active = chkIsActive.Checked;

        //store the Staff on the session object
        Session["Staff"] = Staff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }



}