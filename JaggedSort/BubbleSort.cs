using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedSort
{
    public class BubbleSort
    {
        private SortingMethod sortMeth;

        public BubbleSort(SortingMethod sm)
        {
            sortMeth = sm;
        }

        public void Sort(int[][] array)
        {
            int[] alternate = sortMeth.Alternate(array);
            for (int i = 0; i < array.Length - 1; ++i)
            {
                for (int j = 0; j < array.Length - i - 1; ++j)
                {
                    if (alternate[j] > alternate[j + 1])
                    {
                        int a = alternate[j];
                        alternate[j] = alternate[j + 1];
                        alternate[j + 1] = a;
                        int[] ar = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = ar;
                    }
                }
            }
        }
    }
}
