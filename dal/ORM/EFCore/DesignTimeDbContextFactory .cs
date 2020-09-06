using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace dal.ORM.EFCore
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<WCdBContext>
    {
        public WCdBContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WCdBContext>();
            var connectionString = "server = localhost; user = root; password = welat123; database = webcoreDb;";
            builder.UseMySql(connectionString);
            return new WCdBContext(builder.Options);
        }
    }
}
