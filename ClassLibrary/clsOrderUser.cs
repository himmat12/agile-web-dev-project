using System;
using System.Globalization;

namespace ClassLibrary
{
    public class clsOrderUser
    {
        private Int32 mUserID;
        private String mUserName;
        private String mPassword;
        private String mDepartment;

        public int UserID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }
        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the user username and password to search for
            DB.AddParameter("@Username", UserName);
            DB.AddParameter("@Password", Password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm evertying worked ok
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}