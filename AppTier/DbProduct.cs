using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;

namespace AppTier
{
    public class DbProduct
    {
        DAL db;

		public DbProduct()
		{
			db = new DAL();
		}
		public DataSet getProduct()
		{
			return db.ExecuteQueryDataSet("select * from products", CommandType.Text, null);
		}
        public bool insertProduct(ref string err, string name, decimal price, string image, int brand_id, int category_id, int insurance_id)
        {
            return db.MyExecuteNonQuery("sp_InsertProduct", CommandType.StoredProcedure, ref err, new SqlParameter("@name", name), new SqlParameter("@price", price), new SqlParameter("@image", image), new SqlParameter("@brand_id", brand_id), new SqlParameter("@category_id", category_id), new SqlParameter("@brand_id", insurance_id));
        }
        public bool updateProduct(ref string err, string product_id, string name, decimal price, string image, int brand_id, int category_id, int insurance_id)
        {
            return db.MyExecuteNonQuery("sp_UpdateProduct", CommandType.StoredProcedure, ref err, new SqlParameter("@product_id", product_id), new SqlParameter("@name", name), new SqlParameter("@price", price), new SqlParameter("@image", image), new SqlParameter("@brand_id", brand_id), new SqlParameter("@category_id", category_id), new SqlParameter("@brand_id", insurance_id));
        }
        public bool deleteProduct(ref string err, string product_id)
        {
            return db.MyExecuteNonQuery("sp_DeleteProduct", CommandType.StoredProcedure, ref err, new SqlParameter("@product_id ", product_id));
        }
    }

}
