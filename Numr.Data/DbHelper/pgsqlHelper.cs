using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Numr.Business.Entities;
using Z.Dapper.Plus;

namespace Numr.Data.DbHelper
{
   public class PgsqlHelper : IDbHelper
    {

        NpgsqlConnection Connection= new NpgsqlConnection(DataSettings.ConnectionString); 

        public DBResult ExecuteNonQuery(string query)
        {

            DBResult Result = new DBResult();
            try
            {
                if (OpenDataBaseConnection())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                    Result.Result = cmd.ExecuteNonQuery();
                    Result.IsSucceess = true;
                }
            }
            catch (NpgsqlException ex)
            {
                Result.IsSucceess = false;
                Result.ErrorMessage = ex.Message;
                Result.ErrorCommandQuery = ex.InnerException.ToString();
            }
            finally
            {
                Connection.Close();
            }
            return Result;
        }

        public DBResult ExecuteSelectQuery(string query)
        {
            DBResult Result = new DBResult();
            try
            {
                if (OpenDataBaseConnection())
                {
                    DataTable result = new DataTable();
                    NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    da.Fill(result);
                    Result.Result = da;
                    Result.IsSucceess = true;
                }
            }
            catch (NpgsqlException ex)
            {
                Result.IsSucceess = false;
                Result.ErrorMessage = ex.Message;
                Result.ErrorCommandQuery = ex.InnerException.ToString();
            }
            finally
            {
                Connection.Close();
            }
            return Result;
        }

        public DBResult ExecuteScalar(string query)
        {
            DBResult Result = new DBResult();
            try
            {
                if (OpenDataBaseConnection())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
                    Result.Result = cmd.ExecuteScalar();
                    Result.IsSucceess = true;
                }
            }
            catch (NpgsqlException ex)
            {
                Result.IsSucceess = false;
                Result.ErrorMessage = ex.Message;
                Result.ErrorCommandQuery = ex.InnerException.ToString();
            }
            finally
            {
                Connection.Close();
            }
            return Result;
        }

        public bool OpenDataBaseConnection()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                // throw ("Could not open connection");
                return false;
            }
        }

        public DBResult BulkInsert(List<object> list)
        {
            using (IDbConnection dbConnection = Connection)
            {
                var result = dbConnection.BulkInsert(list);
            }
            return new DBResult() ;

        }
        public DBResult BulkInsert(object obj)
        {
            using (IDbConnection dbConnection = Connection)
            {
                var result = dbConnection.BulkInsert(obj);
            }
            return new DBResult();

        }
    }
}
