using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleColorScope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("original color");

            using (new ConsoleColorScope(ConsoleColor.Green))
            {
                Console.WriteLine("I'm green");

                using (new ConsoleColorScope(ConsoleColor.Cyan))
                {
                    Console.WriteLine("Woo! cyan now");
                }

                Console.WriteLine("back to green");
            }

            Console.WriteLine("back to original color");
        }
    }
}
