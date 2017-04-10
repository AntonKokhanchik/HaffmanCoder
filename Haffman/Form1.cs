using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haffman
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void textBoxInput_TextChanged(object sender, EventArgs e)
		{
			if (textBoxInput.Text.Length > 0)
				buttonStart.Enabled = true;
			else
				buttonStart.Enabled = false;
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			textBoxOutput.Clear();
			dataGridView.Rows.Clear();
			Encrypt();
		}

		void Encrypt()
		{
			Dictionary<char, int> frequency = new Dictionary<char, int>();
			for (int i = 0; i < textBoxInput.Text.Length; i++)
				if (frequency.ContainsKey(textBoxInput.Text[i]))
					frequency[textBoxInput.Text[i]]++;
				else
					frequency.Add(textBoxInput.Text[i], 1);

			List<node> sorter = new List<node>();
			foreach (var el in frequency)
				sorter.Add(new node(el.Key, el.Value));

			while (sorter.Count > 1)
			{
				node temp = new node();

				temp.Left = sorter.Min();
				sorter.Remove(sorter.Min());

				temp.Right = sorter.Min();
				sorter.Remove(sorter.Min());
				temp.Weight = temp.Left.Weight + temp.Right.Weight;

				sorter.Add(temp);
			}
			node tree = sorter.First();
			if (tree.Weight == 1)
				tree.Code = "0";

			Dictionary<char, string> codes = new Dictionary<char, string>();
			Queue<node> q = new Queue<node>();

			q.Enqueue(tree);
			while (q.Count != 0)
			{
				node temp = q.Dequeue();
				if (temp.Symbol == (char)0)
				{
					temp.Left.Code = temp.Code + "0";
					temp.Right.Code = temp.Code + "1";
					q.Enqueue(temp.Left);
					q.Enqueue(temp.Right);
				}
				else
					codes.Add(temp.Symbol, temp.Code);
			}

			foreach (var el in codes)
				dataGridView.Rows.Add(el.Key, frequency[el.Key], el.Value);

			for (int i = 0; i < textBoxInput.Text.Length; i++)
				textBoxOutput.AppendText(codes[textBoxInput.Text[i]] + "   ");
		}
	}
}
