using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern2._0
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "mongo":
                    return new MongoDataAccess();
                case  "sql":
                    return new SQLDataAccess();
                case "list":
                    return new ListDataAccess();
                default:
                    return new ListDataAccess();
                    
            }
        } 
    }
}
