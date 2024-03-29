﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using Algorithm.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTests
    {
        List<int> Items = new List<int>();

        List<int> SortedItems = new List<int>();

        Random rnd = new Random();

        [TestInitialize()]
        public void Initialize()
        {
            for (int i = 0; i < 10000; i++)
            {
                Items.Add(rnd.Next(1000));
            }
            SortedItems.AddRange(Items);
            SortedItems.Sort();
        }

        [TestMethod()]
        public void BaseSort()
        {
            //arrange
            var sort = new AlgorithmBase<int>(Items);

            //act
            sort.Sort();

            //assert

            for (int i = 0; i < sort.Items.Count; i++)
            {
                Assert.AreEqual(SortedItems[i], sort.Items[i]);
            }
        }

        [TestMethod()]
        public void BubleSort()
        {
            //arrange
            var sort = new BubleSort<int>(Items);

            //act
            sort.Sort();

            //assert

            for (int i = 0; i < sort.Items.Count; i++)
            {
                Assert.AreEqual(SortedItems[i], sort.Items[i]);
            }
        }

        [TestMethod()]
        public void CocktailSort()
        {
            //arrange
            var sort = new CoctailSort<int>(Items);

            //act
            sort.Sort();

            //assert

            for (int i = 0; i < sort.Items.Count; i++)
            {
                Assert.AreEqual(SortedItems[i], sort.Items[i]);
            }
        }

        [TestMethod()]
        public void InsertSort()
        {
            //arrange
            var sort = new InsertSort<int>(Items);

            //act
            sort.Sort();

            //assert

            for (int i = 0; i < sort.Items.Count; i++)
            {
                Assert.AreEqual(SortedItems[i], sort.Items[i]);
            }
        }

        [TestMethod()]
        public void ShellSort()
        {
            //arrange
            var sort = new ShellSort<int>(Items);

            //act
            sort.Sort();

            //assert

            for (int i = 0; i < sort.Items.Count; i++)
            {
                Assert.AreEqual(SortedItems[i], sort.Items[i]);
            }
        }

        [TestMethod()]
        public void HeapSort()
        {
            //arrange
            var sort = new HeapSort<int>(Items);

            //act
            sort.Sort();

            //assert

            for (int i = 0; i < sort.Items.Count; i++)
            {
                Assert.AreEqual(SortedItems[i], sort.Items[i]);
            }
        }

        [TestMethod()]
        public void TreeSort()
        {
            //arrange
            var sort = new Tree<int>(Items);

            //act
            sort.InOrder();

            //assert

            for (int i = 0; i < sort.Items.Count; i++)
            {
                Assert.AreEqual(SortedItems[i], sort.Items[i]);
            }
        }
        
        [TestMethod()]
        public void SelectionSort()
        {
            //arrange
            var sort = new SelectionSort<int>(Items);

            //act
            sort.Sort();

            //assert

            for (int i = 0; i < sort.Items.Count; i++)
            {
                Assert.AreEqual(SortedItems[i], sort.Items[i]);
            }
        }

        [TestMethod()]
        public void GnomeSort()
        {
            //arrange
            var sort = new GnomeSort<int>(Items);

            //act
            sort.Sort();

            //assert

            for (int i = 0; i < sort.Items.Count; i++)
            {
                Assert.AreEqual(SortedItems[i], sort.Items[i]);
            }
        }

        [TestMethod()]
        public void LsdRedixSort()
        {
            //arrange
            var sort = new LsdRedixSort<int>(Items);

            //act
            sort.Sort();

            //assert

            for (int i = 0; i < sort.Items.Count; i++)
            {
                Assert.AreEqual(SortedItems[i], sort.Items[i]);
            }
        }

        [TestMethod()]
        public void MsdRedixSort()
        {
            //arrange
            var sort = new MsdRedixSort<int>(Items);

            //act
            sort.Sort();

            //assert

            for (int i = 0; i < sort.Items.Count; i++)
            {
                Assert.AreEqual(SortedItems[i], sort.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSort()
        {
            //arrange
            var sort = new MergeSort<int>(Items);

            //act
            sort.Sort();

            //assert

            for (int i = 0; i < sort.Items.Count; i++)
            {
                Assert.AreEqual(SortedItems[i], sort.Items[i]);
            }
        }

        [TestMethod()]
        public void QuickSort()
        {
            //arrange
            var sort = new QuickSort<int>(Items);

            //act
            sort.Sort();

            //assert

            for (int i = 0; i < sort.Items.Count; i++)
            {
                Assert.AreEqual(SortedItems[i], sort.Items[i]);
            }
        }
    }
}