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
    public class DbInsurance
    {
		DAL db;

		public DbInsurance()
		{
			db = new DAL();
		}
        public DataSet getInsuranceByID(string id)
        {
            return db.ExecuteQueryDataSet("select * from insurances where insurance_id=" + id, CommandType.Text, null);
        }
        public DataSet getAllInsurance()
        {
            return db.ExecuteQueryDataSet("select * from insurances", CommandType.Text, null);
        }
        public bool insertInsurance(ref string err, string time)
        {
            return db.MyExecuteNonQuery("sp_InsertInsurance", CommandType.StoredProcedure, ref err, new SqlParameter("@time", time));
        }
        public bool updateInsurance(ref string err, int insurance_id, string time)
        {
            return db.MyExecuteNonQuery("sp_UpdateInsurance", CommandType.StoredProcedure, ref err, new SqlParameter("@insurance_id", insurance_id), new SqlParameter("@time ", time));
        }
        public bool deleteInsurance(ref string err, string insurance_id)
        {
            return db.MyExecuteNonQuery("sp_DeleteInsurance", CommandType.StoredProcedure, ref err, new SqlParameter("@insurance_id", insurance_id));
        }
    }
}
