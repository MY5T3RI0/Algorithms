using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public List<T> Items { get; set; }
        public int CompareCount { get; set; }
        public int SwopCount { get; set; }
        public int Count => Items.Count;

        public event EventHandler<Tuple<T, T>> CompareEvent;

        public event EventHandler<Tuple<T, T>> SwopEvent;

        public AlgorithmBase()
        {
            Items = new List<T>();
            CompareCount = 0;
            SwopCount = 0;
        }

        public AlgorithmBase(IEnumerable<T> items)
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
            var result = 0;
            switch (Items[index1].CompareTo(Items[index2]))
            {
                case -1:
                    result =  -1;
                    break;

                case 1:
                    result = 1;
                    break;

                default:
                    result = 0;
                    break;
            }

            CompareEvent?.Invoke(this, new Tuple<T, T>(Items[index1], Items[index2]));
            return result;
        }

        public void Swop(int index1, int index2)
        {
            SwopEvent?.Invoke(this, new Tuple<T, T>(Items[index1], Items[index2]));
            var temp = Items[index1];
            Items[index1] = Items[index2];
            Items[index2] = temp;
            SwopCount++;
        }
    }
}
