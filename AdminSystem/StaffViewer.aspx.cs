using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff Staff = new clsStaff();
        //get the data from the session object
        Staff = (clsStaff)Session["Staff"];
        //display the Name for this entry
        Response.Write(Staff.Name);
        Response.Write(Staff.Salary);
        Response.Write(Staff.EmploymentDate);
        Response.Write(Staff.IsActive);
        //capture the EmploymentDate
        Staff.EmploymentDate = Convert.ToDateTime(DateTime.Now);
        //Capture the Salary
        Staff.Salary = (int)Convert.ToDecimal(txtSalary.Text);
        //Capture IsActive check box
        Staff.IsActive = chkIsActive.Checked;
    }
}