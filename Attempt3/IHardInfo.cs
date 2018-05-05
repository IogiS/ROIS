using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringProgramm
{
	 interface IHardInfo
	{
		string GetHardwareInfo(string WIN32_Class, string ClassItemField);
	}
}
