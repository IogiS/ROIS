using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.IO;

namespace MonitoringProgramm
{
	class DiskMonitor : HardwareInfo
	{

		static HardwareInfo GetHard = new HardwareInfo();

		public ListBox lbDiskMon { get; private set; }
		public PerformanceCounter pDiskD { get; private set; }
		public Label lblDiskC { get; private set; }
		public Label lblDiskD { get; private set; }
		public Chart chartDiskC { get; private set; }
		public Chart chartDiskD { get; private set; }
		public PerformanceCounter pDiskС { get; private set; }
		public Label HardDriveName { get; private set; }
		public Label letterDisksys { get; private set; }
		public Label letterDiskWork { get; private set; }

		public DiskMonitor(ListBox lbdm, PerformanceCounter pdc, PerformanceCounter pdd, Label lbldc, Label lbldd, Chart chdc, Chart chdd, Label hdm, Label lds, Label ldw)
		{

			lbDiskMon = lbdm;
			pDiskС = pdc;
			pDiskD = pdd;
			lblDiskC = lbldc;
			lblDiskD = lbldd;
			chartDiskC = chdc;
			chartDiskD = chdd;
			HardDriveName = hdm;
			letterDisksys = lds;
			letterDiskWork = ldw;
		}

		override public void Usage()
		{
			float fdiskC = pDiskС.NextValue();
			float fdiskD = pDiskD.NextValue();
			lblDiskC.Text = string.Format("{0:0.00}%", fdiskC);
			lblDiskD.Text = string.Format("{0:0.00}%", fdiskD);
			while (chartDiskC.Series[0].Points.Count > 60 && chartDiskC.Series[0].Points.Count > 60)
			{
				chartDiskC.Series[0].Points.RemoveAt(0);
				chartDiskD.Series[0].Points.RemoveAt(0);
			}
			chartDiskC.Series["DiskC"].Points.AddY(fdiskC);
			chartDiskD.Series["DiskD"].Points.AddY(fdiskD);
		}

		public void Disklbl()
		{
			// Флаг для порядка вывода логических дисков
			bool flag = true; 
			HardDriveName.Text = GetHardwareInfo("Win32_DiskDrive", "Caption");
			foreach (DriveInfo dI in DriveInfo.GetDrives())
			{
				if (dI.IsReady)
				{
					if (flag == true)
					{ 
						letterDisksys.Text = Convert.ToString("Диск: " + dI.Name);
						flag = false;
						continue;
					}
					else
						letterDiskWork.Text = Convert.ToString("Диск: " + dI.Name);
				}
			}
		}

		public void DiskInfo()
		{
			lbDiskMon.Items.Add("Локальные диски: ");
			foreach (DriveInfo dI in DriveInfo.GetDrives())
			{
				if (dI.IsReady)
				{
					lbDiskMon.Items.Add("Диск: " + dI.Name);
					lbDiskMon.Items.Add("Формат диска: " + dI.DriveFormat);
					lbDiskMon.Items.Add("Размер диска (ГБ): " + Convert.ToDouble((dI.TotalSize / 1073741824)));
					lbDiskMon.Items.Add("Доступное свободное место(ГБ): " + Convert.ToDouble((dI.AvailableFreeSpace / 1073741824)));
					lbDiskMon.Items.Add("" + GetHard.GetHardwareInfo("Win32_DiskDrive", "Model"));
				}
				else
				{
					continue;
				}
			}
		}
	}
}
