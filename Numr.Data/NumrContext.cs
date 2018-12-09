using System;
using System.Collections.Generic;
using System.Text;

namespace Numr.Data
{
    class NumrContext : NumrWeb.Data.Contracts.DataContext.DataContext
    {
        public NumrContext()
            : base(null)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConfigurationManager.AppSettings.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
