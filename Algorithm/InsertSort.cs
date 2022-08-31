using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class InsertSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public InsertSort(IEnumerable<T> items) : base(items)
        {

        }

        public InsertSort() : base()
        {

        }

        public override void Sort()
        {
            for (int i = 1; i < Count; i++)
            {
                var j = i;
                while(j > 0 && Compare(j, j-1) == -1)
                {
                    Swop(j, j - 1);
                    j--;
                }
            }
        }

        public override string ToString()
        {
            return "Сортировка вставками";
        }
    }
}
