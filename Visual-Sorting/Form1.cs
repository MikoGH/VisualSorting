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
		static int n;
		static int[] arr;
		static int[] arrClr;
		Color[] colors = { Color.FromArgb(40,40,240), Color.FromArgb(200,40,40), Color.FromArgb(40, 240, 40), Color.FromArgb(140, 40, 240) };

		IEnumerator iters;

		public formMain()
		{
			InitializeComponent();
			tbStep_Scroll(tbStep, EventArgs.Empty);
		}

		// Генерирует список случайных чисел длиной n и список цветов длиной n
		private void GenArray()
		{
			var random = new Random();
			arr = (new int[n])
				.Select(x => random.Next(10, 100))
				.ToArray();
			arrClr = (new int[n])
				.Select(x => 0)
				.ToArray();
		}
		// Срабатывает при нажатии на кнопку Сгенерировать
		// Вызывает функцию генерации списка, обновляет диаграмму, сбрасывает таймер сортировки
		private void Generate_button_Click(object sender, EventArgs e)
		{
			iters = sortingBubble();
			n = (int)nudAmount.Value;
			GenArray();
			UpdateChart();

			timerSort.Enabled = false;
			btnSorting.Text = "Отсортировать";
		}
		// Срабатывает при нажатии на кнопку Отсортировать/Пауза/Продолжить
		// Триггер таймера сортировки. Назначает указанный пользователем метод сортировки
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
				else if (cmbTypeSorting.Text == "Шейкер")
				{
					iters = sortingShaker();
				}
				else if (cmbTypeSorting.Text == "Пирамида")
				{
					iters = sortingHeap();
				}
			}
		}
		// Перерисовывает диаграмму
		private void UpdateChart()
		{
			chartSorting.Series[0].Color = colors[0];
			chartSorting.Series[0].Points.Clear();
			for (int i = 0; i < n; i++)
			{
				chartSorting.Series[0].Points.AddXY(i, arr[i]);
				chartSorting.Series[0].Points[i].Color = colors[arrClr[i]];
			}
		}
		// Вызывает итерации сортировки, перерисовывает список, при окончании всех итераций сбрасывает таймер сортировки
		private void timerSort_Tick(object sender, EventArgs e)
		{
			iters.MoveNext();
			if (iters.Current != null)
			{
				UpdateChart();
			}
			else
			{
				timerSort.Enabled = false;
				btnSorting.Text = "Отсортировать";
			}
		}
		// Срабатывает при изменении положения ползунка
		// Меняет скорость сортировки
		private void tbStep_Scroll(object sender, EventArgs e)
		{
			timerSort.Interval = (int)(1000 / tbStep.Value);
		}
		// Сортировка пузырьком
		static IEnumerator sortingBubble()
		{
			for (int j = 1; j < n; j++)
			{
				for (int i = 0; i < n - j; i++)
				{
					if (arr[i] > arr[i+1])
					{
						(arr[i],arr[i+1]) = (arr[i+1],arr[i]);
					}
					arrClr[i + 1] = 1;
					yield return true;
					arrClr[i + 1] = 0;
				}
				arrClr[n - j] = 3;
			}
			arrClr[0] = 3;
			yield return true;
			yield return null;
			yield break;
		}
		// Сортировка вставкой
		static IEnumerator sortingInsert()
		{
			int maxElmIndex = 0;
			for (int j = 0; j < n; j++)
			{
				if (arrClr[maxElmIndex] != 3) arrClr[maxElmIndex] = 0;
				maxElmIndex = 0;
				for (int i = 0; i < n - j; i++)
				{
					if (arr[i] > arr[maxElmIndex])
					{
						arrClr[maxElmIndex] = 0;
						maxElmIndex = i;
					}
					arrClr[i] = 1;
					yield return true;
					arrClr[i] = 0;
					arrClr[maxElmIndex] = 2;
				}
				(arr[n - j - 1], arr[maxElmIndex]) = (arr[maxElmIndex], arr[n - j - 1]);
				arrClr[n - j - 1] = 3;
			}
			yield return true;
			yield return null;
			yield break;
		}
		// Сортировка шейкерная
		static IEnumerator sortingShaker()
		{
			int l = 0, r = n - 1;
			while (l<=r)
			{
				for (int i = l; i < r-1; i++)
				{
					if (arr[i] > arr[i + 1]) (arr[i + 1], arr[i]) = (arr[i],arr[i + 1]);
					arrClr[i+1] = 1;
					yield return true;
					arrClr[i+1] = 0;
				}
				arrClr[r] = 3;
				r -= 1;
				for (int i = r; i >= l; i--)
				{
					if (arr[i] > arr[i + 1]) (arr[i + 1], arr[i]) = (arr[i], arr[i + 1]);
					arrClr[i] = 1;
					yield return true;
					arrClr[i] = 0;
				}
				arrClr[l] = 3;
				l += 1;
			}
			yield return true;
			yield return null;
			yield break;
		}
		// Сортировка пирамидальная
		static IEnumerator sortingHeap()
		{
			IEnumerator itersHeap;
			for (int i = n - 1; i >= 0; i--)
			{
				itersHeap = Heap(i, n);
				itersHeap.MoveNext();
				while (itersHeap.Current != null)
				{
					int pos = (int)itersHeap.Current;
					int posd1 = pos * 2 + 1;
					int posd2 = pos * 2 + 2;

					arrClr[pos] = 1;
					if (posd1 < n) arrClr[posd1] = 2;
					if (posd2 < n) arrClr[posd2] = 2;

					yield return true;

					arrClr[pos] = 0;
					if (posd1 < n) arrClr[posd1] = 0;
					if (posd2 < n) arrClr[posd2] = 0;

					itersHeap.MoveNext();
				}
			}

			for (int i = 1; i < n; i++)
			{
				(arr[0], arr[n - i]) = (arr[n - i], arr[0]);
				arrClr[n - i] = 3;
				itersHeap = Heap(0, n - i);
				itersHeap.MoveNext();
				while (itersHeap.Current != null)
				{
					int pos = (int)itersHeap.Current;
					int posd1 = pos * 2 + 1;
					int posd2 = pos * 2 + 2;

					arrClr[pos] = 1;
					if (posd1 < n-i) arrClr[posd1] = 2;
					if (posd2 < n-i) arrClr[posd2] = 2;

					yield return true;

					arrClr[pos] = 0;
					if (posd1 < n-i) arrClr[posd1] = 0;
					if (posd2 < n-i) arrClr[posd2] = 0;

					itersHeap.MoveNext();
				}
			}
			arrClr[0] = 3;
			yield return true;
			yield return null;
			yield break;

		}
		// Рекурсивная функция пирамидальной сортировки
		static IEnumerator Heap(int i, int j)
		{
			IEnumerator itersRecHeap;
			int k1 = 2 * i + 1, k2 = 2 * i + 2;
			int m = i;
			if (k1 < j && arr[k1] > arr[m]) m = k1;
			if (k2 < j && arr[k2] > arr[m]) m = k2;

			yield return i;
			if (m != i)
			{
				(arr[i], arr[m]) = (arr[m], arr[i]);
				itersRecHeap = Heap(m, j);
				itersRecHeap.MoveNext();
				while (itersRecHeap != null)
				{
					yield return itersRecHeap.Current;
					itersRecHeap.MoveNext();
				}
				itersRecHeap = Heap(i, j);
				itersRecHeap.MoveNext();
				while (itersRecHeap != null)
				{
					yield return itersRecHeap.Current;
					itersRecHeap.MoveNext();
				}
			}
			yield return null;
			yield break;
		}
		// Срабатывает при изменении метода сортировки
		private void cmbTypeSorting_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnSorting.Text = "Отсортировать";
		}
	}
}