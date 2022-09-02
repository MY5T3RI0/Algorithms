using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class MsdRedixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public MsdRedixSort(IEnumerable<T> items) : base(items)
        {

        }

        public MsdRedixSort() : base()
        {

        }

        public override void Sort()
        {
            var length = GetMaxLength();
            List<T> result = new List<T>();
            result.AddRange(Items);
            Items.Clear();
            Sort(length, result);
        }

        private void Sort(int step, List<T> result)
        {
            var groups = new List<List<T>>();

            for (int j = 0; j < 10; j++)
            {
                groups.Add(new List<T>());
            }

            foreach (var item in result)
            {
                int index = item.GetHashCode() % (int)(Math.Pow(10, step)) / (int)Math.Pow(10, step - 1);
                groups[index].Add(item);
            }

            foreach (var group in groups)
            {
                if (group.Count > 1 && step > 1)
                {
                    Sort(step - 1, group); 
                }
                else
                    Items.AddRange(group);
            }
       
        }

        private int GetMaxLength()
        {
            var length = 0;
            foreach (var item in Items)
            {
                if (item.ToString().Length > length)
                {
                    length = item.ToString().Length;
                }
            }

            return length;
        }
    }
}
