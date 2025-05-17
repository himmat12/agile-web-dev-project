using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsProductCollection
    {
        //private data member for the list
        private List<clsProduct> mProductList = new List<clsProduct>();

        //public property for the product list
        public List<clsProduct> ProductList
        {
            get
            {
                //return the private data
                return mProductList;
            }
            set
            {
                //set the private data
                mProductList = value;
            }
        }

        //public property for the count
        public int Count
        {
            get
            {
                //return the count of the list
                return mProductList.Count;
            }
            set
            {
                //later
            }
        }

        public clsProduct ThisProduct { get; set; }


        //constructor for the class
        public clsProductCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank product
                clsProduct AnProduct = new clsProduct();
                //get the product ID
                AnProduct.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                //get the name
                AnProduct.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                //get the price
                AnProduct.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                //get the in stock status
                AnProduct.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                //get the category
                AnProduct.Category = Convert.ToString(DB.DataTable.Rows[Index]["Category"]);
                //get the size
                AnProduct.Size = Convert.ToString(DB.DataTable.Rows[Index]["Size"]);
                //get the release date
                AnProduct.ReleasedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleasedDate"]);
                //add the record to the private data member
                mProductList.Add(AnProduct);
                //increment the index to move to the next record
                Index++;
            }
        }
    }
}
    
            