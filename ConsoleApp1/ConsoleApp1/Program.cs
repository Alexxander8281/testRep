using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;




namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new user { age = 10, name = "MK" };
            string json1 = JsonSerializer.Serialize(user);
            Console.WriteLine(json1);
            Console.ReadKey();
            Console.WriteLine();

        }
    }
}
