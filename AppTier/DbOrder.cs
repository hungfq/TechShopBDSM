<<<<<<< HEAD
﻿using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

=======
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
>>>>>>> f00ce9fb19de5e541dc10fd9f1a984b83c32d7db
namespace AppTier
{
    public class DbOrder
    {
		DAL db;

		public DbOrder()
		{
			db = new DAL();
		}
<<<<<<< HEAD
		public DataSet getAllOrder()
		{
			return db.ExecuteQueryDataSet("select * from orders", CommandType.Text, null);
		}
	}
=======
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
    }
   
>>>>>>> f00ce9fb19de5e541dc10fd9f1a984b83c32d7db
}