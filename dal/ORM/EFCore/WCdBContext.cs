using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using entities.tables;

namespace dal.ORM.EFCore
{
    public class WCdBContext:DbContext 
    {
        public WCdBContext(DbContextOptions options):base(options)
        {
            
        }
        DbSet<Menus> GetMenus { get; set; }
    }
}
