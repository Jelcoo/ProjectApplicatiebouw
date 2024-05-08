using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ChapeauDAL
{
    public class BaseDao
    {
        private SqlConnection _conn;

        public BaseDao()
        {
            _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString);
        }

        protected SqlConnection OpenConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                //Print.ErrorLog(e);
                throw;
            }
            return conn;
        }

        protected void CloseConnection()
        {
            conn.Close();
        }
    }
}

