using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedSort
{
    public static class BubbleSortCompToDel
    {
        public static bool Ascending { get; set; }

        static BubbleSortCompToDel()
        {
            Ascending = true;
        }

        public static void Sort(int[][] array, IComparer comparer)
        {
            Sort(array, (arr1, arr2) => comparer.Compare(arr1, arr2));
        }

        public static void Sort(int[][] array, Func<int[], int[], int> func) 
        {
            if (array == null)
                throw new ArgumentException();
            for (int i = 0; i < array.Length - 1; ++i)
            {
                for (int j = 0; j < array.Length - i - 1; ++j)
                {
                    if (func(array[j], array[j + 1]) > 0)
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
