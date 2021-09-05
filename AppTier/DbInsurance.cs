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
        public bool insertInsurance(ref string err, string time)
        {
            return db.MyExecuteNonQuery("sp_InsertRole", CommandType.StoredProcedure, ref err, new SqlParameter("@time", time));
        }
        public bool updateInsurance(ref string err, int insurance_id, string time)
        {
            return db.MyExecuteNonQuery("sp_UpdateRole", CommandType.StoredProcedure, ref err, new SqlParameter("@insurance_id", insurance_id), new SqlParameter("@time ", time));
        }
        public bool deleteInsurance(ref string err, string insurance_id)
        {
            return db.MyExecuteNonQuery("sp_DeleteRole", CommandType.StoredProcedure, ref err, new SqlParameter("@insurance_id", insurance_id));
        }
    }
}
