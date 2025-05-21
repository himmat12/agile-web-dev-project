using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        public clsSupplierCollection() {

            //clsSupplier TestItem = new clsSupplier();

            //TestItem.Id = 1;
            //TestItem.Name = "Himmat";
            //TestItem.Email = "himmat@gmail.com";
            //TestItem.Phone = "1234567898";
            //TestItem.Address = "Leicester";
            //TestItem.DateAdded = DateTime.Now;
            //TestItem.Active = true;

            //supplierList.Add(TestItem);

            //TestItem = new clsSupplier();

            //TestItem.Id = 2;
            //TestItem.Name = "John";
            //TestItem.Email = "john@gmail.com";
            //TestItem.Phone = "1234567898";
            //TestItem.Address = "York";
            //TestItem.DateAdded = DateTime.Now;
            //TestItem.Active = true;

            //supplierList.Add(TestItem);

            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblSupplier_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsSupplier Supplier = new clsSupplier();

                Supplier.Id = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                Supplier.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                Supplier.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                Supplier.Phone = Convert.ToString(DB.DataTable.Rows[Index]["Phone"]);
                Supplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                Supplier.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["CreatedAt"]);
                Supplier.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);

                supplierList.Add(Supplier);

                Index++;

            }

        }

        List<clsSupplier> supplierList = new List<clsSupplier>(); 

        clsSupplier mThisSupplier = new clsSupplier();

        public List<clsSupplier> SupplierList { get { return supplierList; } set{ supplierList = value; } }
        public int Count { get{ return SupplierList.Count; } set{ } }
        public clsSupplier ThisSupplier { get{ return mThisSupplier; } set{mThisSupplier = value; } }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Name", mThisSupplier.Name);
            DB.AddParameter("@Email", mThisSupplier.Email);
            DB.AddParameter("@Phone", mThisSupplier.Phone);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@IsActive", mThisSupplier.Active);
            DB.AddParameter("@CreatedAt", mThisSupplier.DateAdded);

            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SupplierId", mThisSupplier.Id);
            DB.AddParameter("@Name", mThisSupplier.Name);
            DB.AddParameter("@Email", mThisSupplier.Email);
            DB.AddParameter("@Phone", mThisSupplier.Phone);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@IsActive", mThisSupplier.Active);
            DB.AddParameter("@CreatedAt", mThisSupplier.DateAdded);

            DB.Execute("sproc_tblSupplier_Update");
        }

        public void Delete(int primaryKey)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SupplierId", mThisSupplier.Id);

            DB.Execute("sproc_tblSupplier_Delete");
        }
    }
}
