using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTier
{
    public class DbCustomer
    {
		DAL db;

		public DbCustomer()
		{
			db = new DAL();
		}
		public DataSet getAllCustomer()
		{
			return db.ExecuteQueryDataSet("select * from customers", CommandType.Text, null);
		}
	}
}
