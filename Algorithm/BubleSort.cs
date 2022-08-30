using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class BubleSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public BubleSort(IEnumerable<T> items) : base(items)
        {

        }

        public override void Sort()
        {
            for (int i = 0; i < Count - 1; i++)
            {
                var temp = SwopCount;
                for (int j = 0; j < Count - i - 1; j++)
                {
                    if (Compare(j, j + 1) == 1)
                    {
                        Swop(j, j + 1);
                    }
                }
                if (temp == SwopCount)
                {
                    break;
                }
            }
        }       
    }
}
