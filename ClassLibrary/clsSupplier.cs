using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private Int32 id;
        private Boolean active;
        private DateTime dateAdded;
        private String name;
        private String email;
        private String phone;
        private String address;

        public int Id { get { return id; } set { id = value;} }
        public bool Active { get { return active; } set { active = value; } }
        public DateTime DateAdded { get { return dateAdded; } set { dateAdded = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Address { get { return address; } set { address = value; } }

        public bool Find(int SupplierId)
        {
            //id = 1;
            //name = "Himmat";
            //email = "himmat@gmail.com";
            //phone = "123";
            //address = "Leicester";
            //active = true;
            //dateAdded = Convert.ToDateTime("09/05/2025");

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SupplierId", SupplierId);

            DB.Execute("sproc_tblSupplier_FilterBySupplierId");

            if(DB.Count == 1)
            {
                id = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                name = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                phone = Convert.ToString(DB.DataTable.Rows[0]["Phone"]);
                address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                active = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                dateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["CreatedAt"]);

                return true;
            }

            return false;
        }

        public String ValidData(String name, String email, String phone, String address, String dateAdded)
        {
            String Error = "";

            DateTime DateTemp;

            // name field 
            if(name.Length == 0)
            {
                Error = Error + "The name may not be blank : "; 
            }

            if (name.Length > 50)
            {
                Error = Error + "The name must be less than 50 characters : ";
            }

            // email field 
            if (email.Length == 0)
            {
                Error = Error + "The email may not be blank : ";
            }

            if (email.Length > 50)
            {
                Error = Error + "The email must be less than 50 characters : ";
            }

            // phone field 
            if (phone.Length == 0)
            {
                Error = Error + "The phone may not be blank : ";
            }

            if (phone.Length > 20)
            {
                Error = Error + "The phone must be less than 20 characters : ";
            }


            // address field 
            if (address.Length == 0)
            {
                Error = Error + "The address may not be blank : ";
            }

            if (address.Length > 50)
            {
                Error = Error + "The address must be less than 50 characters : ";
            }


            // added date field 
            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);

                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }



            return Error;
        }
    }
}
