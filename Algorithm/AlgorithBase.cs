using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class AlgorithBase<T> where T : IComparable
    {
        public List<T> Items { get; set; }
        public int CompareCount { get; set; }
        public int SwopCount { get; set; }
        public int Count => Items.Count;

        public AlgorithBase(IEnumerable<T> items)
        {
            Items = new List<T>();
            Items.AddRange(items);
            CompareCount = 0;
            SwopCount = 0;
        }

        public virtual void Sort()
        {
            Items.Sort();
        }

        public int Compare(int index1, int index2)
        {
            CompareCount++;
            switch (Items[index1].CompareTo(Items[index2]))
            {
                case -1:
                    return -1;

                case 1:
                    return 1;

                default:
                    return 0;
            }
        }

        public void Swop(int index1, int index2)
        {
            var temp = Items[index1];
            Items[index1] = Items[index2];
            Items[index2] = temp;
            SwopCount++;
        }
    }
}
