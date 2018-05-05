using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System;


namespace MonitoringProgramm
{
	public class CPUMonitor : HardwareInfo 
	{

		static HardwareInfo GetHard = new HardwareInfo();

		public ListBox lBTempCPU { get; private set; }
		public PerformanceCounter pCPU { get; private set; }
		public Label lblCPU { get; private set; }
		public Chart CPUchart { get; private set; }
		public ListBox CPUSettings { get; private set; }
		public Label CPUName { get; private set; }

		int cores;
		public CPUMonitor(ListBox lb, PerformanceCounter pc, Label lbs, Chart chart, int sad, ListBox CPUS , Label CPUN)
		{
			lBTempCPU = lb;
			pCPU = pc;
			lblCPU = lbs;
			CPUchart = chart;
			cores = sad;
			CPUSettings = CPUS;
			CPUName = CPUN;
		}
		override public void Usage()
		{
			float fcpu = pCPU.NextValue();
			lblCPU.Text = string.Format("{0:0.00}%", fcpu);
			while (CPUchart.Series[0].Points.Count > 60)
			{
				CPUchart.Series[0].Points.RemoveAt(0);
			}
			CPUchart.ChartAreas[0].AxisY.Maximum = 100;
			CPUchart.ChartAreas[0].AxisY.Interval = 10;
			CPUchart.Series["CPU"].Points.AddY(fcpu);
		}
		public void _monitorCPU()
		{
			byte i = 0;
			lBTempCPU.BeginUpdate();
			lBTempCPU.Items.Clear();
			Computer c = new Computer();
			c.CPUEnabled = true;
			c.Open();
			foreach (var hardware in c.Hardware)
			{
				if (hardware.HardwareType == HardwareType.CPU)
				{
					hardware.Update();

					foreach (var sensors in hardware.Sensors)
					{
						if (sensors.SensorType == SensorType.Temperature)
						{
							i++;
							if (cores + 1 == i)
							{
								lBTempCPU.Items.Add("CPU Package : " + sensors.Max.GetValueOrDefault().ToString() + "°C");
							}
							else
							{
								lBTempCPU.Items.Add("CPU Core #" + i + ": " + sensors.Max.GetValueOrDefault().ToString() + "°C");
							}
						}

					}

				}

			}
			lBTempCPU.EndUpdate();

		}


		public void CPUlabels()
		{
			CPUSettings.Items.Add("NumberOfCores: " + GetHard.GetHardwareInfo("Win32_Processor", "NumberOfCores"));
			CPUSettings.Items.Add("NumberOfLogicalProcessors: " + GetHard.GetHardwareInfo("Win32_Processor", "NumberOfLogicalProcessors"));
			CPUSettings.Items.Add("Caption: " + GetHard.GetHardwareInfo("Win32_Processor", "Caption"));
			CPUSettings.Items.Add("Manufacturer: " + GetHard.GetHardwareInfo("Win32_Processor", "Manufacturer"));
			CPUName.Text = GetHard.GetHardwareInfo("Win32_Processor", "Name");
		}
	}
}
