using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public int StaffId { get; private set; }

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
        Staff.Salary = txtSalary.Text;
        Staff.EmploymentDate = Convert.ToDateTime(txtEmploymentDate.Text);
        Staff.IsActive = chkIsActive.Checked;

       

        // Fix: Declare the 'Error' variable before using it
        string Error = "";

        // Fix: Correct the syntax by closing the method call with a closing parenthesis
        Error = Staff.Valid(Staff.EmploymentDate.ToString("yyyy-MM-dd"),  Staff.Email, Staff.Name, Staff.ContactNumber, Staff.Salary);

        //validate the data on the web form
        if (Error == "")
        {
            Staff.StaffId = Convert.ToInt32(txtStaffID.Text);
            Staff.ContactNumber = txtContactNumber.Text;
            Staff.Email = txtEmail.Text;
            Staff.Name = txtName.Text;
            Staff.EmploymentDate = Convert.ToDateTime(txtEmploymentDate.Text);
            Staff.Salary = txtSalary.Text;
            Staff.IsActive = Convert.ToBoolean(chkIsActive.Checked);

            clsStaffCollection StaffList = new clsStaffCollection();
            StaffList.ThisStaff = Staff;
            StaffList.Add();


            Session["Staff"] = Staff;
            //navigate to the view page
            Response.Redirect("StaffList.aspx");
        }
        else
        {             //display the error message
            lblError.Text = "There were problems with the data entered" + Error;
        }
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