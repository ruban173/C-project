using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.EntityClient;

namespace ClientSystem
{
    class ConnectContext : PAOEntities
    {
        public ConnectContext() 

        { }
        public ConnectContext(string nameOrConnectionString) 
        {
            Database.Connection.ConnectionString = nameOrConnectionString;
        }
       
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Subsidiary_companies> Subsidiary_companies { get; set; }
        public virtual DbSet<Subsidiary_companies_region> Subsidiary_companies_region { get; set; }
        public virtual DbSet<User_access> User_access { get; set; }
        public virtual DbSet<Goods_category> Goods_category { get; set; }
        public virtual DbSet<Sale_basket> Sale_basket { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
    }
}