using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewtonsMethod;
using JaggedSort;
using NewtonsMethod;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NewtonRoot.Root(5, 3, 0.01));
            Console.WriteLine(Math.Pow(5.0, (1.0 / 3.0)));
            Console.Read();
        }
    }
}
