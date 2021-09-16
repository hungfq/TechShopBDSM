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
    public class DbCategory
    {
		DAL db;

		public DbCategory()
		{
			db = new DAL();
		}
        public string getCategoryByID(int id)
        {
            return db.ExecuteScalarValue("select dbo.get_CategoryNameById(" + id.ToString() + ")", CommandType.Text, null).ToString();
        }
        //public DataSet getCategoryByID(string id)
        //{
        //    return db.ExecuteQueryDataSet("select * from categories where category_id=" + id, CommandType.Text, null);
        //}
        public DataSet getAllCategory()
        {
            return db.ExecuteQueryDataSet("select * from categories", CommandType.Text, null);
        }
        public bool insertCategory(ref string err, string name)
        {
            return db.MyExecuteNonQuery("sp_InsertCategory", CommandType.StoredProcedure, ref err, new SqlParameter("@name", name));
        }
        public bool updateCategory(ref string err, string category_id, string name)
        {
            return db.MyExecuteNonQuery("sp_UpdateCategory", CommandType.StoredProcedure, ref err, new SqlParameter("@category_id", category_id), new SqlParameter("@name", name));
        }

        public bool deleteCategory(ref string err, string category_id)
        {
            return db.MyExecuteNonQuery("sp_DeleteCategory", CommandType.StoredProcedure, ref err, new SqlParameter("@category_id ", category_id));
        }
    }
}
