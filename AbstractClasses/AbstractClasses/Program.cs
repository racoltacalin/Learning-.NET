using System;
using System.Collections.Generic;
using DemoLibraries;


namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var databases = new List<DataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess()
            };

            foreach (var db in databases)
            {
                Console.WriteLine(db.LoadConnectionString("demo"));
                //db.LoadConnectionString("Demo");
                //db.LoadData("SELECT * FROM TABLE");
                //db.SaveData("Insert into table");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
