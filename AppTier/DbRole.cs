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
    public class DbRole
    {
        DAL db;

        public DbRole()
        {
            db = new DAL();
        }
        public DataSet getAll()
        {
            return db.ExecuteQueryDataSet("select * from roles",
                CommandType.Text, null);
        }
        public DataSet getRoleByID(string id)
        {
            return db.ExecuteQueryDataSet("select * from roles where role_id="+id,
                CommandType.Text, null);
        }
        public bool insertRole(ref string err, string name)
        {
            return db.MyExecuteNonQuery("sp_InsertRole", CommandType.StoredProcedure, ref err,  new SqlParameter("@name", name));
        }
        public bool updateRole(ref string err, int role_id, string name)
        {
            return db.MyExecuteNonQuery("sp_UpdateRole", CommandType.StoredProcedure, ref err, new SqlParameter("@role_id", role_id), new SqlParameter("@name", name));
        }
        public bool deleteRole(ref string err, string role_id)
        {
            return db.MyExecuteNonQuery("sp_DeleteRole", CommandType.StoredProcedure, ref err, new SqlParameter("@role_id", role_id));
        }
    }
    
}
