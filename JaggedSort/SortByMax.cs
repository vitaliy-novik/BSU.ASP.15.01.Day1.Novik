using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedSort
{
    class SortByMax : SortingMethod
    {
        public SortByMax(bool ascend = true) : base(ascend) { }

        public override int[] Alternate(int[][] array)
        {
            int[] alternate = new int[array.Length];
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == null)
                {
                    alternate[i] = int.MaxValue;
                }
                else
                {
                    alternate[i] = int.MinValue;
                    foreach (int element in array[i])
                    {
                        if (element > alternate[i])
                        alternate[i] = element;
                    }
                    if (!ascending)
                        alternate[i] *= -1;
                }                    
            }
            return alternate;
        }
    }
}
