using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class QuickSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public QuickSort(IEnumerable<T> items) : base(items)
        {

        }

        public QuickSort() : base()
        {

        }

        public override void Sort()
        {
            MakeSort(0, Count - 1);
        }

        private void MakeSort(int left, int right)
        {
            if (left >= right )
            {
                return;
            }

            var pivot = QSort(left, right);

            MakeSort(left, pivot - 1);
            MakeSort(pivot + 1, right);
        }

        private int QSort(int left, int right)
        {
            var pointer = left;

            for (int i = left; i <= right; i++)
            {
                if (Compare(i, right) == -1)
                {
                    Swop(i, pointer);
                    pointer++;
                }
            }
            Swop(right, pointer);

            return pointer;
        }
    }
}
