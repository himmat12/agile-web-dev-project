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
            id = 1;
            name = "Himmat";
            email = "himmat@gmail.com";
            phone = "123";
            address = "Leicester";
            active = true;
            dateAdded = Convert.ToDateTime("09/05/2025");

            return true;
        }
    }
}
