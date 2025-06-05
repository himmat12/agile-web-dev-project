using System;

namespace ClassLibrary
{
    public class clsCustomerUser
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
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);

            DB.Execute("sproc_tblUsers_FindUserNamePWCustomers");

            if (DB.Count == 1)
            {
                //set the private data members to the values from the database
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to indicate that the user was found
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}