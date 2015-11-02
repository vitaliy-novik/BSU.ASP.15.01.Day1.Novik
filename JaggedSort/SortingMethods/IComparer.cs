using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedSort
{
    public interface IComparer
    {
        int Compare(int[] arr1, int[] arr2);
    }
}
