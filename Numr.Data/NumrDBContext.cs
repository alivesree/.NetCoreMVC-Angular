using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Numr.Data
{
    public class NumrDBContext 
    {
        NpgsqlConnection Connection;

        public NumrDBContext()
        {
            Connection =new NpgsqlConnection(CommonSettings.ConnectionString);
        }
  
        public void Open()
        {
            try
            {
                Connection.Open();
            }
            catch (Exception)
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
