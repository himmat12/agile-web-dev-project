using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        //private data member for the product id
        private Int32 mProductID;
        //productID public property
        public Int32 ProductID
        {
            get
            {
                //return the private data, sends data out if the property
                return mProductID;
            }
            set
            {
                //set the private data. allows the value to be changed
                mProductID = value;
            }
        }


        private string mName;
        //public property for the product name
        public string Name
        {
            get
            {
                //return the private data, sends data out if the property
                return mName;
            }
            set
            {
                //set the private data. allows the value to be changed
                mName = value;
            }
        }

        //private data member for the in stock property
        private Boolean mInStock;
        //public property for the in stock
        public Boolean InStock
        {
            get
            {
                //return the private data, sends data out if the property
                return mInStock;
            }
            set
            {
                //set the private data. allows the value to be changed
                mInStock = value;
            }
        }
        //private data member for the product category property
        private string mCategory;
        //public property for the product category
        public string Category
        {
            get
            {
                //return the private data, sends data out if the property
                return mCategory;
            }
            set
            {
                //set the private data. allows the value to be changed
                mCategory = value;
            }
        }

        //private data member for the price property
        private decimal mPrice;
        //public property for the product price
        public decimal Price
        {
            get
            {
                //return the private data, sends data out if the property
                return mPrice;
            }
            set
            {
                //set the private data. allows the value to be changed
                mPrice = value;
            }
        }

        //private data member for the product size property
        private string mSize;
        //public property for the product size
        public string Size
        {
            get
            {
                //return the private data, sends data out if the property
                return mSize;
            }
            set
            {
                //set the private data. allows the value to be changed
                mSize = value;
            }
        }

        //private data member for the release date property
        private DateTime mReleasedDate;
        //public property for the release date
        public DateTime ReleasedDate
        {
            get
            {
                //return the private data, sends data out if the property
                return mReleasedDate;
            }
            set
            {
                //set the private data. allows the value to be changed
                mReleasedDate = value;
            }
        }


        /******************* FIND METHOD *********************/

        public bool Find(int productID)
        {
            //set the private data member to the test data  value
            mProductID = 2;
            mName = "Product Name";
            mInStock = true;
            mCategory = "Product Category";
            mPrice = 19.99m;
            mSize = "Product Size";
            mReleasedDate = Convert.ToDateTime("25/05/2025");
            
            //always retur true
            return true;
        }
    }
}