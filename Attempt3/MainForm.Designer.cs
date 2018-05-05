namespace MonitoringProgramm
{
	partial class MainForm
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Computer", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Motherboard", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Display", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Folder", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Network", System.Windows.Forms.HorizontalAlignment.Left);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.CPUPage = new System.Windows.Forms.TabPage();
			this.CPUSettings = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CPUchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lblCPU = new System.Windows.Forms.Label();
			this.lBTempCPU = new System.Windows.Forms.ListBox();
			this.CPUName = new System.Windows.Forms.Label();
			this.RamPage = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.RamUsage = new System.Windows.Forms.Label();
			this.RamUsageGB = new System.Windows.Forms.Label();
			this.RAMChartGB = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lblIR = new System.Windows.Forms.Label();
			this.InsRAM = new System.Windows.Forms.Label();
			this.lblRAMname = new System.Windows.Forms.Label();
			this.lblRAM = new System.Windows.Forms.Label();
			this.RAMChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.VideoPage = new System.Windows.Forms.TabPage();
			this.VideoName = new System.Windows.Forms.Label();
			this.lblGPU = new System.Windows.Forms.Label();
			this.videoInfo = new System.Windows.Forms.ListBox();
			this.DiskPage = new System.Windows.Forms.TabPage();
			this.letterDiskWork = new System.Windows.Forms.Label();
			this.letterDisksys = new System.Windows.Forms.Label();
			this.HardDriveName = new System.Windows.Forms.Label();
			this.lblDiskD = new System.Windows.Forms.Label();
			this.lblDiskC = new System.Windows.Forms.Label();
			this.chartDiskD = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartDiskC = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lbDiskMon = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.InternetPage = new System.Windows.Forms.TabPage();
			this.InternetChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.IntInfo = new System.Windows.Forms.ListBox();
			this.lblDownload = new System.Windows.Forms.Label();
			this.lblBytesSent = new System.Windows.Forms.Label();
			this.lblSpeed = new System.Windows.Forms.Label();
			this.lblUpload = new System.Windows.Forms.Label();
			this.lblInterfaceType = new System.Windows.Forms.Label();
			this.lblBytesReceived = new System.Windows.Forms.Label();
			this.InternerBox = new System.Windows.Forms.ListBox();
			this.cmbInterface = new System.Windows.Forms.ListBox();
			this.SystemPage = new System.Windows.Forms.TabPage();
			this.lVDiskMon = new System.Windows.Forms.ListView();
			this.Field = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.lblSysInfo = new System.Windows.Forms.Label();
			this.SaveAs = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SaveTXT = new System.Windows.Forms.Button();
			this.OpenQ = new System.Windows.Forms.Button();
			this.SaveQR = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.qwe = new System.Windows.Forms.Button();
			this.qwer = new System.Windows.Forms.Button();
			this.pCPU = new System.Diagnostics.PerformanceCounter();
			this.pRAM = new System.Diagnostics.PerformanceCounter();
			this.pRAMGB = new System.Diagnostics.PerformanceCounter();
			this.pDiskС = new System.Diagnostics.PerformanceCounter();
			this.pDiskD = new System.Diagnostics.PerformanceCounter();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer0 = new System.Windows.Forms.Timer(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabControl1.SuspendLayout();
			this.CPUPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CPUchart)).BeginInit();
			this.RamPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RAMChartGB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RAMChart)).BeginInit();
			this.VideoPage.SuspendLayout();
			this.DiskPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartDiskD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartDiskC)).BeginInit();
			this.InternetPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InternetChart)).BeginInit();
			this.SystemPage.SuspendLayout();
			this.SaveAs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pRAMGB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pDiskС)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pDiskD)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.CPUPage);
			this.tabControl1.Controls.Add(this.RamPage);
			this.tabControl1.Controls.Add(this.VideoPage);
			this.tabControl1.Controls.Add(this.DiskPage);
			this.tabControl1.Controls.Add(this.InternetPage);
			this.tabControl1.Controls.Add(this.SystemPage);
			this.tabControl1.Controls.Add(this.SaveAs);
			this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.ItemSize = new System.Drawing.Size(60, 120);
			this.tabControl1.Location = new System.Drawing.Point(0, 27);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(100, 100);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(816, 454);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 1;
			this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// CPUPage
			// 
			this.CPUPage.BackColor = System.Drawing.Color.White;
			this.CPUPage.Controls.Add(this.CPUSettings);
			this.CPUPage.Controls.Add(this.label3);
			this.CPUPage.Controls.Add(this.label2);
			this.CPUPage.Controls.Add(this.CPUchart);
			this.CPUPage.Controls.Add(this.lblCPU);
			this.CPUPage.Controls.Add(this.lBTempCPU);
			this.CPUPage.Controls.Add(this.CPUName);
			this.CPUPage.Location = new System.Drawing.Point(124, 4);
			this.CPUPage.Name = "CPUPage";
			this.CPUPage.Padding = new System.Windows.Forms.Padding(3);
			this.CPUPage.Size = new System.Drawing.Size(688, 446);
			this.CPUPage.TabIndex = 0;
			this.CPUPage.Text = "CPU";
			// 
			// CPUSettings
			// 
			this.CPUSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CPUSettings.BackColor = System.Drawing.Color.White;
			this.CPUSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CPUSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CPUSettings.ForeColor = System.Drawing.Color.Black;
			this.CPUSettings.FormattingEnabled = true;
			this.CPUSettings.ItemHeight = 20;
			this.CPUSettings.Location = new System.Drawing.Point(330, 316);
			this.CPUSettings.Name = "CPUSettings";
			this.CPUSettings.Size = new System.Drawing.Size(350, 82);
			this.CPUSettings.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(274, 246);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 29);
			this.label3.TabIndex = 9;
			this.label3.Text = "Usage";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(16, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 42);
			this.label2.TabIndex = 8;
			this.label2.Text = "CPU";
			// 
			// CPUchart
			// 
			this.CPUchart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CPUchart.BorderlineColor = System.Drawing.Color.Silver;
			this.CPUchart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.Name = "CPU";
			this.CPUchart.ChartAreas.Add(chartArea1);
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.CPUchart.Legends.Add(legend1);
			this.CPUchart.Location = new System.Drawing.Point(23, 75);
			this.CPUchart.Name = "CPUchart";
			this.CPUchart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			series1.ChartArea = "CPU";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.LabelForeColor = System.Drawing.Color.DimGray;
			series1.Legend = "Legend1";
			series1.Name = "CPU";
			this.CPUchart.Series.Add(series1);
			this.CPUchart.Size = new System.Drawing.Size(657, 168);
			this.CPUchart.TabIndex = 7;
			this.CPUchart.Text = "chart1";
			title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
			title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			title1.Name = "%";
			title1.Text = "Usage %";
			this.CPUchart.Titles.Add(title1);
			// 
			// lblCPU
			// 
			this.lblCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCPU.AutoSize = true;
			this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblCPU.Location = new System.Drawing.Point(17, 269);
			this.lblCPU.Name = "lblCPU";
			this.lblCPU.Size = new System.Drawing.Size(57, 33);
			this.lblCPU.TabIndex = 6;
			this.lblCPU.Text = "0%";
			// 
			// lBTempCPU
			// 
			this.lBTempCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lBTempCPU.BackColor = System.Drawing.Color.White;
			this.lBTempCPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lBTempCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lBTempCPU.ForeColor = System.Drawing.Color.Black;
			this.lBTempCPU.FormattingEnabled = true;
			this.lBTempCPU.ItemHeight = 20;
			this.lBTempCPU.Location = new System.Drawing.Point(23, 316);
			this.lBTempCPU.Name = "lBTempCPU";
			this.lBTempCPU.Size = new System.Drawing.Size(279, 82);
			this.lBTempCPU.TabIndex = 1;
			// 
			// CPUName
			// 
			this.CPUName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CPUName.AutoSize = true;
			this.CPUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CPUName.ForeColor = System.Drawing.Color.Black;
			this.CPUName.Location = new System.Drawing.Point(174, 32);
			this.CPUName.Name = "CPUName";
			this.CPUName.Size = new System.Drawing.Size(128, 29);
			this.CPUName.TabIndex = 0;
			this.CPUName.Text = "CPUName";
			// 
			// RamPage
			// 
			this.RamPage.Controls.Add(this.label1);
			this.RamPage.Controls.Add(this.RamUsage);
			this.RamPage.Controls.Add(this.RamUsageGB);
			this.RamPage.Controls.Add(this.RAMChartGB);
			this.RamPage.Controls.Add(this.lblIR);
			this.RamPage.Controls.Add(this.InsRAM);
			this.RamPage.Controls.Add(this.lblRAMname);
			this.RamPage.Controls.Add(this.lblRAM);
			this.RamPage.Controls.Add(this.RAMChart);
			this.RamPage.Location = new System.Drawing.Point(124, 4);
			this.RamPage.Name = "RamPage";
			this.RamPage.Padding = new System.Windows.Forms.Padding(3);
			this.RamPage.Size = new System.Drawing.Size(688, 446);
			this.RamPage.TabIndex = 1;
			this.RamPage.Text = "MEMORY";
			this.RamPage.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(345, 347);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 25);
			this.label1.TabIndex = 16;
			this.label1.Text = "RAM available:";
			// 
			// RamUsage
			// 
			this.RamUsage.AutoSize = true;
			this.RamUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.RamUsage.Location = new System.Drawing.Point(18, 347);
			this.RamUsage.Name = "RamUsage";
			this.RamUsage.Size = new System.Drawing.Size(133, 25);
			this.RamUsage.TabIndex = 15;
			this.RamUsage.Text = "RAM Usage:";
			// 
			// RamUsageGB
			// 
			this.RamUsageGB.AutoSize = true;
			this.RamUsageGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RamUsageGB.Location = new System.Drawing.Point(508, 347);
			this.RamUsageGB.Name = "RamUsageGB";
			this.RamUsageGB.Size = new System.Drawing.Size(148, 25);
			this.RamUsageGB.TabIndex = 14;
			this.RamUsageGB.Text = "RamUsageGB";
			// 
			// RAMChartGB
			// 
			this.RAMChartGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.RAMChartGB.BorderlineColor = System.Drawing.Color.Silver;
			this.RAMChartGB.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea2.BorderColor = System.Drawing.Color.Silver;
			chartArea2.Name = "CPU";
			this.RAMChartGB.ChartAreas.Add(chartArea2);
			legend2.Enabled = false;
			legend2.ForeColor = System.Drawing.Color.Silver;
			legend2.HeaderSeparatorColor = System.Drawing.Color.Silver;
			legend2.ItemColumnSeparatorColor = System.Drawing.Color.Silver;
			legend2.Name = "Legend1";
			this.RAMChartGB.Legends.Add(legend2);
			this.RAMChartGB.Location = new System.Drawing.Point(352, 109);
			this.RAMChartGB.Name = "RAMChartGB";
			this.RAMChartGB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			series2.ChartArea = "CPU";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.LabelForeColor = System.Drawing.Color.Silver;
			series2.Legend = "Legend1";
			series2.Name = "RAMGB";
			series2.YValuesPerPoint = 2;
			this.RAMChartGB.Series.Add(series2);
			this.RAMChartGB.Size = new System.Drawing.Size(330, 191);
			this.RAMChartGB.TabIndex = 13;
			this.RAMChartGB.Text = "chart2";
			this.RAMChartGB.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
			title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
			title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			title2.Name = "Title1";
			title2.Text = "RAM";
			this.RAMChartGB.Titles.Add(title2);
			// 
			// lblIR
			// 
			this.lblIR.AutoSize = true;
			this.lblIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
			this.lblIR.Location = new System.Drawing.Point(344, 30);
			this.lblIR.Name = "lblIR";
			this.lblIR.Size = new System.Drawing.Size(204, 33);
			this.lblIR.TabIndex = 12;
			this.lblIR.Text = "RAM Installed:";
			// 
			// InsRAM
			// 
			this.InsRAM.AutoSize = true;
			this.InsRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
			this.InsRAM.Location = new System.Drawing.Point(553, 30);
			this.InsRAM.Name = "InsRAM";
			this.InsRAM.Size = new System.Drawing.Size(118, 33);
			this.InsRAM.TabIndex = 11;
			this.InsRAM.Text = "InsRAM";
			// 
			// lblRAMname
			// 
			this.lblRAMname.AutoSize = true;
			this.lblRAMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblRAMname.Location = new System.Drawing.Point(35, 25);
			this.lblRAMname.Name = "lblRAMname";
			this.lblRAMname.Size = new System.Drawing.Size(94, 39);
			this.lblRAMname.TabIndex = 10;
			this.lblRAMname.Text = "RAM";
			// 
			// lblRAM
			// 
			this.lblRAM.AutoSize = true;
			this.lblRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.lblRAM.Location = new System.Drawing.Point(157, 347);
			this.lblRAM.Name = "lblRAM";
			this.lblRAM.Size = new System.Drawing.Size(81, 25);
			this.lblRAM.TabIndex = 9;
			this.lblRAM.Text = "lblRAM";
			// 
			// RAMChart
			// 
			this.RAMChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.RAMChart.BorderlineColor = System.Drawing.Color.Silver;
			this.RAMChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea3.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea3.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea3.BorderColor = System.Drawing.Color.Silver;
			chartArea3.Name = "CPU";
			this.RAMChart.ChartAreas.Add(chartArea3);
			legend3.Enabled = false;
			legend3.ForeColor = System.Drawing.Color.Silver;
			legend3.HeaderSeparatorColor = System.Drawing.Color.Silver;
			legend3.ItemColumnSeparatorColor = System.Drawing.Color.Silver;
			legend3.Name = "Legend1";
			this.RAMChart.Legends.Add(legend3);
			this.RAMChart.Location = new System.Drawing.Point(25, 109);
			this.RAMChart.Name = "RAMChart";
			this.RAMChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			series3.ChartArea = "CPU";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series3.LabelForeColor = System.Drawing.Color.Silver;
			series3.Legend = "Legend1";
			series3.Name = "RAM";
			series3.YValuesPerPoint = 2;
			this.RAMChart.Series.Add(series3);
			this.RAMChart.Size = new System.Drawing.Size(321, 191);
			this.RAMChart.TabIndex = 8;
			this.RAMChart.Text = "chart2";
			this.RAMChart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
			title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
			title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			title3.Name = "Title1";
			title3.Text = "Usage %";
			this.RAMChart.Titles.Add(title3);
			// 
			// VideoPage
			// 
			this.VideoPage.Controls.Add(this.VideoName);
			this.VideoPage.Controls.Add(this.lblGPU);
			this.VideoPage.Controls.Add(this.videoInfo);
			this.VideoPage.Location = new System.Drawing.Point(124, 4);
			this.VideoPage.Name = "VideoPage";
			this.VideoPage.Size = new System.Drawing.Size(688, 446);
			this.VideoPage.TabIndex = 2;
			this.VideoPage.Text = "VIDEO";
			this.VideoPage.UseVisualStyleBackColor = true;
			// 
			// VideoName
			// 
			this.VideoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.VideoName.AutoSize = true;
			this.VideoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.VideoName.Location = new System.Drawing.Point(315, 86);
			this.VideoName.Name = "VideoName";
			this.VideoName.Size = new System.Drawing.Size(141, 29);
			this.VideoName.TabIndex = 4;
			this.VideoName.Text = "VideoName";
			// 
			// lblGPU
			// 
			this.lblGPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblGPU.AutoSize = true;
			this.lblGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
			this.lblGPU.Location = new System.Drawing.Point(23, 74);
			this.lblGPU.Name = "lblGPU";
			this.lblGPU.Size = new System.Drawing.Size(99, 42);
			this.lblGPU.TabIndex = 2;
			this.lblGPU.Text = "GPU";
			// 
			// videoInfo
			// 
			this.videoInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.videoInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.videoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.videoInfo.FormattingEnabled = true;
			this.videoInfo.ItemHeight = 25;
			this.videoInfo.Location = new System.Drawing.Point(30, 149);
			this.videoInfo.Name = "videoInfo";
			this.videoInfo.Size = new System.Drawing.Size(632, 225);
			this.videoInfo.TabIndex = 1;
			// 
			// DiskPage
			// 
			this.DiskPage.Controls.Add(this.letterDiskWork);
			this.DiskPage.Controls.Add(this.letterDisksys);
			this.DiskPage.Controls.Add(this.HardDriveName);
			this.DiskPage.Controls.Add(this.lblDiskD);
			this.DiskPage.Controls.Add(this.lblDiskC);
			this.DiskPage.Controls.Add(this.chartDiskD);
			this.DiskPage.Controls.Add(this.chartDiskC);
			this.DiskPage.Controls.Add(this.lbDiskMon);
			this.DiskPage.Controls.Add(this.label5);
			this.DiskPage.Location = new System.Drawing.Point(124, 4);
			this.DiskPage.Name = "DiskPage";
			this.DiskPage.Size = new System.Drawing.Size(688, 446);
			this.DiskPage.TabIndex = 3;
			this.DiskPage.Text = "DISKS";
			this.DiskPage.UseVisualStyleBackColor = true;
			// 
			// letterDiskWork
			// 
			this.letterDiskWork.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.letterDiskWork.AutoSize = true;
			this.letterDiskWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.letterDiskWork.Location = new System.Drawing.Point(338, 280);
			this.letterDiskWork.Name = "letterDiskWork";
			this.letterDiskWork.Size = new System.Drawing.Size(152, 25);
			this.letterDiskWork.TabIndex = 20;
			this.letterDiskWork.Text = "letterDiskWork";
			// 
			// letterDisksys
			// 
			this.letterDisksys.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.letterDisksys.AutoSize = true;
			this.letterDisksys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.letterDisksys.Location = new System.Drawing.Point(28, 280);
			this.letterDisksys.Name = "letterDisksys";
			this.letterDisksys.Size = new System.Drawing.Size(135, 25);
			this.letterDisksys.TabIndex = 19;
			this.letterDisksys.Text = "letterDisksys";
			// 
			// HardDriveName
			// 
			this.HardDriveName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.HardDriveName.AutoSize = true;
			this.HardDriveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.HardDriveName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.HardDriveName.Location = new System.Drawing.Point(143, 23);
			this.HardDriveName.Name = "HardDriveName";
			this.HardDriveName.Size = new System.Drawing.Size(209, 31);
			this.HardDriveName.TabIndex = 18;
			this.HardDriveName.Text = "HardDriveName";
			// 
			// lblDiskD
			// 
			this.lblDiskD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDiskD.AutoSize = true;
			this.lblDiskD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.lblDiskD.Location = new System.Drawing.Point(526, 280);
			this.lblDiskD.Name = "lblDiskD";
			this.lblDiskD.Size = new System.Drawing.Size(91, 25);
			this.lblDiskD.TabIndex = 17;
			this.lblDiskD.Text = "lblDiskD";
			// 
			// lblDiskC
			// 
			this.lblDiskC.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDiskC.AutoSize = true;
			this.lblDiskC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.lblDiskC.Location = new System.Drawing.Point(208, 280);
			this.lblDiskC.Name = "lblDiskC";
			this.lblDiskC.Size = new System.Drawing.Size(91, 25);
			this.lblDiskC.TabIndex = 16;
			this.lblDiskC.Text = "lblDiskC";
			// 
			// chartDiskD
			// 
			this.chartDiskD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chartDiskD.BorderlineColor = System.Drawing.Color.Silver;
			this.chartDiskD.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea4.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea4.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea4.BorderColor = System.Drawing.Color.Silver;
			chartArea4.Name = "CPU";
			this.chartDiskD.ChartAreas.Add(chartArea4);
			legend4.Enabled = false;
			legend4.ForeColor = System.Drawing.Color.Silver;
			legend4.HeaderSeparatorColor = System.Drawing.Color.Silver;
			legend4.ItemColumnSeparatorColor = System.Drawing.Color.Silver;
			legend4.Name = "Legend1";
			this.chartDiskD.Legends.Add(legend4);
			this.chartDiskD.Location = new System.Drawing.Point(343, 68);
			this.chartDiskD.Name = "chartDiskD";
			this.chartDiskD.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			series4.ChartArea = "CPU";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series4.LabelForeColor = System.Drawing.Color.Silver;
			series4.Legend = "Legend1";
			series4.Name = "DiskD";
			series4.YValuesPerPoint = 2;
			this.chartDiskD.Series.Add(series4);
			this.chartDiskD.Size = new System.Drawing.Size(321, 191);
			this.chartDiskD.TabIndex = 15;
			this.chartDiskD.Text = "chart2";
			this.chartDiskD.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
			title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
			title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			title4.Name = "Title1";
			title4.Text = "Usage %";
			this.chartDiskD.Titles.Add(title4);
			// 
			// chartDiskC
			// 
			this.chartDiskC.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chartDiskC.BorderlineColor = System.Drawing.Color.Silver;
			this.chartDiskC.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea5.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea5.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea5.BorderColor = System.Drawing.Color.Silver;
			chartArea5.Name = "CPU";
			this.chartDiskC.ChartAreas.Add(chartArea5);
			legend5.Enabled = false;
			legend5.ForeColor = System.Drawing.Color.Silver;
			legend5.HeaderSeparatorColor = System.Drawing.Color.Silver;
			legend5.ItemColumnSeparatorColor = System.Drawing.Color.Silver;
			legend5.Name = "Legend1";
			this.chartDiskC.Legends.Add(legend5);
			this.chartDiskC.Location = new System.Drawing.Point(16, 68);
			this.chartDiskC.Name = "chartDiskC";
			this.chartDiskC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			series5.ChartArea = "CPU";
			series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series5.LabelForeColor = System.Drawing.Color.Silver;
			series5.Legend = "Legend1";
			series5.Name = "DiskC";
			series5.YValuesPerPoint = 2;
			this.chartDiskC.Series.Add(series5);
			this.chartDiskC.Size = new System.Drawing.Size(321, 191);
			this.chartDiskC.TabIndex = 14;
			this.chartDiskC.Text = "chart2";
			this.chartDiskC.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
			title5.Alignment = System.Drawing.ContentAlignment.TopLeft;
			title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			title5.Name = "Title1";
			title5.Text = "Usage %";
			this.chartDiskC.Titles.Add(title5);
			// 
			// lbDiskMon
			// 
			this.lbDiskMon.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbDiskMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbDiskMon.FormattingEnabled = true;
			this.lbDiskMon.ItemHeight = 18;
			this.lbDiskMon.Location = new System.Drawing.Point(16, 320);
			this.lbDiskMon.Name = "lbDiskMon";
			this.lbDiskMon.Size = new System.Drawing.Size(611, 112);
			this.lbDiskMon.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(27, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 33);
			this.label5.TabIndex = 0;
			this.label5.Text = "Disk\'s";
			// 
			// InternetPage
			// 
			this.InternetPage.Controls.Add(this.InternetChart);
			this.InternetPage.Controls.Add(this.IntInfo);
			this.InternetPage.Controls.Add(this.lblDownload);
			this.InternetPage.Controls.Add(this.lblBytesSent);
			this.InternetPage.Controls.Add(this.lblSpeed);
			this.InternetPage.Controls.Add(this.lblUpload);
			this.InternetPage.Controls.Add(this.lblInterfaceType);
			this.InternetPage.Controls.Add(this.lblBytesReceived);
			this.InternetPage.Controls.Add(this.InternerBox);
			this.InternetPage.Controls.Add(this.cmbInterface);
			this.InternetPage.Location = new System.Drawing.Point(124, 4);
			this.InternetPage.Name = "InternetPage";
			this.InternetPage.Size = new System.Drawing.Size(688, 446);
			this.InternetPage.TabIndex = 4;
			this.InternetPage.Text = "INTERNET";
			this.InternetPage.UseVisualStyleBackColor = true;
			// 
			// InternetChart
			// 
			this.InternetChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.InternetChart.BorderlineColor = System.Drawing.Color.Silver;
			this.InternetChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea6.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea6.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea6.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea6.Name = "Inet";
			this.InternetChart.ChartAreas.Add(chartArea6);
			legend6.Enabled = false;
			legend6.Name = "Legend1";
			this.InternetChart.Legends.Add(legend6);
			this.InternetChart.Location = new System.Drawing.Point(16, 145);
			this.InternetChart.Name = "InternetChart";
			this.InternetChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
			series6.ChartArea = "Inet";
			series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series6.Legend = "Legend1";
			series6.Name = "UploadSpeed";
			series7.ChartArea = "Inet";
			series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series7.Legend = "Legend1";
			series7.Name = "LoadSpeed";
			this.InternetChart.Series.Add(series6);
			this.InternetChart.Series.Add(series7);
			this.InternetChart.Size = new System.Drawing.Size(657, 159);
			this.InternetChart.TabIndex = 23;
			this.InternetChart.Text = "chart2";
			this.InternetChart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
			title6.Alignment = System.Drawing.ContentAlignment.TopLeft;
			title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			title6.Name = "%";
			title6.Text = "Usage %";
			this.InternetChart.Titles.Add(title6);
			// 
			// IntInfo
			// 
			this.IntInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.IntInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.IntInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.IntInfo.FormattingEnabled = true;
			this.IntInfo.Location = new System.Drawing.Point(16, 312);
			this.IntInfo.Name = "IntInfo";
			this.IntInfo.Size = new System.Drawing.Size(652, 119);
			this.IntInfo.TabIndex = 22;
			// 
			// lblDownload
			// 
			this.lblDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDownload.AutoSize = true;
			this.lblDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblDownload.Location = new System.Drawing.Point(546, 391);
			this.lblDownload.Name = "lblDownload";
			this.lblDownload.Size = new System.Drawing.Size(95, 20);
			this.lblDownload.TabIndex = 20;
			this.lblDownload.Text = "lblDownload";
			this.lblDownload.Visible = false;
			// 
			// lblBytesSent
			// 
			this.lblBytesSent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBytesSent.AutoSize = true;
			this.lblBytesSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblBytesSent.Location = new System.Drawing.Point(342, 363);
			this.lblBytesSent.Name = "lblBytesSent";
			this.lblBytesSent.Size = new System.Drawing.Size(98, 20);
			this.lblBytesSent.TabIndex = 19;
			this.lblBytesSent.Text = "lblBytesSent";
			this.lblBytesSent.Visible = false;
			// 
			// lblSpeed
			// 
			this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSpeed.AutoSize = true;
			this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSpeed.Location = new System.Drawing.Point(342, 391);
			this.lblSpeed.Name = "lblSpeed";
			this.lblSpeed.Size = new System.Drawing.Size(71, 20);
			this.lblSpeed.TabIndex = 18;
			this.lblSpeed.Text = "lblSpeed";
			this.lblSpeed.Visible = false;
			// 
			// lblUpload
			// 
			this.lblUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUpload.AutoSize = true;
			this.lblUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblUpload.Location = new System.Drawing.Point(546, 363);
			this.lblUpload.Name = "lblUpload";
			this.lblUpload.Size = new System.Drawing.Size(75, 20);
			this.lblUpload.TabIndex = 17;
			this.lblUpload.Text = "lblUpload";
			this.lblUpload.Visible = false;
			// 
			// lblInterfaceType
			// 
			this.lblInterfaceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblInterfaceType.AutoSize = true;
			this.lblInterfaceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblInterfaceType.Location = new System.Drawing.Point(546, 336);
			this.lblInterfaceType.Name = "lblInterfaceType";
			this.lblInterfaceType.Size = new System.Drawing.Size(122, 20);
			this.lblInterfaceType.TabIndex = 16;
			this.lblInterfaceType.Text = "lblInterfaceType";
			this.lblInterfaceType.Visible = false;
			// 
			// lblBytesReceived
			// 
			this.lblBytesReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBytesReceived.AutoSize = true;
			this.lblBytesReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblBytesReceived.Location = new System.Drawing.Point(342, 336);
			this.lblBytesReceived.Name = "lblBytesReceived";
			this.lblBytesReceived.Size = new System.Drawing.Size(130, 20);
			this.lblBytesReceived.TabIndex = 15;
			this.lblBytesReceived.Text = "lblBytesReceived";
			this.lblBytesReceived.Visible = false;
			// 
			// InternerBox
			// 
			this.InternerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.InternerBox.FormattingEnabled = true;
			this.InternerBox.ItemHeight = 17;
			this.InternerBox.Location = new System.Drawing.Point(346, 14);
			this.InternerBox.Name = "InternerBox";
			this.InternerBox.Size = new System.Drawing.Size(324, 106);
			this.InternerBox.TabIndex = 14;
			// 
			// cmbInterface
			// 
			this.cmbInterface.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbInterface.FormattingEnabled = true;
			this.cmbInterface.ItemHeight = 17;
			this.cmbInterface.Location = new System.Drawing.Point(16, 14);
			this.cmbInterface.Name = "cmbInterface";
			this.cmbInterface.Size = new System.Drawing.Size(324, 106);
			this.cmbInterface.TabIndex = 7;
			// 
			// SystemPage
			// 
			this.SystemPage.Controls.Add(this.lVDiskMon);
			this.SystemPage.Controls.Add(this.lblSysInfo);
			this.SystemPage.Location = new System.Drawing.Point(124, 4);
			this.SystemPage.Name = "SystemPage";
			this.SystemPage.Size = new System.Drawing.Size(688, 446);
			this.SystemPage.TabIndex = 5;
			this.SystemPage.Text = "SYSINFO";
			this.SystemPage.UseVisualStyleBackColor = true;
			// 
			// lVDiskMon
			// 
			this.lVDiskMon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lVDiskMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Field,
            this.Value});
			this.lVDiskMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			listViewGroup1.Header = "Computer";
			listViewGroup1.Name = "Computer";
			listViewGroup2.Header = "Motherboard";
			listViewGroup2.Name = "Motherboard";
			listViewGroup3.Header = "Display";
			listViewGroup3.Name = "Display";
			listViewGroup4.Header = "Folder";
			listViewGroup4.Name = "Folder";
			listViewGroup5.Header = "Network";
			listViewGroup5.Name = "Network";
			this.lVDiskMon.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
			this.lVDiskMon.Location = new System.Drawing.Point(12, 41);
			this.lVDiskMon.MultiSelect = false;
			this.lVDiskMon.Name = "lVDiskMon";
			this.lVDiskMon.Size = new System.Drawing.Size(668, 400);
			this.lVDiskMon.SmallImageList = this.imageList1;
			this.lVDiskMon.TabIndex = 1;
			this.lVDiskMon.UseCompatibleStateImageBehavior = false;
			this.lVDiskMon.View = System.Windows.Forms.View.Details;
			// 
			// Field
			// 
			this.Field.Text = "Field";
			this.Field.Width = 244;
			// 
			// Value
			// 
			this.Value.Text = "Value";
			this.Value.Width = 472;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lblSysInfo
			// 
			this.lblSysInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSysInfo.AutoSize = true;
			this.lblSysInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSysInfo.Location = new System.Drawing.Point(19, 18);
			this.lblSysInfo.Name = "lblSysInfo";
			this.lblSysInfo.Size = new System.Drawing.Size(123, 20);
			this.lblSysInfo.TabIndex = 0;
			this.lblSysInfo.Text = "Full System Info";
			// 
			// SaveAs
			// 
			this.SaveAs.BackColor = System.Drawing.Color.White;
			this.SaveAs.Controls.Add(this.textBox1);
			this.SaveAs.Controls.Add(this.SaveTXT);
			this.SaveAs.Controls.Add(this.OpenQ);
			this.SaveAs.Controls.Add(this.SaveQR);
			this.SaveAs.Controls.Add(this.pictureBox2);
			this.SaveAs.Location = new System.Drawing.Point(124, 4);
			this.SaveAs.Name = "SaveAs";
			this.SaveAs.Size = new System.Drawing.Size(688, 446);
			this.SaveAs.TabIndex = 7;
			this.SaveAs.Text = "SAVEAS";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(344, 25);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(286, 277);
			this.textBox1.TabIndex = 4;
			// 
			// SaveTXT
			// 
			this.SaveTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveTXT.Location = new System.Drawing.Point(503, 380);
			this.SaveTXT.Name = "SaveTXT";
			this.SaveTXT.Size = new System.Drawing.Size(115, 44);
			this.SaveTXT.TabIndex = 2;
			this.SaveTXT.Text = "SaveTXT";
			this.SaveTXT.UseVisualStyleBackColor = true;
			this.SaveTXT.Click += new System.EventHandler(this.SaveTXT_Click_1);
			// 
			// OpenQ
			// 
			this.OpenQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.OpenQ.Location = new System.Drawing.Point(265, 380);
			this.OpenQ.Name = "OpenQ";
			this.OpenQ.Size = new System.Drawing.Size(115, 44);
			this.OpenQ.TabIndex = 1;
			this.OpenQ.Text = "OpenQR";
			this.OpenQ.UseVisualStyleBackColor = true;
			this.OpenQ.Click += new System.EventHandler(this.OpenQ_Click);
			// 
			// SaveQR
			// 
			this.SaveQR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveQR.Location = new System.Drawing.Point(15, 380);
			this.SaveQR.Name = "SaveQR";
			this.SaveQR.Size = new System.Drawing.Size(115, 44);
			this.SaveQR.TabIndex = 0;
			this.SaveQR.Text = "SaveQR";
			this.SaveQR.UseVisualStyleBackColor = true;
			this.SaveQR.Click += new System.EventHandler(this.SaveQR_Click_1);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(15, 25);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(287, 277);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// qwe
			// 
			this.qwe.Location = new System.Drawing.Point(395, 352);
			this.qwe.Name = "qwe";
			this.qwe.Size = new System.Drawing.Size(110, 50);
			this.qwe.TabIndex = 2;
			this.qwe.Text = "SaveTXT";
			this.qwe.UseVisualStyleBackColor = true;
			// 
			// qwer
			// 
			this.qwer.Location = new System.Drawing.Point(163, 352);
			this.qwer.Name = "qwer";
			this.qwer.Size = new System.Drawing.Size(110, 50);
			this.qwer.TabIndex = 0;
			this.qwer.Text = "SaveQR";
			this.qwer.UseVisualStyleBackColor = true;
			// 
			// pCPU
			// 
			this.pCPU.CategoryName = "Процессор";
			this.pCPU.CounterName = "% загруженности процессора";
			this.pCPU.InstanceName = "_Total";
			// 
			// pRAM
			// 
			this.pRAM.CategoryName = "Память";
			this.pRAM.CounterName = "% использования выделенной памяти";
			// 
			// pRAMGB
			// 
			this.pRAMGB.CategoryName = "Память";
			this.pRAMGB.CounterName = "Доступно байт";
			// 
			// pDiskС
			// 
			this.pDiskС.CategoryName = "Логический диск";
			this.pDiskС.CounterName = "% активности диска";
			this.pDiskС.InstanceName = "C:";
			// 
			// pDiskD
			// 
			this.pDiskD.CategoryName = "Логический диск";
			this.pDiskD.CounterName = "% активности диска";
			this.pDiskD.InstanceName = "D:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(816, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.updateSpeedToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.updateToolStripMenuItem.Text = "Update";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
			// 
			// updateSpeedToolStripMenuItem
			// 
			this.updateSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highToolStripMenuItem,
            this.averageToolStripMenuItem,
            this.lowToolStripMenuItem});
			this.updateSpeedToolStripMenuItem.Name = "updateSpeedToolStripMenuItem";
			this.updateSpeedToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.updateSpeedToolStripMenuItem.Text = "Update speed";
			// 
			// highToolStripMenuItem
			// 
			this.highToolStripMenuItem.Name = "highToolStripMenuItem";
			this.highToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.highToolStripMenuItem.Text = "High";
			this.highToolStripMenuItem.Click += new System.EventHandler(this.hightToolStripMenuItem_Click);
			// 
			// averageToolStripMenuItem
			// 
			this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
			this.averageToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.averageToolStripMenuItem.Text = "Usual";
			this.averageToolStripMenuItem.Click += new System.EventHandler(this.averageToolStripMenuItem_Click);
			// 
			// lowToolStripMenuItem
			// 
			this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
			this.lowToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.lowToolStripMenuItem.Text = "Low";
			this.lowToolStripMenuItem.Click += new System.EventHandler(this.lowToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutProgramToolStripMenuItem
			// 
			this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
			this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.aboutProgramToolStripMenuItem.Text = "About program";
			this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
			// 
			// timer0
			// 
			this.timer0.Interval = 1000;
			this.timer0.Tick += new System.EventHandler(this.timer0_Tick);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 1000;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// timer3
			// 
			this.timer3.Interval = 1000;
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(159, 45);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(342, 234);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(816, 481);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(832, 519);
			this.Name = "MainForm";
			this.Text = "ROIS";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.CPUPage.ResumeLayout(false);
			this.CPUPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CPUchart)).EndInit();
			this.RamPage.ResumeLayout(false);
			this.RamPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RAMChartGB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RAMChart)).EndInit();
			this.VideoPage.ResumeLayout(false);
			this.VideoPage.PerformLayout();
			this.DiskPage.ResumeLayout(false);
			this.DiskPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartDiskD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartDiskC)).EndInit();
			this.InternetPage.ResumeLayout(false);
			this.InternetPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.InternetChart)).EndInit();
			this.SystemPage.ResumeLayout(false);
			this.SystemPage.PerformLayout();
			this.SaveAs.ResumeLayout(false);
			this.SaveAs.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pRAMGB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pDiskС)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pDiskD)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage CPUPage;
		private System.Windows.Forms.Label CPUName;
		private System.Windows.Forms.TabPage RamPage;
		private System.Windows.Forms.TabPage VideoPage;
		private System.Windows.Forms.TabPage DiskPage;
		private System.Windows.Forms.TabPage InternetPage;
		private System.Windows.Forms.TabPage SystemPage;
		private System.Windows.Forms.TabPage SaveAs;
		private System.Windows.Forms.ListBox lBTempCPU;
		private System.Diagnostics.PerformanceCounter pCPU;
		private System.Windows.Forms.Label lblCPU;
		private System.Windows.Forms.DataVisualization.Charting.Chart CPUchart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox cmbInterface;
		private System.Windows.Forms.ListBox InternerBox;
		private System.Windows.Forms.ListBox CPUSettings;
		private System.Windows.Forms.Label lblDownload;
		private System.Windows.Forms.Label lblBytesSent;
		private System.Windows.Forms.Label lblSpeed;
		private System.Windows.Forms.Label lblUpload;
		private System.Windows.Forms.Label lblInterfaceType;
		private System.Windows.Forms.Label lblBytesReceived;
		private System.Windows.Forms.Label lblRAM;
		private System.Windows.Forms.DataVisualization.Charting.Chart RAMChart;
		private System.Diagnostics.PerformanceCounter pRAM;
		private System.Windows.Forms.Label lblRAMname;
		private System.Windows.Forms.Label InsRAM;
		private System.Windows.Forms.Label lblIR;
		private System.Windows.Forms.DataVisualization.Charting.Chart RAMChartGB;
		private System.Windows.Forms.Label RamUsageGB;
		private System.Diagnostics.PerformanceCounter pRAMGB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label RamUsage;
		private System.Windows.Forms.ListBox IntInfo;
		private System.Windows.Forms.DataVisualization.Charting.Chart InternetChart;
		private System.Windows.Forms.ListBox videoInfo;
		private System.Windows.Forms.Label lblGPU;
		private System.Windows.Forms.Label VideoName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblSysInfo;
		private System.Diagnostics.PerformanceCounter pDiskС;
		private System.Windows.Forms.ListBox lbDiskMon;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartDiskD;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartDiskC;
		private System.Diagnostics.PerformanceCounter pDiskD;
		private System.Windows.Forms.Label lblDiskD;
		private System.Windows.Forms.Label lblDiskC;
		private System.Windows.Forms.Label HardDriveName;
		private System.Windows.Forms.Label letterDiskWork;
		private System.Windows.Forms.Label letterDisksys;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ColumnHeader Field;
		private System.Windows.Forms.ColumnHeader Value;
		private System.Windows.Forms.Button qwer;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button qwe;
		public System.Windows.Forms.ListView lVDiskMon;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button SaveTXT;
		private System.Windows.Forms.Button OpenQ;
		private System.Windows.Forms.Button SaveQR;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateSpeedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
		private System.Windows.Forms.Timer timer0;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
	}
}

