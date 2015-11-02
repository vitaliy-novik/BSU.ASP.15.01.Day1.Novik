using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedSort
{
    public sealed class SortByMin : IComparer
    {
        public int Compare(int[] arr1, int[] arr2)
        {
            if (arr1 == null && arr2 == null)
                return 0;
            if (arr1 == null && arr2 != null)
                return 1;
            if (arr1 != null && arr2 == null)
                return -1;
            int m1 = arr1.Min();
            int m2 = arr2.Min();
            if (m1 == m2)
                return 0;
            return m1 > m2 ? 1 : -1;
        }
    }
}
