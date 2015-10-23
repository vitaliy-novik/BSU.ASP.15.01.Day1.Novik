using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedSort
{
    public abstract class SortingMethod
    {
        protected bool ascending;

        public SortingMethod(bool ascend = true)
        {
            ascending = ascend;
        }

        public int[] Alternate(int[][] array)
        {
            int[] alternate = new int[array.Length];
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == null)
                {
                    alternate[i] = int.MaxValue;
                    continue;
                }
                alternate[i] = GetKey(array[i]);
                if (!ascending)
                    alternate[i] *= -1;
            }
            return alternate;
        }

        protected abstract int GetKey(int[] array);

    }
}
