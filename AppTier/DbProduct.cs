using System;
using System.Collections.Generic;
using System.Data;
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
		public DataSet getAllProduct()
		{
			return db.ExecuteQueryDataSet("select * from products", CommandType.Text, null);
		}
		public DataSet getProduct(int id)
		{
			return db.ExecuteQueryDataSet("select * from products where product_id = " + id.ToString(), CommandType.Text, null);
		}
	}

}
