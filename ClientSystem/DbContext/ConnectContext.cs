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
     
    }
}