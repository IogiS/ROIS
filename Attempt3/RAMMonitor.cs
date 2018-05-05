using System;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;
using System.Net.NetworkInformation;
using System.Net;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using System.Management;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
namespace MonitoringProgramm
{
	class RAMMonitor  : HardwareInfo
	{
		public RAMMonitor(PerformanceCounter pc, PerformanceCounter pc2, Label lbl, Label lblRamUsageGB, Chart chart, Chart cRamGB, double instRAMm, Label IR)
		{
			pRAMGB = pc2;
			pRAM = pc;
			lblRAM = lbl;
			RAMChart = chart;
			lblRAMname = lbl;
			RAMChartGB = cRamGB;
			RamUsageGB = lblRamUsageGB;
			instRAM = instRAMm;
			InsRAM = IR;
		}
		public PerformanceCounter pRAM { get; private set; }
		public PerformanceCounter pRAMGB { get; private set; }
		public Label lblRAM { get; private set; }
		public Label RamUsageGB { get; private set; }
		public Chart RAMChart { get; private set; }
		public Label lblRAMname { get; private set; }
		public Chart RAMChartGB { get; private set; }
		public double instRAM { get; private set; }
		public Label InsRAM { get; private set; }

	    override public void Usage()
		{
			float framGB = pRAMGB.NextValue() / 1073741824;
			float fram = pRAM.NextValue();
			lblRAM.Text = string.Format("{0:0.00}%", fram);
			RamUsageGB.Text = string.Format("{0} / {1:0.00}GB", instRAM, framGB);
			RAMChartGB.ChartAreas[0].AxisY.Maximum = instRAM;
			RAMChart.ChartAreas[0].AxisY.Maximum = 100;
			RAMChartGB.Series["RAMGB"].Points.AddY(framGB);
			RAMChart.Series["RAM"].Points.AddY(fram);

			while (RAMChart.Series[0].Points.Count > 60 &&
				RAMChartGB.Series[0].Points.Count > 60)
			{
				RAMChart.Series[0].Points.RemoveAt(0);
				RAMChartGB.Series[0].Points.RemoveAt(0);
			}
		}
		public void Ramlbl()
		{
			lblRAMname.Text = Convert.ToString(GetHardwareInfo("Win32_PhysicalMemory", "Name"));
			InsRAM.Text = instRAM + " GB";
		}
	}
}
