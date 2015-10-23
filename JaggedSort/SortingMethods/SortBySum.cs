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

        protected override int GetKey(int[] array)
        {
            return array.Sum();
        }
    }
}
