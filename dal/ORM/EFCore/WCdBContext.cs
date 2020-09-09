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
        
        public DbSet<Users> Users { get; set; }
        public DbSet<AdressDetails> AdressDetails { get; set; }
        public DbSet<CustomerBankInformation> CustomerBankInformations{ get; set; }
        public DbSet<CustomersDetail>  customersDetails { get; set; }
        public DbSet<CustumersAdressDetails> MyProperty { get; set; }
        


    }
}
