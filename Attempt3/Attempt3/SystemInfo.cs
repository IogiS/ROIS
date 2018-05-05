using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Microsoft.Win32;

namespace MonitoringProgramm
{
	class SystemInfo : HardwareInfo
	{
		byte f = 0;
		static HardwareInfo HardI = new HardwareInfo();
		double instRAM = Math.Round(Convert.ToDouble(new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory) / 1073741824);
		static string Host = System.Net.Dns.GetHostName();
		System.Net.IPAddress ip = System.Net.Dns.GetHostByName(Host).AddressList[0];
		public SystemInfo(ListView lvdn)
			{
			lVDiskMon = lvdn;
			}

		public ListView lVDiskMon { get; private set; }

		public void ShowSystemInfo()
		{
			// Adds the first item to the first group
			ImageList imageList = new ImageList();
			lVDiskMon.SmallImageList = imageList;
			byte countGroups = 0;
			double totalSize = 0;
			byte img = 12;
			//Images
			for (int i = 1; i < 15; ++i)
				imageList.Images.Add(Image.FromFile(i + ".png"));



			lVDiskMon.Items.Add("Operating system: ").SubItems.Add("" + HardI.GetHardwareInfo("Win32_OperatingSystem", "Caption"));
			lVDiskMon.Items.Add("Processor bit: ").SubItems.Add("" + HardI.GetHardwareInfo("Win32_OperatingSystem", "OSArchitecture"));
			lVDiskMon.Items.Add("MachineName: ").SubItems.Add("" + Environment.MachineName);
			lVDiskMon.Items.Add("User: ").SubItems.Add("" + Environment.UserName);
			lVDiskMon.Items.Add("DirectX: ").SubItems.Add("" + GetDirectxMajorVersion());
			lVDiskMon.Items.Add("CPU: ").SubItems.Add("" + HardI.GetHardwareInfo("Win32_Processor", "Name"));
			lVDiskMon.Items.Add("Motherboard: ").SubItems.Add("" + HardI.GetHardwareInfo("Win32_ComputerSystem", "Model") );
			lVDiskMon.Items.Add("Installed RAM: ").SubItems.Add("" + instRAM);
			lVDiskMon.Items.Add("Type BIOS: ").SubItems.Add("" + HardI.GetHardwareInfo("Win32_BIOS", "SMBIOSBIOSVersion"));
			lVDiskMon.Items.Add("Video Adapter: ").SubItems.Add("" + HardI.GetHardwareInfo("Win32_VideoController", "Name"));
			lVDiskMon.Items.Add("Accelerator Capabilities: ").SubItems.Add("" + HardI.GetHardwareInfo("Win32_VideoController", "AcceleratorCapabilities"));
			lVDiskMon.Items.Add("Disk: ").SubItems.Add("" + HardI.GetHardwareInfo("Win32_DiskDrive", "Caption"));
			foreach (DriveInfo dI in DriveInfo.GetDrives())
			{

				if (f == 2)
					break;
				if (dI.IsReady)
				{
					lVDiskMon.Items.Add(string.Format("Disk: {0} ({1})", dI.Name, dI.DriveFormat)).SubItems.Add(string.Format("{0} ({1} available)",
						Convert.ToDouble((dI.TotalSize / 1073741824)), Convert.ToDouble((dI.AvailableFreeSpace / 1073741824))));
					totalSize += Convert.ToDouble((dI.TotalSize / 1073741824));
					f++;
				}
				
				else
				{
					continue;
				}
			}
			lVDiskMon.Items.Add("Total Size: ").SubItems.Add("" + totalSize + "GB");
			lVDiskMon.Items.Add("Network adapter: ").SubItems.Add(HardI.GetHardwareInfo("Win32_NetworkAdapter WHERE Name = 'Realtek PCIe FE Family Controller'", "Name"));
			lVDiskMon.Items.Add("IP-adress: ").SubItems.Add("" + ip.ToString());


			for (int g = 0; g < lVDiskMon.Items.Count; g++)
			{
				if (g == 5 || g == 9 || g == 11 || g == 15)
				{
					countGroups++;
					lVDiskMon.Items[g].Group = lVDiskMon.Groups[countGroups];
					lVDiskMon.Items[g].ImageIndex = g;
					if (g == 15)
					{
						lVDiskMon.Items[g].Group = lVDiskMon.Groups[countGroups];
						lVDiskMon.Items[g].ImageIndex = img;
						img++;
					}
				}
				else if (g >= 11 && g < 15)
				{
					lVDiskMon.Items[g].Group = lVDiskMon.Groups[countGroups];
					lVDiskMon.Items[g].ImageIndex = 11;
				}
				else if (g > 14)
				{
					lVDiskMon.Items[g].Group = lVDiskMon.Groups[countGroups];
					lVDiskMon.Items[g].ImageIndex = img;
					img++;
				}
				else
				{
					lVDiskMon.Items[g].Group = lVDiskMon.Groups[countGroups];
					lVDiskMon.Items[g].ImageIndex = g;
				}

			}
			//countGroups++;
		}
		private int GetDirectxMajorVersion()
		{
			int directxMajorVersion = 0;

			var OSVersion = Environment.OSVersion;

			// if Windows Vista or later
			if (OSVersion.Version.Major >= 6)
			{
				// if Windows 7 or later
				if (OSVersion.Version.Major > 6 || OSVersion.Version.Minor >= 1)
				{
					directxMajorVersion = 11;
				}
				// if Windows Vista
				else
				{
					directxMajorVersion = 10;
				}
			}
			// if Windows XP or earlier.
			else
			{
				using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\DirectX"))
				{
					string versionStr = key.GetValue("Version") as string;
					if (!string.IsNullOrEmpty(versionStr))
					{
						var versionComponents = versionStr.Split('.');
						if (versionComponents.Length > 1)
						{
							int directXLevel;
							if (int.TryParse(versionComponents[1], out directXLevel))
							{
								directxMajorVersion = directXLevel;
							}
						}
					}
				}
			}

			return directxMajorVersion;
		}
	}
}
