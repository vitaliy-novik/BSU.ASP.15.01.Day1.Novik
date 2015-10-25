using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedSort
{
    public interface ISortingMethod
    {
        int GetKey(int[] array);
    }
}
