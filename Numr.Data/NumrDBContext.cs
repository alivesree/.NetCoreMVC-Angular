using Microsoft.Extensions.Configuration;
using Npgsql;
using System;

namespace Numr.Data
{
    class NumrDBContext 
    {
        NpgsqlConnection Connection;
        public NumrDBContext(IConfiguration config)
        {
            Connection = new NpgsqlConnection(config.GetConnectionString("numrbasenew"));
        }

        public void Open()
        {
            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
            // throw ("Could not open connection");
            }
        }
        public void Close()
        {
            if (Connection != null)
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

    }
}
