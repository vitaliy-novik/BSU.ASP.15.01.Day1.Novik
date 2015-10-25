using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedSort
{
    public sealed class SortByMin : ISortingMethod
    {
        public int GetKey(int[] array)
        {
            return array.Min();
        }
    }
}
