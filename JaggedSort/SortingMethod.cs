using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedSort
{
    abstract class SortingMethod
    {
        protected bool ascending;

        public SortingMethod(bool ascend = true)
        {
            ascending = ascend;
        }

        public abstract int[] Alternate(int[][] array);
    }
}
