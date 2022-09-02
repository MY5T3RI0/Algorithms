using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Structures
{
    /// <summary>
    /// Бинарное дерево.
    /// </summary>
    /// <typeparam name="T">Тип хранимых в узле данных.</typeparam>
    public class Tree<T> : AlgorithmBase<T>
        where T : IComparable
    {
        /// <summary>
        /// Корневой узел.
        /// </summary>
        public Node<T> Root { get; set; }

        public Tree(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        /// <summary>
        /// Добавить узел.
        /// </summary>
        /// <param name="data">Данные.</param>
        public void Add(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data), "Данные не могут быть null");
            }

            if (Root == null)
            {
                Root = new Node<T>(data); ;
                return;
            }
            Root.Add(data);
        }

        /// <summary>
        /// Инфиксный обход.
        /// </summary>
        /// <returns>Список элементов дерева.</returns>
        public void InOrder()
        {
            if (Root != null)
            {
                var result = new List<T>();
                Items.AddRange(InOrder(Root, result));
            }

        }

        /// <summary>
        /// Инфиксный обход.
        /// </summary>
        /// <param name="node">Корневой узел.</param>
        /// <param name="result">Список элементов дерева.</param>
        /// <returns>Список элементов дерева.</returns>
        private List<T> InOrder(Node<T> node, List<T> result)
        {
            if (node.Left != null)
            {
                InOrder(node.Left, result);
            }

            result.Add(node.Data);

            if (node.Right != null)
            {
                InOrder(node.Right, result);
            }

            return result;
        }

    }
}