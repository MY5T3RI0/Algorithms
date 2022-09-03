using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>();
        public int CompareCount { get; set; }
        public int SwopCount { get; set; }
        public int Count => Items.Count;

        public event EventHandler<Tuple<T, T>> CompareEvent;

        public event EventHandler<Tuple<T, T>> SwopEvent;

        public AlgorithmBase()
        {
        }

        public AlgorithmBase(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }

        public virtual void Sort()
        {
            Items.Sort();
        }

        public TimeSpan TimeSort()
        {
            var timer = new Stopwatch();
            SwopCount = 0;

            timer.Start();
            Sort();
            timer.Stop();

            return timer.Elapsed;
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

        public int CompareItems(T item1, T item2)
        {
            CompareCount++;
            var result = 0;
            switch (item1.CompareTo(item2))
            {
                case -1:
                    result = -1;
                    break;

                case 1:
                    result = 1;
                    break;

                default:
                    result = 0;
                    break;
            }

            CompareEvent?.Invoke(this, new Tuple<T, T>(item1, item2));
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
