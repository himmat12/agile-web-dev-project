using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public  class clsSupplierUser
    {

        private Int32 mUserId;
        private String mUsername;
        private String mPassword;
        private String mDepartment;

        public int UserId { get { return mUserId; }  set { mUserId = value; } }
        public string Username { get { return mUsername; }  set { mUsername = value; } }
        public string Password { get { return mPassword; }  set { mPassword = value; } }
        public string Department { get { return mDepartment; }  set { mDepartment = value; } }

       public  bool FindUser(string Username, string Password)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Username", Username);
            DB.AddParameter("@Password", Password);

            DB.Execute("sproc_tblUsers_FindUserNamePW");

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
