using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Tell me your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0} ! ", name);
            int count;
            count = name.Length;
            Console.WriteLine("Tvoje ime ima {0} slova", count);
        }
    }
}
