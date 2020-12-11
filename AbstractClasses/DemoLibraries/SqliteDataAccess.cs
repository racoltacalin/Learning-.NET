using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibraries
{
    public class SqliteDataAccess : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);

            output += " (from SQLite)";

            return output;
        }

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading SQLite Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }
    }
}
