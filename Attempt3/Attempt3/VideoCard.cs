using System;
using System.Windows.Forms;

namespace MonitoringProgramm
{
	class VideoCard : HardwareInfo
	{

		static HardwareInfo HardI = new HardwareInfo();

		public ListBox videoInfo { get; private set; }
		public Label VideoName { get; private set; }

		public VideoCard(ListBox vi, Label vidn )
		{
			videoInfo = vi;
			VideoName = vidn;
		}
		public void GPUMInf()
		{
			VideoName.Text = HardI.GetHardwareInfo("Win32_VideoController", "Name");
			videoInfo.Items.Add("Видеопроцессор: " + HardI.GetHardwareInfo("Win32_VideoController", "VideoProcessor"));

			videoInfo.Items.Add("Версия драйвера:" + HardI.GetHardwareInfo("Win32_VideoController", "DriverVersion"));
			videoInfo.Items.Add(String.Format("Adapter Compatibility : {0} ", HardI.GetHardwareInfo("Win32_VideoController", "AdapterCompatibility")));
			videoInfo.Items.Add(String.Format("Объем памяти : {0:0.0} GB", Convert.ToDouble(HardI.GetHardwareInfo("Win32_VideoController", "AdapterRAM")) / 1073741824));

		}
	}
}
