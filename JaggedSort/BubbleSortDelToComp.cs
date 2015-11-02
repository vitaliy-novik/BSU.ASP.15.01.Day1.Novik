using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedSort
{
    public static class BubbleSortDelToComp
    {
        public static bool Ascending { get; set; }

        static BubbleSortDelToComp()
        {
            Ascending = true;
        }

        class Comparer : IComparer
        {
            Func<int[], int[], int> comparer;

            public Comparer(Func<int[], int[], int> func)
            {
                comparer = func;
            }

            public int Compare(int[] arr1, int[] arr2)
            {
                return comparer(arr1, arr2);
            }
        }

        public static void Sort(int[][] array, IComparer comparer)
        {
            if (array == null)
                throw new ArgumentException();
            for (int i = 0; i < array.Length - 1; ++i)
            {
                for (int j = 0; j < array.Length - i - 1; ++j)
                {
                    if (comparer.Compare(array[j], array[j+1]) > 0)
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        public static void Sort(int[][] array, Func<int[], int[], int> func) 
        {
            Sort(array, new Comparer(func));
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
