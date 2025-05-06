using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public bool OrderPaid { get; set; }
        public float OrderTotalPrice { get; set; }
        public int CustomerID { get; set; }
        public int StaffID { get; set; }
    }
}