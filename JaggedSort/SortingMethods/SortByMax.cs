using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedSort
{
    public sealed class SortByMax : IComparer
    {
        public int Compare(int[] arr1, int[] arr2)
        {
            if (arr1 == null && arr2 == null)
                return 0;
            if (arr1 == null && arr2 != null)
                return 1;
            if (arr1 != null && arr2 == null)
                return -1;
            int m1 = arr1.Max();
            int m2 = arr2.Max();
            if (m1 == m2)
                return 0;
            return m1 > m2 ? 1 : -1;
        }
    }
}
