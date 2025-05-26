using System;

namespace ClassLibrary
{
    public class clsProductUser
    {

        //private data member for UserID
        private Int32 mUserID;
        //private data member for UserName
        private string mUserName;
        //private data member for Password
        private string mPassword;
        //private data member for Department
        private string mDepartment;


        public int UserID
        {
            get { return mUserID; } //return priavte data
            set { mUserID = value; } //set private data
        }

        public string UserName
        {
            get { return mUserName; } //return private data
            set { mUserName = value; } //set private data
        }
        public string Password
        { 
            get { return mPassword; } //return private data
            set { mPassword = value; } //set private data
        }

        public string Department
        {
            get { return mDepartment; } //return private data
            set { mDepartment = value; } //set private data
        }

        public bool FindUser(string userName, string password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the user username and password to search for
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);
            //execute the stored procedure to find the user
            DB.Execute("sproc_tblUsers_FindUserNamePW_Products");
            //if one record is found
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
                //if no record is found return false
                return false;
            }
        }
    }
}