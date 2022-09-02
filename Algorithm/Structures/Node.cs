using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Structures
{
    /// <summary>
    /// Узел.
    /// </summary>
    /// <typeparam name="T">Тип хранимых в узле данных.</typeparam>
    public class Node<T>
        where T : IComparable
    {
        /// <summary>
        /// Данные.
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// Ссылка на левый элемент.
        /// </summary>
        public Node<T> Left { get; set; }
        /// <summary>
        /// Ссылка на правый элемент
        /// </summary>
        public Node<T> Right { get; set; }

        /// <summary>
        /// Создать новый узел.
        /// </summary>
        public Node()
        {

        }
        /// <summary>
        /// Создать новый узел
        /// </summary>
        /// <param name="data">Данные.</param>
        public Node(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data), "Данные не могут быть null");
            }
            Data = data;
        }
        /// <summary>
        /// Добавить узел.
        /// </summary>
        /// <param name="data">Данные.param>
        public void Add(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data), "Данные не могут быть null");
            }
            var newNode = new Node<T>(data);
            if (data.CompareTo(Data) < 0)
            {
                if (Left == null)
                {
                    Left = newNode;
                    return;
                }
                Left.Add(data);
            }
            if (data.CompareTo(Data) >= 0)
            {
                if (Right == null)
                {
                    Right = newNode;
                    return;
                }
                Right.Add(data);
            }
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}