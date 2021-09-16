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
   public class DbBrand
    {
		DAL db;

		public DbBrand()
		{
			db = new DAL();
		}
        public string getBrandByID(int id)
        {
            return db.ExecuteScalarValue("select dbo.get_BrandNameById(" + id.ToString() + ")", CommandType.Text, null).ToString();
        }
        //public DataSet getBrandByID(string id)
        //{
        //    return db.ExecuteQueryDataSet("select * from brands where brand_id=" + id, CommandType.Text, null);
        //}
        public DataSet getAllBrand()
        {
            return db.ExecuteQueryDataSet("select * from brands", CommandType.Text, null);
        }
        public bool insertBrand(ref string err, string name)
        {
            return db.MyExecuteNonQuery("sp_InsertBrand", CommandType.StoredProcedure, ref err, new SqlParameter("@name", name));
        }
        public bool updateBrand(ref string err, string brand_id, string name)
        {
            return db.MyExecuteNonQuery("sp_UpdateBrand", CommandType.StoredProcedure, ref err, new SqlParameter("@brand_id", brand_id), new SqlParameter("@name", name));
        }

        public bool deleteBrand(ref string err, string brand_id)
        {
            return db.MyExecuteNonQuery("sp_DeleteBrand", CommandType.StoredProcedure, ref err, new SqlParameter("@brand_id ", brand_id));
        }
    } 
}
