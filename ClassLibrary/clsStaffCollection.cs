using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        public clsStaffCollection()
        {
            //create the items of test data
            //  clsStaff TestItem = new clsStaff();
            //set its properties
            //  TestItem.IsActive = true;
            //  TestItem.StaffId = 2;
            //  TestItem.Name = "V";
            //  TestItem.Salary = "100";
            //  TestItem.ContactNumber = "12345";
            //   TestItem.Email = "yes@gmail.com";
            //  TestItem.EmploymentDate = DateTime.Now.Date;
            //add the test item to the test list
            //  mStaffList.Add(TestItem);
            //re initialise the object for some new data
            //   TestItem = new clsStaff();
            //set its properties
            // TestItem.IsActive = true;
            //  TestItem.StaffId = 3;
            //  TestItem.Name = "Vee";
            //  TestItem.Salary = "300";
            //  TestItem.ContactNumber = "8888";
            //  TestItem.Email = "No@gmail.com";
            //  TestItem.EmploymentDate = DateTime.Now.Date;
            //add the item to the test list
            //  mStaffList.Add(TestItem);

            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStaff_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsStaff Staff = new clsStaff();

                Staff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                Staff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                Staff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                Staff.ContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactNumber"]);
                Staff.Salary = Convert.ToString(DB.DataTable.Rows[Index]["Salary"]);
                Staff.EmploymentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["EmploymentDate"]);
                Staff.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);

                StaffList.Add(Staff);

                Index++;
            }
        }
        //private data memeber for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;

            }
            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //

            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@ContactNumber", mThisStaff.ContactNumber);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@IsActive", mThisStaff.IsActive);
            DB.AddParameter("@EmploymentDate", mThisStaff.EmploymentDate);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}