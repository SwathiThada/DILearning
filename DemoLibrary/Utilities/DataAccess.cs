using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Utilities

{
    class DataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Logging data");
        }
        public void SaveData(string name)
        {
            Console.WriteLine($"Saving { name }");
        }

    }
}
