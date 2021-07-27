using System;
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
	public partial class Main_Form : System.Windows.Forms.Form
	{
		int n;
		int[] a;
		int pos = 0;
		public Main_Form()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Generate_button_Click(object sender, EventArgs e)
		{
			var random = new Random();
			n = (int)amt_NumUD.Value;
			a = (new int[n])
				.Select(x => random.Next(10, 100))
				.ToArray();
			UpdateChart();
		}

		private void Sorting_button_Click(object sender, EventArgs e)
		{	
			for (int i = 0; i < 20; i++)
			{
				UpdateChart();
			}
		}

		private void Do()
		{
			sorting_chart.Series[0].Points.Clear();
			for (int i = 0; i < a.Length; i++)
			{
				sorting_chart.Series[0].Points.AddXY(i, a[i]);
			}
			pos = (pos + 1) % n;
			sorting_chart.Series[0].Points[pos].Color = System.Drawing.Color.Red;
		}

		private void UpdateChart()
		{
			System.Threading.Thread.Sleep(100);
			if (sorting_chart.InvokeRequired)
			{
				sorting_chart.Invoke(new Action(() => {	UpdateChart(); }));
			}
			else
			{
				Do();
			}
		}
	}
}
