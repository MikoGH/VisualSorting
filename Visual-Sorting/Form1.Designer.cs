
namespace Visual_Sorting
{
	partial class formMain
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.gbxMain = new System.Windows.Forms.GroupBox();
			this.lblAmount = new System.Windows.Forms.Label();
			this.tbStep = new System.Windows.Forms.TrackBar();
			this.chartSorting = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.nudAmount = new System.Windows.Forms.NumericUpDown();
			this.btnSorting = new System.Windows.Forms.Button();
			this.cmbTypeSorting = new System.Windows.Forms.ComboBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.timerSort = new System.Windows.Forms.Timer(this.components);
			this.gbxMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbStep)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartSorting)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxMain
			// 
			this.gbxMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
			this.gbxMain.Controls.Add(this.lblAmount);
			this.gbxMain.Controls.Add(this.tbStep);
			this.gbxMain.Controls.Add(this.chartSorting);
			this.gbxMain.Controls.Add(this.nudAmount);
			this.gbxMain.Controls.Add(this.btnSorting);
			this.gbxMain.Controls.Add(this.cmbTypeSorting);
			this.gbxMain.Controls.Add(this.btnGenerate);
			this.gbxMain.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gbxMain.Location = new System.Drawing.Point(12, 12);
			this.gbxMain.Name = "gbxMain";
			this.gbxMain.Size = new System.Drawing.Size(646, 358);
			this.gbxMain.TabIndex = 0;
			this.gbxMain.TabStop = false;
			// 
			// lblAmount
			// 
			this.lblAmount.AutoSize = true;
			this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.lblAmount.ForeColor = System.Drawing.SystemColors.Control;
			this.lblAmount.Location = new System.Drawing.Point(25, 50);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(47, 13);
			this.lblAmount.TabIndex = 8;
			this.lblAmount.Text = "Кол-во:";
			// 
			// tbStep
			// 
			this.tbStep.Location = new System.Drawing.Point(126, 27);
			this.tbStep.Maximum = 100;
			this.tbStep.Minimum = 1;
			this.tbStep.Name = "tbStep";
			this.tbStep.Size = new System.Drawing.Size(390, 45);
			this.tbStep.TabIndex = 4;
			this.tbStep.TickFrequency = 10;
			this.tbStep.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.tbStep.Value = 5;
			this.tbStep.Scroll += new System.EventHandler(this.tbStep_Scroll);
			// 
			// chartSorting
			// 
			this.chartSorting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
			this.chartSorting.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
			this.chartSorting.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
			this.chartSorting.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
			this.chartSorting.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
			chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea5.AxisX.LabelStyle.Enabled = false;
			chartArea5.AxisX.MajorGrid.Enabled = false;
			chartArea5.AxisX.MajorTickMark.Enabled = false;
			chartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea5.AxisY.MajorGrid.Enabled = false;
			chartArea5.Name = "ChartArea1";
			this.chartSorting.ChartAreas.Add(chartArea5);
			this.chartSorting.Location = new System.Drawing.Point(6, 78);
			this.chartSorting.Name = "chartSorting";
			series5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
			series5.ChartArea = "ChartArea1";
			series5.IsVisibleInLegend = false;
			series5.Name = "Series1";
			series5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
			this.chartSorting.Series.Add(series5);
			this.chartSorting.Size = new System.Drawing.Size(633, 274);
			this.chartSorting.TabIndex = 6;
			this.chartSorting.TabStop = false;
			// 
			// nudAmount
			// 
			this.nudAmount.BackColor = System.Drawing.SystemColors.Window;
			this.nudAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nudAmount.Font = new System.Drawing.Font("Modern No. 20", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nudAmount.Location = new System.Drawing.Point(83, 48);
			this.nudAmount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.nudAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudAmount.Name = "nudAmount";
			this.nudAmount.Size = new System.Drawing.Size(36, 19);
			this.nudAmount.TabIndex = 0;
			this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudAmount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// btnSorting
			// 
			this.btnSorting.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.btnSorting.Location = new System.Drawing.Point(522, 19);
			this.btnSorting.Name = "btnSorting";
			this.btnSorting.Size = new System.Drawing.Size(96, 23);
			this.btnSorting.TabIndex = 3;
			this.btnSorting.Tag = "0";
			this.btnSorting.Text = "Отсортировать";
			this.btnSorting.UseVisualStyleBackColor = true;
			this.btnSorting.Click += new System.EventHandler(this.Sorting_button_Click);
			// 
			// cmbTypeSorting
			// 
			this.cmbTypeSorting.BackColor = System.Drawing.SystemColors.Info;
			this.cmbTypeSorting.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbTypeSorting.FormattingEnabled = true;
			this.cmbTypeSorting.Items.AddRange(new object[] {
            "Пузырёк",
            "Вставка",
            "Шейкер",
            "Пирамида"});
			this.cmbTypeSorting.Location = new System.Drawing.Point(522, 48);
			this.cmbTypeSorting.Name = "cmbTypeSorting";
			this.cmbTypeSorting.Size = new System.Drawing.Size(96, 21);
			this.cmbTypeSorting.TabIndex = 2;
			this.cmbTypeSorting.Text = "Пузырёк";
			this.cmbTypeSorting.SelectedIndexChanged += new System.EventHandler(this.cmbTypeSorting_SelectedIndexChanged);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.btnGenerate.Location = new System.Drawing.Point(24, 19);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(96, 23);
			this.btnGenerate.TabIndex = 1;
			this.btnGenerate.Text = "Сгенерировать";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.Generate_button_Click);
			// 
			// timerSort
			// 
			this.timerSort.Tick += new System.EventHandler(this.timerSort_Tick);
			// 
			// formMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(670, 382);
			this.Controls.Add(this.gbxMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "formMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VisualSorting";
			this.gbxMain.ResumeLayout(false);
			this.gbxMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbStep)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartSorting)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxMain;
		private System.Windows.Forms.ComboBox cmbTypeSorting;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnSorting;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartSorting;
		private System.Windows.Forms.NumericUpDown nudAmount;
		private System.Windows.Forms.Timer timerSort;
		private System.Windows.Forms.TrackBar tbStep;
		private System.Windows.Forms.Label lblAmount;
	}
}

