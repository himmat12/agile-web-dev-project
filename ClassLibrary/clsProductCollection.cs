using System;
using System.Collections.Generic;
using System.ComponentModel;

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
            {
                clsDataConnection DB = new clsDataConnection();
                DB.Execute("sproc_tblProduct_SelectAll");
                PopulateArray(DB); // now uses shared logic
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

        public void ReportByCategory(string Category)
        {
            //filters the record based on a category ( full or partial)
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the category
            DB.AddParameter("@Category", Category);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_FilterByCategory");
            //populate the array list with the data table in DB
            PopulateArray(DB);
        }

        //FUNCTION THAT POPULATES THE ARRAY LIST///

        private void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mProductList = new List<clsProduct>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank product
                clsProduct AnProduct = new clsProduct();
                // read in the fields from the current record

                AnProduct.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["productID"]);
                AnProduct.Name = Convert.ToString(DB.DataTable.Rows[Index]["name"]);
                AnProduct.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["price"]);
                AnProduct.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["inStock"]);
                AnProduct.Category = Convert.ToString(DB.DataTable.Rows[Index]["category"]);
                AnProduct.Size = Convert.ToString(DB.DataTable.Rows[Index]["size"]);
                AnProduct.ReleasedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["releasedDate"]);
                //add the record to the private data member
                mProductList.Add(AnProduct);
                //increment the index to move to the next record
                Index++;

            }
        }
    }


  }

    
            