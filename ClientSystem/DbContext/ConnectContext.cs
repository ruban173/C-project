using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClientSystem.Models;



namespace ClientSystem
{


    class ConnectContext : DbContext
    {
        public ConnectContext() :
                            base()
        { }
        public ConnectContext(string dbNameOrConnection)
        : base(dbNameOrConnection)
        {
             
          
        }
        public DbSet<UserAccess> UserAccess { get; set; }
        // public  DbSet<UserAccess> UserAccess { get; set; }
        //  public virtual DbSet<Доступ_пользователи_история> Доступ_пользователи_история { get; set; }
        //  public virtual DbSet<Сотрудники> Сотрудники { get; set; }

    }


}
