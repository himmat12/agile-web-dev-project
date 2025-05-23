using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsProductCollection
    {
        //private data member for ThisProduct
        private clsProduct mThisProduct = new clsProduct();

        //public property for ThisProduct
        public clsProduct ThisProduct
        {
            get
            {
                //return the private data
                return mThisProduct;
            }
            set
            {
                //set the private data
                mThisProduct = value;
            }
        }

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

        public int Add()
        {
            //adds the record to the database based on the values of ThisProduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisProduct.Name);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@InStock", mThisProduct.InStock);
            DB.AddParameter("@Category", mThisProduct.Category);
            DB.AddParameter("@Size", mThisProduct.Size);
            DB.AddParameter("@ReleasedDate", mThisProduct.ReleasedDate);
            //execute the stored procedure
            return DB.Execute("sproc_tblProduct_Insert");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            DB.AddParameter("@Name", mThisProduct.Name);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@InStock", mThisProduct.InStock);
            DB.AddParameter("@Category", mThisProduct.Category);
            DB.AddParameter("@Size", mThisProduct.Size);
            DB.AddParameter("@ReleasedDate", mThisProduct.ReleasedDate);

            DB.Execute("sproc_tblProduct_Update");
        }

        public void Delete()
        {
            //delet the record pointed to by thisproduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_Delete");
        }
    }
}
    
            