using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Sorting
{
	public partial class formMain : System.Windows.Forms.Form
	{
		struct Positions
		{
			public List<int> current;
			public List<int> old;
			public List<int> saved;
			public List<int> fit;
			public Positions(List<int> _old, List<int> _current, List<int> _saved, List<int> _fit)
			{
				current = _current;
				old = _old;
				saved = _saved;
				fit = _fit;
			}
		}

		static int n;
		static int[] arr;
		Color[] colors = { Color.FromArgb(40,40,240), Color.FromArgb(200,40,40), Color.FromArgb(40, 240, 40), Color.FromArgb(140, 40, 240) };

		IEnumerator iters;

		public formMain()
		{
			InitializeComponent();
			tbStep_Scroll(tbStep, EventArgs.Empty);
		}
		private void GenArray()
		{
			var random = new Random();
			arr = (new int[n])
				.Select(x => random.Next(10, 100))
				.ToArray();
		}
		private void Generate_button_Click(object sender, EventArgs e)
		{
			iters = sortingBubble();
			n = (int)nudAmount.Value;
			GenArray();
			UpdateChart();

			timerSort.Enabled = false;
			btnSorting.Text = "Отсортировать";
		}
		private void Sorting_button_Click(object sender, EventArgs e)
		{
			if (btnSorting.Text == "Пауза")
			{
				timerSort.Enabled = false;
				btnSorting.Text = "Продолжить";
			}
			else if (btnSorting.Text == "Продолжить")
			{
				timerSort.Enabled = true;
				btnSorting.Text = "Пауза";				
			}
			else if (btnSorting.Text == "Отсортировать")
			{
				UpdateChart();
				timerSort.Enabled = true;
				btnSorting.Text = "Пауза";
				if (cmbTypeSorting.Text == "Пузырёк")
				{
					iters = sortingBubble();
				}
				else if (cmbTypeSorting.Text == "Вставка")
				{
					iters = sortingInsert();
				}
			}
		}
		private void UpdateChart()
		{
			chartSorting.Series[0].Color = colors[0];
			chartSorting.Series[0].Points.Clear();
			for (int i = 0; i < n; i++)
			{
				chartSorting.Series[0].Points.AddXY(i, arr[i]);
			}
		}
		
		private void timerSort_Tick(object sender, EventArgs e)
		{
			iters.MoveNext();
			if (iters.Current != null)
			{
				Positions pos = (Positions)iters.Current;
				for (int i = 0; i < pos.old.Count; i++)
				{
					chartSorting.Series[0].Points[pos.old[i]].Color = colors[0];
					chartSorting.Series[0].Points[pos.old[i]].SetValueY(arr[pos.old[i]]);
				}
				for (int i = 0; i < pos.current.Count; i++)
				{
					chartSorting.Series[0].Points[pos.current[i]].Color = colors[1];
					chartSorting.Series[0].Points[pos.current[i]].SetValueY(arr[pos.current[i]]);
				}
				for (int i = 0; i < pos.saved.Count; i++)
				{
					chartSorting.Series[0].Points[pos.saved[i]].Color = colors[2];
					chartSorting.Series[0].Points[pos.saved[i]].SetValueY(arr[pos.saved[i]]);
				}
				for (int i = 0; i < pos.fit.Count; i++)
				{
					chartSorting.Series[0].Points[pos.fit[i]].Color = colors[3];
					chartSorting.Series[0].Points[pos.fit[i]].SetValueY(arr[pos.fit[i]]);
				}
			}
			else
			{
				timerSort.Enabled = false;
				btnSorting.Text = "Отсортировать";
			}
		}

		private void tbStep_Scroll(object sender, EventArgs e)
		{
			timerSort.Interval = (int)(1000 / tbStep.Value);
		}

		static IEnumerator sortingBubble()
		{
			List<int> oldPos = new List<int>(), curPos = new List<int>(), savedPos = new List<int>(), fitPos = new List<int>();
			for (int j = 1; j < n; j++)
			{
				for (int i = 0; i < n - j; i++)
				{
					if (arr[i] > arr[i+1])
					{
						(arr[i],arr[i+1]) = (arr[i+1],arr[i]);
					}
					oldPos = new List<int>() { (i > 0 ? i : 0) };
					curPos = new List<int>() { i + 1 };
					yield return new Positions(oldPos, curPos, savedPos, fitPos);
				}
				fitPos.Add(n - j);
			}
			fitPos.Add(0);
			yield return new Positions(oldPos, curPos, savedPos, fitPos);
			yield return null;
			yield break;
		}
		 
		static IEnumerator sortingInsert()
		{
			List<int> oldPos = new List<int>(), curPos = new List<int>(), savedPos = new List<int>(), fitPos = new List<int>();
			int maxElmIndex = 0;
			for (int j = 0; j < n; j++)
			{
				oldPos.Add(maxElmIndex);
				maxElmIndex = 0;
				for (int i = 0; i < n - j; i++)
				{
					if (arr[i] > arr[maxElmIndex])
					{
						oldPos.Add(maxElmIndex);
						maxElmIndex = i;
					}
					curPos = new List<int>() { i };
					savedPos = new List<int>() { maxElmIndex };
					yield return new Positions(oldPos, curPos, savedPos, fitPos);
					oldPos = new List<int>() { i };
				}
				(arr[n - j - 1], arr[maxElmIndex]) = (arr[maxElmIndex], arr[n - j - 1]);
				fitPos.Add(n - j - 1);
			}
			yield return new Positions(oldPos, curPos, savedPos, fitPos);
			yield return null;
			yield break;
		}

		private void cmbTypeSorting_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnSorting.Text = "Отсортировать";
		}
	}
}