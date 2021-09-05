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
    public class DbOrderDetail
    {
		DAL db;

		public DbOrderDetail()
		{
			db = new DAL();
		}
        public DataSet getOrderDetail(string id)
        {
            return db.ExecuteQueryDataSet("select * from orderdetails where order_id=" + id, CommandType.Text, null);
        }
        public bool insertOrderDetail(ref string err,  int product_id, int order_id, int quantity)
        {
            return db.MyExecuteNonQuery("sp_InsertOrderDetail", CommandType.StoredProcedure, ref err, new SqlParameter("@product_id", product_id), new SqlParameter("@order_id", order_id), new SqlParameter("@quantity", quantity));
        }
        public bool updateOrderDetail(ref string err, int orderdetail_id, int product_id, int order_id, int quantity)
        {
            return db.MyExecuteNonQuery("sp_UpdateOrderDetail", CommandType.StoredProcedure, ref err, new SqlParameter("@orderdetail_id", orderdetail_id), new SqlParameter("@product_id", product_id), new SqlParameter("@order_id", order_id), new SqlParameter("@quantity", quantity));
        }
        public bool deleteOrderDetail(ref string err, int orderdetail_id)
        {
            return db.MyExecuteNonQuery("sp_DeleteOrderDetail", CommandType.StoredProcedure, ref err, new SqlParameter("@orderdetail_id  ", orderdetail_id));
        }
    }
}
