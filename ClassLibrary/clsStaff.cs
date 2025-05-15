using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        // Private data members
        private Int32 mStaffId;
        private Boolean mActive;
        private DateTime mEmploymentDate;
        private string mEmail;
        private string mName;
        private string mContactNumber;
        private Int32 mSalary;

        // Public properties
        public int StaffId
        {
            get { return mStaffId; }
            set { mStaffId = value; }
        }

        public bool IsActive
        {
            get { return mActive; }
            set { mActive = value; }
        }

        public DateTime EmploymentDate
        {
            get { return mEmploymentDate; }
            set { mEmploymentDate = value; }
        }

        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string ContactNumber
        {
            get { return mContactNumber; }
            set { mContactNumber = value; }
        }

        public int IntSalary
        {
            get { return mSalary; }
            set { mSalary = value; }
        }

        // This property is only used in one test, for string comparison
        public string Salary
        {
            get { return mSalary.ToString(); }
            set
            {
                if (int.TryParse(value, out int result))
                {
                    mSalary = result;
                }
            }
        }

        // Find method stub for testing
        public bool Find(int StaffId)
        {
            clsDataConnection DB = new clsDataConnection();
            // Pass the StaffId to the database connection
            DB.AddParameter("@StaffID", StaffId);
            // Execute the stored procedure to find the record
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            // Check if any records were found
            if (DB.Count == 1)
            {
                // Get the data from the database
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                mEmploymentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["EmploymentDate"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mContactNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
                mSalary = (int)Convert.ToDecimal(DB.DataTable.Rows[0]["Salary"]);
               
                return true;
            }
            else
            {
                // If the StaffId is not found, return false
                return false;
            }
        }
    }
}
    
          




    