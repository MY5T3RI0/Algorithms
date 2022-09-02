using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class LsdRedixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public LsdRedixSort(IEnumerable<T> items) : base(items)
        {

        }

        public LsdRedixSort() : base()
        {

        }

        public override void Sort()
        {
            var length = GetMaxLength();

            for (int i = 1; i <= length; i++)
            {
                var groups = new List<List<T>>();

                for (int j = 0; j < 10; j++)
                {
                    groups.Add(new List<T>());
                }

                foreach (var item in Items)
                {
                    int index = item.GetHashCode() % (int)(Math.Pow(10, i)) / (int)Math.Pow(10, i - 1);
                    groups[index].Add(item);
                }

                Items.Clear();

                foreach (var group in groups)
                {
                    Items.AddRange(group);
                } 


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
