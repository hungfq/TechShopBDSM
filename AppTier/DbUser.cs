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
        public DataSet getUserInfo(string id)
        {
            return db.ExecuteQueryDataSet("select users.user_id as id, users.name as u_name, roles.name as r_name" +
                " from users inner join roles" +
                " on users.role_id = roles.role_id" +
                " where users.user_id = "+ id,
                CommandType.Text, null);
        }
        public string getUserById(string id)
        {
            return db.ExecuteScalarValue("select dbo.get_UserNameById(" + id.ToString() + ")", CommandType.Text, null).ToString();
        }
        public DataSet checkLogin(string username, string password)
        {
            return db.ExecuteQueryDataSet("select  dbo.check_Login('" + username + "','" + password + "') as login",
                CommandType.Text, null);
        }
        public int checkLogin2(string username, string password)
        {
            DataSet dt = new DataSet();
            dt = db.ExecuteQueryDataSet("select  dbo.check_Login('" + username + "','" + password + "') as login",
                CommandType.Text, null);
            int id = -1;
            if (dt != null)
            {
                DataRow dr = dt.Tables[0].Rows[0];
                if(dr["login"].ToString() != string.Empty)
                    id = Int32.Parse(dr["login"].ToString());

            }
            return id;
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
