using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTier
{
    public class DbOrder
    {
		DAL db;

		public DbOrder()
		{
			db = new DAL();
		}
        public DataSet getAllOrderWithInfo()

        {
            return db.ExecuteQueryDataSet("select * from view_Orders", CommandType.Text, null);
        }
        public DataSet getAllOrder()
        {
            return db.ExecuteQueryDataSet("select * from orders", CommandType.Text, null);
        }
        public DataSet getAllOrder(string id)
        {
            return db.ExecuteQueryDataSet("select * from orders where customer_id="+id, CommandType.Text, null);
        }
        public DataSet Income(string sold_date)
        {
            return db.ExecuteQueryDataSet("EXECUTE sp_GetIncome @sold_date=" + "'"+sold_date+"';", CommandType.Text, null);
            
        }
        public DataSet CountTotalbyYear(string year)
        {
            return db.ExecuteQueryDataSet("EXECUTE sp_countTotalbyYear @year=" + "'" + year + "';", CommandType.Text, null);

        }
        //public int getLastOrder()
        //{
        //    int ddd;
        //    DataTable dt = new DataTable();
        //    dt =  db.ExecuteQueryDataSet("select dbo.get_LastOrderId() as id", CommandType.Text, null).Tables[0];
        //    ddd = Int32.Parse(dt.Rows[0]["id"].ToString());
        //    return ddd;
        //}
        public int getRevenue()
        {
            return Int32.Parse(db.ExecuteScalarValue("select dbo.revenue_alltime()", CommandType.Text, null).ToString());
        }
        public int getOrderAmount()
        {
            return Int32.Parse(db.ExecuteScalarValue("select dbo.get_OrderNumber()", CommandType.Text, null).ToString());
        }
        public int getLastOrder()
        {
            return Int32.Parse(db.ExecuteScalarValue("select dbo.get_LastOrderId()", CommandType.Text, null).ToString());
        }
        public bool insertOrder(ref string err, int customer_id, int seller_id, DateTime sold_date, int total_money)
        {
            return db.MyExecuteNonQuery("sp_InsertOrder", CommandType.StoredProcedure, ref err, new SqlParameter("@customer_id", customer_id), new SqlParameter("@seller_id", seller_id), new SqlParameter("@sold_date", sold_date), new SqlParameter("@total_money", total_money));
        }
        public bool updateOrder(ref string err, int order_id, int customer_id, int seller_id, DateTime sold_date, int total_money)
        {
            return db.MyExecuteNonQuery("sp_UpdateOrder", CommandType.StoredProcedure, ref err, new SqlParameter("@order_id", order_id), new SqlParameter("@customer_id", customer_id), new SqlParameter("@seller_id", seller_id), new SqlParameter("@sold_date", sold_date), new SqlParameter("@total_money", total_money));
        }
        public bool deleteOrder(ref string err, int order_id)
        {
            return db.MyExecuteNonQuery("sp_DeleteOrder", CommandType.StoredProcedure, ref err, new SqlParameter("@order_id  ", order_id));
        }
        public bool deleteAllOfOrder(ref string err, int order_id)
        {
            return db.MyExecuteNonQuery("sp_deleteAllOD", CommandType.StoredProcedure, ref err, new SqlParameter("@order_id  ", order_id));
        }
        public DataSet find_YearsInOrder()
        {
            return db.ExecuteQueryDataSet("select * from dbo.find_YearsInOrder();", CommandType.Text, null);
        }
    }
   
}
