using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class clsStaffUser
    {

        private Int32 mUserId;
        private String mUsername;
        private String mPassword;
        private String mDepartment;


        public int UserId { get { return mUserId; } set { mUserId = value; } }
        public string Username { get { return mUsername; } set { mUsername = value; } }
        public string Password { get { return mPassword; } set { mPassword = value; } }
        public string Department { get { return mDepartment; } set { mDepartment = value; } }

        public bool FindUser(string username, string password)
        {
            clsDataConnection DB = new clsDataConnection();

            // Use the method parameters, not the properties
            DB.AddParameter("@Username", username);
            DB.AddParameter("@Password", password);

            DB.Execute("sproc_tblUsers_FindUserNamePWStaff");

            if (DB.Count == 1)
            {
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}