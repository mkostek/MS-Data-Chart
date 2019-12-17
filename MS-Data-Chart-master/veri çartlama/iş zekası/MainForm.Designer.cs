/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: Asus
 * Tarih: 13.12.2019
 * Zaman: 13:47
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
namespace iş_zekası
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chartikinciDerece = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartBirinciDerece = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chartikinciDerece)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartBirinciDerece)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// chartikinciDerece
			// 
			this.chartikinciDerece.AllowDrop = true;
			this.chartikinciDerece.BorderlineWidth = 3;
			this.chartikinciDerece.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
			chartArea1.Area3DStyle.Rotation = 0;
			chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			chartArea1.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			chartArea1.InnerPlotPosition.Auto = false;
			chartArea1.InnerPlotPosition.Height = 84.61183F;
			chartArea1.InnerPlotPosition.Width = 91.53943F;
			chartArea1.InnerPlotPosition.X = 8.46056F;
			chartArea1.InnerPlotPosition.Y = 4.27907F;
			chartArea1.Name = "ChartArea1";
			chartArea1.Position.Auto = false;
			chartArea1.Position.Height = 85.88311F;
			chartArea1.Position.Width = 74.39622F;
			chartArea1.Position.X = 3F;
			chartArea1.Position.Y = 11.11689F;
			this.chartikinciDerece.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			legend1.Title = "Toplam hakediş";
			this.chartikinciDerece.Legends.Add(legend1);
			this.chartikinciDerece.Location = new System.Drawing.Point(698, 12);
			this.chartikinciDerece.Name = "chartikinciDerece";
			this.chartikinciDerece.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
			this.chartikinciDerece.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
			series1.CustomProperties = "PointWidth=.9";
			series1.IsValueShownAsLabel = true;
			series1.IsXValueIndexed = true;
			series1.Legend = "Legend1";
			series1.MarkerSize = 10;
			series1.MarkerStep = 2;
			series1.Name = "Series3";
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
			this.chartikinciDerece.Series.Add(series1);
			this.chartikinciDerece.Size = new System.Drawing.Size(447, 263);
			this.chartikinciDerece.TabIndex = 4;
			title1.Name = "Title1";
			this.chartikinciDerece.Titles.Add(title1);
			// 
			// chartBirinciDerece
			// 
			this.chartBirinciDerece.AllowDrop = true;
			this.chartBirinciDerece.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.chartBirinciDerece.BorderlineWidth = 2;
			this.chartBirinciDerece.BorderSkin.BackColor = System.Drawing.Color.Silver;
			this.chartBirinciDerece.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea2.Name = "ChartArea1";
			this.chartBirinciDerece.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			legend2.Title = "Tükenim miktarı";
			this.chartBirinciDerece.Legends.Add(legend2);
			this.chartBirinciDerece.Location = new System.Drawing.Point(34, 12);
			this.chartBirinciDerece.Name = "chartBirinciDerece";
			this.chartBirinciDerece.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
			this.chartBirinciDerece.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			series2.ChartArea = "ChartArea1";
			series2.IsValueShownAsLabel = true;
			series2.Legend = "Legend1";
			series2.Name = "toplam tüketim";
			series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
			this.chartBirinciDerece.Series.Add(series2);
			this.chartBirinciDerece.Size = new System.Drawing.Size(658, 263);
			this.chartBirinciDerece.TabIndex = 4;
			this.chartBirinciDerece.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.checkedListBox1.CheckOnClick = true;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
									"islemNo",
									"malzemeAd",
									"miktar",
									"miktarAd",
									"musteriAdSoyad",
									"tarih",
									"ucret"});
			this.checkedListBox1.Location = new System.Drawing.Point(12, 343);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(148, 107);
			this.checkedListBox1.TabIndex = 2;
			this.checkedListBox1.ThreeDCheckBoxes = true;
			this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox1ItemCheck);
			this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(184, 290);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(508, 150);
			this.dataGridView1.TabIndex = 3;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "";
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 290);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(148, 20);
			this.dateTimePicker1.TabIndex = 5;
			this.dateTimePicker1.Value = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1ValueChanged);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.CustomFormat = "";
			this.dateTimePicker2.Location = new System.Drawing.Point(12, 316);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(148, 20);
			this.dateTimePicker2.TabIndex = 6;
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2ValueChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(854, 316);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(213, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Kazanç";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1275, 513);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.chartikinciDerece);
			this.Controls.Add(this.chartBirinciDerece);
			this.Name = "MainForm";
			this.Text = "iş zekası";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.chartikinciDerece)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartBirinciDerece)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		public System.Windows.Forms.DataVisualization.Charting.Chart chartikinciDerece;
		public System.Windows.Forms.DataVisualization.Charting.Chart chartBirinciDerece;	

		
		
	}
}
