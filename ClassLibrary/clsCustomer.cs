using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int customerId;
        public DateTime DateAdded { get; set; }
        public bool IsSubscribed { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}