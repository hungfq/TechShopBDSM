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
    public class DbUser
    {
        DAL db;

        public DbUser()
        {
            db = new DAL();
        }

        public bool insertUser(ref string err, string name, string phone_number, int role_id, string username, string password)
        {
            return db.MyExecuteNonQuery("sp_InsertUser", CommandType.StoredProcedure, ref err,  new SqlParameter("@phone_number", phone_number), new SqlParameter("@role_id", role_id), new SqlParameter("@username", username), new SqlParameter("@phone_number", password));
        }
        public bool updateUser(ref string err, string user_id, string name, string phone_number, int role_id, string username, string password)
        {
            return db.MyExecuteNonQuery("sp_UpdateUser", CommandType.StoredProcedure, ref err, new SqlParameter("@user_id", user_id), new SqlParameter("@phone_number", phone_number), new SqlParameter("@role_id", role_id), new SqlParameter("@username", username), new SqlParameter("@phone_number", password));
        }
        public bool deleteUser(ref string err, string user_id)
        {
            return db.MyExecuteNonQuery("sp_DeleteUser", CommandType.StoredProcedure, ref err, new SqlParameter("@user_id ", user_id));
        }
    }
}
