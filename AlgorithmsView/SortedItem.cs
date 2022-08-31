using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmsView
{
    public class SortedItem : IComparable
    {
        public VerticalProgressBar progressBar = new AlgorithmsView.VerticalProgressBar();
        public Label label = new System.Windows.Forms.Label();
        public int Value { get; set; }

        public int Number { get; set; }

        public int StartNumber { get; set; }

        public SortedItem(int number, int value)
        {
            Value = value;
            Number = number;
            StartNumber = number;
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(10 * Number * 2 + 1, 106);
            label.Name = "label" + Number;
            label.Size = new System.Drawing.Size(13, 13);
            label.TabIndex = Number;
            label.Text = value.ToString();

            progressBar.ForeColor = Color.Blue;
            progressBar.AccessibleDescription = "";
            progressBar.Location = new System.Drawing.Point(10 * Number * 2, 9);
            progressBar.Name = "progressBar" + Number;
            progressBar.Size = new System.Drawing.Size(22, 86);
            progressBar.Step = 1;
            progressBar.TabIndex = 0;
            progressBar.Value = value;
        }

        public void SetPosition(int ProgressBarposition,int LabelPosition)
        {
            label.Location = new Point(LabelPosition, label.Location.Y);
            progressBar.Location = new Point(ProgressBarposition, progressBar.Location.Y);
        }

        public void Refresh()
        {
            Number = StartNumber;
            progressBar.Location = new Point(10 * Number * 2, 9);
            progressBar.Name = "progressBar" + Number;
            label.Location = new Point(10 * Number * 2 + 1, 106);
            label.Name = "label" + Number;
        }

        public int CompareTo(object obj)
        {
            if (obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));
          
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
