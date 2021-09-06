using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppTier
{
    public class DbCustomer
    {
		DAL db;

		public DbCustomer()
		{
			db = new DAL();
		}
        public DataSet getCustomerById(string id)
        {
            return db.ExecuteQueryDataSet("select * from customers where customer_id=" + id, CommandType.Text, null);
        }
        public DataSet getAllCustomer()

		{
			return db.ExecuteQueryDataSet("select * from customers", CommandType.Text, null);
		}
        public bool insertCustomer(ref string err, string name, int age, string phone_number)
        {
            return db.MyExecuteNonQuery("sp_InsertCustomer", CommandType.StoredProcedure, ref err, new SqlParameter("@phone_number", phone_number), new SqlParameter("@name", name), new SqlParameter("@age", age));
        }
        public bool updateCustomer(ref string err, string customer_id, string name, int  age,  string phone_number)
        {
            return db.MyExecuteNonQuery("sp_UpdateCustomer", CommandType.StoredProcedure, ref err, new SqlParameter("@customer_id",customer_id), new SqlParameter("@phone_number", phone_number), new SqlParameter("@name", name), new SqlParameter("@age", age));
        }
        public bool deleteCustomer(ref string err, string customer_id)
        {
            return db.MyExecuteNonQuery("sp_DeleteCustomer", CommandType.StoredProcedure, ref err, new SqlParameter("@customer_id ", customer_id));
        }
    }
}
