using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedSort
{
    public class SortBySum : SortingMethod
    {
        public SortBySum(bool ascend = true) : base(ascend) { }
        
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
                    foreach (int element in array[i])
                    {
                        alternate[i] += element;
                    }
                    if (!ascending)
                        alternate[i] *= -1;
                }                    
            }
            return alternate;
        }
    }
}
