using Npgsql;
using Numr.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Numr.Business.Service
{
    class ServiceBase
    {
        NumrDBContext dBContext = new NumrDBContext();

        public DBResult ExecuteNonQuery(string query)
        {

            DBResult Result = new DBResult();
            try
            {
                if (dBContext.Open())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(query, dBContext.Connection);
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
                dBContext.Close();
            }
            return Result;
        }

        public DBResult ExecuteSelectQuery(string query)
        {
            DBResult Result = new DBResult();
            try
            {
                if (dBContext.Open())
                {
                    DataTable result = new DataTable();
                    NpgsqlCommand cmd = new NpgsqlCommand(query, dBContext.Connection);
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
                dBContext.Close();
            }
            return Result;
        }

        public DBResult ExecuteScalar(string query)
        {
            DBResult Result = new DBResult();
            try
            {
                if (dBContext.Open())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(query, dBContext.Connection);
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
                dBContext.Close();
            }
            return Result;
        }

    }

    public class DBResult
    {
        public bool IsSucceess { get; set; }
        public string ErrorMessage { get; set; }
        public string Description { get; set; }
        public string ErrorCommandQuery { get; set; }
        public object Result { get; set; }

        public DBResult()
        {
            IsSucceess = false;
            ErrorMessage = "";
            Description = "";
            ErrorCommandQuery = "";
            Result = null;
        }
    }


}
