using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Numr.Data
{
    public class NumrDBContext 
    {
     public NpgsqlConnection Connection { get; set; }

        public NumrDBContext()
        {
            Connection =new NpgsqlConnection(CommonSettings.ConnectionString);
        }
  
        public bool Open()
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
