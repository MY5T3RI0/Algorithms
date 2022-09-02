using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class GnomeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public GnomeSort(IEnumerable<T> items) : base(items)
        {

        }

        public GnomeSort() : base()
        {

        }

        public override void Sort()
        {
            var i = 1;
            while ( i < Count)
            {
                if (i > 0 && Compare(i, i - 1) == -1)
                {
                    Swop(i, i - 1);
                    i--;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
