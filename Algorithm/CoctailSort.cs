using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class CoctailSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public CoctailSort(IEnumerable<T> items) : base(items)
        {

        }

        public CoctailSort() : base()
        {

        }

        public override void Sort()
        {
            for (int i = 0; i < Count/2; i++)
            {
                var temp = SwopCount;
                for (int j = 0 + i; j < Count - i - 1; j++)
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
                temp = SwopCount;
                for (int j = Count - i - 1; j > 0 + i; j--)
                {
                    if (Compare(j, j - 1) == -1)
                    {
                        Swop(j, j - 1);
                    }
                }
                if (temp == SwopCount)
                {
                    break;
                }
            }
        }

        public override string ToString()
        {
            return "Шейкерная сортировка";
        }
    }
}
