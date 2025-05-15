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

        // Fix: Assign Salary as a string since clsStaff.Salary is of type string
        Staff.Salary = txtSalary.Text;

        Staff.EmploymentDate = Convert.ToDateTime(txtEmploymentDate.Text);
        Staff.IsActive = chkIsActive.Checked;

        //store the Staff on the session object
        Session["Staff"] = Staff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }
    protected void BtnFind_Click(object sender, EventArgs e)
    {   //create an instance of clsStaff
        clsStaff Staff = new clsStaff();
        //variable to store the primary key
        Int32 StaffId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = Staff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtName.Text = Staff.Name;
            txtEmail.Text = Staff.Email;
            txtContactNumber.Text = Staff.ContactNumber;
            txtSalary.Text = Staff.Salary;
            txtEmploymentDate.Text = Staff.EmploymentDate.ToString();
            chkIsActive.Checked = Staff.IsActive;
        }
    }



   
  

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}