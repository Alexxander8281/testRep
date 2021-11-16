using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static void mass( List<int> list)
        {
            var i = 0;
            Console.WriteLine("First cycle");
            for (i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[9]);
            
            }

            Console.WriteLine("Second cycle");
            i = 0;
            while (list.Count>i)
           {
                Console.WriteLine(list[i]);
                i++;
            }
            Console.WriteLine("Third cycle");
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4 };
            var c = 0;
            try
            {
                mass(list);
              

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
       
            
            

        }
    }
}
