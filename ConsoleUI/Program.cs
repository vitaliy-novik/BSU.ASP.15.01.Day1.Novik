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
            int[][] ar = new int[5][];
            ar[0] = new int[2] { 5, 6 };
            ar[2] = new int[4] { 4, 8, 1, 5 };
            ar[4] = new int[3] { 3, 5, 9 };
            BubbleSort bs = new BubbleSort(new SortBySum(false));
            bs.Sort(ar);
            Console.Read();
        }
    }
}
