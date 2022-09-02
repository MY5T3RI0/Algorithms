using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Structures
{
    public class HeapSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public HeapSort(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Enqueue(item);
            }

        }

        /// <summary>
        /// Добавить элемент в очередь.
        /// </summary>
        /// <param name="item">Приоритет.</param>
        public void Enqueue(T item)
        {
            if (item.GetType() != typeof(T))
            {
                throw new ArgumentException(nameof(item), "Некорректный приоритет.");
            }

            if (Count == 0)
            {
                Items.Add(item);
                return;
            }
            Items.Add(item);
            var currentIndex = Count - 1;
            var parentIndex = (currentIndex - 1) / 2;

            while (Compare(parentIndex, currentIndex) == -1 && currentIndex > 0)
            {
                Swop(currentIndex, parentIndex);
                currentIndex = parentIndex;
                parentIndex = (currentIndex - 1) / 2;
            }
        }


        /// <summary>
        /// Отсортировать очередь.
        /// </summary>
        public void MakeSort(int lenght)
        {
            int rightItemIndex;
            int leftItemIndex;
            var currentIndex = 0;
            var maxItemIndex = 0;

            while (currentIndex < lenght)
            {
                rightItemIndex = 2 * currentIndex + 2;
                leftItemIndex = 2 * currentIndex + 1;

                if (leftItemIndex < lenght && Compare(leftItemIndex, maxItemIndex) == 1)
                {
                    maxItemIndex = leftItemIndex;
                }

                if (rightItemIndex < lenght && Compare(rightItemIndex, maxItemIndex) == 1)
                {
                    maxItemIndex = rightItemIndex;
                }

                if (maxItemIndex == currentIndex)
                {
                    break;
                }

                Swop(currentIndex, maxItemIndex);

                currentIndex = maxItemIndex;

            }

        }

        public override void Sort()
        {

            for (int i = Count - 1; i >= 0; i--)
            {
                Swop(0, i);
                MakeSort(i);
            }

        }
    }
}