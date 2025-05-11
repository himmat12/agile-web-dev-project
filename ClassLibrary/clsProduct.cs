using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        public bool InStock { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int ProductID { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
    }
}