using Algorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmsView
{
    public partial class MainForm : Form
    {
        Random rnd = new Random();
        public List<SortedItem> Items { get; set; }

        AlgorithmBase<SortedItem> algorithm;

        public MainForm()
        {
            InitializeComponent();
            SortingComboBox.Items.Add("Пузырек");
            SortingComboBox.Items.Add("Шейкерная");
            SortingComboBox.Items.Add("Вставками");
            SortingComboBox.Items.Add("Шелл");

            Items = new List<SortedItem>();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(SizeTextBox.Text, out int Size))
            {
                textBox1.Text = "";
                Items.Clear();
                for (int i = 0; i < Size; i++)
                {
                    var value = rnd.Next(100);
                    var sortedItem = new SortedItem(i + 1, value);
                    Items.Add(sortedItem);
                }
                RefreshItems();
                SizeTextBox.Text = "";
            }
            else
                MessageBox.Show("Укажите колличество");
        }

        private void DrawItems(List<SortedItem> items)
        {
            SortingPanel.Controls.Clear();
            SortingPanel.Refresh();

            foreach (var item in items)
            {
                SortingPanel.Controls.Add(item.label);
                SortingPanel.Controls.Add(item.progressBar);
            }
            SortingPanel.Refresh();
        }

        private void RefreshItems()
        {
            foreach (var item in Items)
            {
                item.Refresh();
            }

            DrawItems(Items);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (Items != null)
            {
                textBox1.Text = "";
                RefreshItems();
                for (int i = 0; i < Items.Count; i++)
                {
                    SortingPanel.Controls.Add(Items[i].label);
                    SortingPanel.Controls.Add(Items[i].progressBar);
                }

                SortingPanel.Refresh();

                switch (SortingComboBox.SelectedIndex)
                {
                    case 0:
                        algorithm = new BubleSort<SortedItem>(Items);
                        Sort(algorithm);
                        break;
                    case 1:
                        algorithm = new CoctailSort<SortedItem>(Items);
                        Sort(algorithm);
                        break;
                    case 2:
                        algorithm = new InsertSort<SortedItem>(Items);
                        Sort(algorithm);
                        break;
                    case 3:
                        algorithm = new ShellSort<SortedItem>(Items);
                        Sort(algorithm);
                        break;
                    default:
                        algorithm = new BubleSort<SortedItem>(Items);
                        Sort(algorithm);
                        break;
                }
                
            }
            else
                MessageBox.Show("Пустая коллекция");
        }

        private void Sort(AlgorithmBase<SortedItem> algorithm)
        {
            algorithm.CompareEvent += Buble_CompareEvent;
            algorithm.SwopEvent += Buble_SwopEvent;
            algorithm.Sort();
            SortingPanel.Refresh();
            foreach (var item in algorithm.Items)
            {
                textBox1.Text += $"{item.Value} ";
            };
        }

        private void Buble_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            int tempProgressBar = e.Item1.progressBar.Location.X;
            int tempLabel = e.Item1.label.Location.X;
            string tempName1 = e.Item1.progressBar.Name;
            string tempName2 = e.Item1.label.Name;
            e.Item1.SetPosition(e.Item2.progressBar.Location.X, e.Item2.label.Location.X);
            e.Item1.progressBar.Name = e.Item2.progressBar.Name;
            e.Item1.label.Name = e.Item2.label.Name;
            e.Item2.progressBar.Name = tempName1;
            e.Item2.label.Name = tempName2;
            e.Item2.SetPosition(tempProgressBar, tempLabel);
            SortingPanel.Refresh();

            SwopLabel.Text = "Колличество перестановок: " + algorithm.SwopCount.ToString();
            InfoPanel.Refresh();
        }

        private void Buble_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            CompareLabel.Text = "Колличество сравнений: " + algorithm.CompareCount.ToString();
            InfoPanel.Refresh();
        }
    }
}
