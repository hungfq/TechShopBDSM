using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
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
		public DataSet getAllOrder()
		{
			return db.ExecuteQueryDataSet("select * from orders", CommandType.Text, null);
		}
	}
}
