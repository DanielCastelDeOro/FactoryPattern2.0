using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern2._0
{
    public interface IDataAccess
    {
        public void SaveData();
        public List<Product>LoadData();
    }
}
