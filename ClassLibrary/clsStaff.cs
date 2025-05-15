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
            // Simulate finding a record with StaffId = 21
            if (StaffId == 21)
            {
                mStaffId = 21;
                mActive = true;
                mEmploymentDate = Convert.ToDateTime("23/12/2022");
                mEmail = "maya@gmail.com";
                mName = "maya";
                mContactNumber = "123";
                mSalary = 250;
                return true;
            }
            return false;
        }
    }
}  

    