using System;

namespace FactoryPattern2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput;
            bool correctInput;
            do {
               // Console.Clear();
                correctInput = true;
                Console.WriteLine($"What database would you like to use\nUse Mongo, SQL, or List");
                userinput = Console.ReadLine();
                if (userinput != "SQL" && userinput != "Mongo" && userinput != "List")
                {
                    correctInput = false;
                    Console.WriteLine("Bad input, please try again");
                    
                }
            } while (!correctInput);
            Console.Clear();

           var DB = DataAccessFactory.GetDataAccessType(userinput);
          var products =  DB.LoadData(); 
            DB.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.name} Price:{product.price}");
            }


        }
    }
}
