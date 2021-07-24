using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern2._0
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> products = new List<Product>()
        {
            new Product(){name= "XBox", price = 350},
            new Product(){name= "Blender", price = 1000},
            new Product(){name= "TV", price = 500},

        };
        public List<Product> LoadData()
        {
            Console.WriteLine("Im reading data from SQL data access");
            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("Im saving data from a SQL database");
        }
    }
}
