using OnlineShop.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop
{
    public class DatabaseContextFactory
    {
        private static DatabaseContext databaseContext; 
        public static DatabaseContext CreateDatabaseContext()
        {
             databaseContext = new DatabaseContext();
            return databaseContext;
        }
    }
}