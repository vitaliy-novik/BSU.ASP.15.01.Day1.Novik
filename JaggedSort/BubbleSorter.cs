using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedSort
{
    public sealed class BubbleSorter
    {
        public ISortingMethod SortMethod { get; set; }
        public bool Ascending { get; set; }

        public BubbleSorter(ISortingMethod sm, bool ascend = true)
        {
            SortMethod = sm;
            Ascending = ascend;
        }

        public void Sort(int[][] array)
        {
            if (array == null)
                throw new ArgumentException();
            int[] alternate = Alternate(array);
            for (int i = 0; i < array.Length - 1; ++i)
            {
                for (int j = 0; j < array.Length - i - 1; ++j)
                {
                    if (alternate[j] > alternate[j + 1])
                    {
                        Swap(ref alternate[j], ref alternate[j + 1]);
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        private int[] Alternate(int[][] array)
        {
            int[] alternate = new int[array.Length];
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == null)
                {
                    alternate[i] = int.MaxValue;
                    continue;
                }
                alternate[i] = SortMethod.GetKey(array[i]);
                if (!Ascending)
                    alternate[i] *= -1;
            }
            return alternate;
        }

        private void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
