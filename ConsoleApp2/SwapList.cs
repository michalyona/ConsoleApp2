using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SwapList<T> : List<T>
    {
        
        
            public void Swap(int index1, int index2)
            {
                T x = this[index1];
                this[index1] = this[index2];
                this[index2] = x;
            }
        
    }
}
