using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class MergeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public MergeSort(IEnumerable<T> items) : base(items)
        {

        }

        public MergeSort() : base()
        {

        }

        public override void Sort()
        {
            Items = Sorting(Items);
        }

        private List<T> Sorting(List<T> result)
        {
            if (result.Count == 1)
            {
                return result;
            }

            var mid = result.Count / 2;

            var left = result.Take(mid).ToList();
            var right = result.Skip(mid).ToList();

            result = Merge(Sorting(left), Sorting(right));
            return result;
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            var leftPointer = 0;
            var rightPointer = 0;
            var length = left.Count + right.Count;
            var result = new List<T>();

            for (int i = 0; i < length; i++)
            {
                if (leftPointer < left.Count && rightPointer < right.Count)
                {
                    if (left[leftPointer].CompareTo(right[rightPointer]) == -1)
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    if (rightPointer >= right.Count)
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                } 
            }

            return result;
        }
    }
}
