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
    public class baseDao
    {
        private SqlDataAdapter _adapter;
        private SqlConnection _conn;

        public baseDao()
        {
            _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString);
            _adapter = new SqlDataAdapter();
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

        private void CloseConnection()
        {
            _conn.Close();
        }

        /* For Insert/Update/Delete Queries */
        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                _adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        /* For Select Queries */
        protected DataTable ExecuteSelectQuery(string query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                _adapter.SelectCommand = command;
                _adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                throw;
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }
    }
}

