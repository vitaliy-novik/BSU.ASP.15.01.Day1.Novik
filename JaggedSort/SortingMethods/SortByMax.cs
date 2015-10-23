using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedSort
{
    public class SortByMax : SortingMethod
    {
        public SortByMax(bool ascend = true) : base(ascend) { }

        protected override int GetKey(int[] array)
        {
            return array.Max();
        }
    }
}
