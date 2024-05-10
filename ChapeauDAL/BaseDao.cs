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
                if (_conn.State == ConnectionState.Closed || _conn.State == ConnectionState.Broken)
                {
                    _conn.Open();
                }
            }
            catch (Exception e)
            {
                //Print.ErrorLog(e);
                throw;
            }
            return _conn;
        }

        protected void CloseConnection()
        {
            _conn.Close();
        }
    }
}
