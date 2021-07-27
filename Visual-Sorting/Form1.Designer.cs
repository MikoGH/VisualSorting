
namespace Visual_Sorting
{
	partial class Main_Form
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.Main_GroupBox = new System.Windows.Forms.GroupBox();
			this.Sorting_button = new System.Windows.Forms.Button();
			this.TypeSorting_comboBox = new System.Windows.Forms.ComboBox();
			this.Generate_button = new System.Windows.Forms.Button();
			this.amt_NumUD = new System.Windows.Forms.NumericUpDown();
			this.sorting_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Main_GroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.amt_NumUD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sorting_chart)).BeginInit();
			this.SuspendLayout();
			// 
			// Main_GroupBox
			// 
			this.Main_GroupBox.BackColor = System.Drawing.Color.Azure;
			this.Main_GroupBox.Controls.Add(this.sorting_chart);
			this.Main_GroupBox.Controls.Add(this.amt_NumUD);
			this.Main_GroupBox.Controls.Add(this.Sorting_button);
			this.Main_GroupBox.Controls.Add(this.TypeSorting_comboBox);
			this.Main_GroupBox.Controls.Add(this.Generate_button);
			this.Main_GroupBox.Location = new System.Drawing.Point(12, 12);
			this.Main_GroupBox.Name = "Main_GroupBox";
			this.Main_GroupBox.Size = new System.Drawing.Size(546, 455);
			this.Main_GroupBox.TabIndex = 0;
			this.Main_GroupBox.TabStop = false;
			// 
			// Sorting_button
			// 
			this.Sorting_button.Location = new System.Drawing.Point(274, 19);
			this.Sorting_button.Name = "Sorting_button";
			this.Sorting_button.Size = new System.Drawing.Size(96, 23);
			this.Sorting_button.TabIndex = 2;
			this.Sorting_button.Text = "Отсортировать";
			this.Sorting_button.UseVisualStyleBackColor = true;
			this.Sorting_button.Click += new System.EventHandler(this.Sorting_button_Click);
			// 
			// TypeSorting_comboBox
			// 
			this.TypeSorting_comboBox.BackColor = System.Drawing.SystemColors.Info;
			this.TypeSorting_comboBox.FormattingEnabled = true;
			this.TypeSorting_comboBox.Location = new System.Drawing.Point(376, 21);
			this.TypeSorting_comboBox.Name = "TypeSorting_comboBox";
			this.TypeSorting_comboBox.Size = new System.Drawing.Size(164, 21);
			this.TypeSorting_comboBox.TabIndex = 1;
			this.TypeSorting_comboBox.Text = "Выбрать метод сортировки";
			// 
			// Generate_button
			// 
			this.Generate_button.Location = new System.Drawing.Point(132, 19);
			this.Generate_button.Name = "Generate_button";
			this.Generate_button.Size = new System.Drawing.Size(96, 23);
			this.Generate_button.TabIndex = 0;
			this.Generate_button.Text = "Сгенерировать";
			this.Generate_button.UseVisualStyleBackColor = true;
			this.Generate_button.Click += new System.EventHandler(this.Generate_button_Click);
			// 
			// amt_NumUD
			// 
			this.amt_NumUD.Location = new System.Drawing.Point(6, 22);
			this.amt_NumUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.amt_NumUD.Name = "amt_NumUD";
			this.amt_NumUD.Size = new System.Drawing.Size(120, 20);
			this.amt_NumUD.TabIndex = 5;
			this.amt_NumUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// sorting_chart
			// 
			chartArea2.Name = "ChartArea1";
			this.sorting_chart.ChartAreas.Add(chartArea2);
			this.sorting_chart.Location = new System.Drawing.Point(6, 78);
			this.sorting_chart.Name = "sorting_chart";
			series2.ChartArea = "ChartArea1";
			series2.Name = "Series1";
			this.sorting_chart.Series.Add(series2);
			this.sorting_chart.Size = new System.Drawing.Size(534, 287);
			this.sorting_chart.TabIndex = 6;
			// 
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 479);
			this.Controls.Add(this.Main_GroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Main_Form";
			this.Text = "Visual-Sorting";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Main_GroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.amt_NumUD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sorting_chart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox Main_GroupBox;
		private System.Windows.Forms.ComboBox TypeSorting_comboBox;
		private System.Windows.Forms.Button Generate_button;
		private System.Windows.Forms.Button Sorting_button;
		private System.Windows.Forms.DataVisualization.Charting.Chart sorting_chart;
		private System.Windows.Forms.NumericUpDown amt_NumUD;
	}
}

