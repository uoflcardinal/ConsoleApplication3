using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Print(int x)
        {
            Console.WriteLine(x/2);
        }

        static void Main(string[] args)
        {
            Print(42);
            Print(50);
            Print(100);
        }

    }
}

