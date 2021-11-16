using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4 };
            // var list = new List<int>();
            //list.AddRange(new int[] { 7, 8, 9 });
            var i = 0;
            Console.WriteLine("First cycle");
            for (i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            
            }

            Console.WriteLine("Second cycle");
            i = 0;
            while (list.Count>i)
           {
                Console.WriteLine(list[i]);
                i++;
            }
            Console.WriteLine("Third cycle");


            Console.ReadKey();

        }
    }
}
