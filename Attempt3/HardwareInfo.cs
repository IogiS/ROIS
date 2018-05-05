using System;
using System.Management;
using System.Windows;

namespace MonitoringProgramm
{
	public class HardwareInfo : IHardInfo
	{
		public string GetHardwareInfo(string WIN32_Class, string ClassItemField)
		{
			string result = "";

			ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);

			try
			{
				foreach (ManagementObject obj in searcher.Get())
				{
					result = obj[ClassItemField].ToString().Trim();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return result;
		}

		public virtual void Usage() { }
		

		
	}
}
