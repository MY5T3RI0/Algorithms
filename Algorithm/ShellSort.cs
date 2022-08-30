using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class ShellSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public ShellSort(IEnumerable<T> items) : base(items)
        {

        }

        public override void Sort()
        {
            var step = Count / 2;
            while (step > 0)
            {
                for (int i = step; i < Count; i++)
                {
                    var j = i;
                    while (j >= step && Compare(j, j - step) == -1)
                    {
                        Swop(j, j - step);
                        j -= step;
                    }
                }
                step /= 2;
            }
        }
    }
}
