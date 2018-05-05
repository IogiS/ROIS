using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;
namespace MonitoringProgramm
{
	class UpdateNetwork
	{
		public UpdateNetwork(Chart ich, ListBox lb, ListBox cmb, Label lblbr, Label lblbs, Label spd, Label Type, Label lblU, Label lblL, NetworkInterface[] Nic)

		{
			//InternetChart IntInfo cmbInterface lblBytesReceived lblBytesSent lblSpeed lblInterfaceType lblUpload lblDownload
			InternetChart = ich;
			IntInfo = lb;
			cmbInterface = cmb;
			lblBytesReceived = lblbr;
			lblBytesSent = lblbs;
			lblSpeed = spd;
			lblInterfaceType = Type;
			lblUpload = lblU;
			lblDownload = lblL;
			nicArr = Nic;
		}

		static string Host = System.Net.Dns.GetHostName();
		System.Net.IPAddress ip = System.Net.Dns.GetHostByName(Host).AddressList[0];
		public ListBox IntInfo { get; private set; }
		public ListBox cmbInterface { get; private set; }
		public Label lblBytesReceived { get; private set; }
		public Label lblBytesSent { get; private set; }
		public Label lblSpeed { get; private set; }
		public Label lblInterfaceType { get; private set; }
		public Label lblUpload { get; private set; }
		public Label lblDownload { get; private set; }
		public Chart InternetChart { get; private set; }
		public NetworkInterface[] nicArr { get; private set; }


		public void UpdateNetworkInterface()
		{
			IntInfo.Items.Clear();
			/// Grab NetworkInterface object that describes the current interface
			NetworkInterface nic = nicArr[cmbInterface.SelectedIndex];

			// Grab the stats for that interface
			IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();

			// Calculate the speed of bytes going in and out
			// NOTE: we could use something faster and more reliable than Windows Forms Timer

			int bytesReceivedSpeed = (int)(interfaceStats.BytesReceived - double.Parse(lblBytesReceived.Text)) / 1024;
			int bytesSentSpeed = (int)(interfaceStats.BytesSent - double.Parse(lblBytesSent.Text)) / 1024;


			// Update the labels
			lblSpeed.Text = "Speed Line :" + (nicArr[cmbInterface.SelectedIndex].Speed / 1000000).ToString() + " MB/sec";
			lblInterfaceType.Text = "InterfaceType :" + nicArr[cmbInterface.SelectedIndex].NetworkInterfaceType.ToString();
			lblBytesReceived.Text = interfaceStats.BytesReceived.ToString();
			lblBytesSent.Text = interfaceStats.BytesSent.ToString();
			lblUpload.Text = bytesSentSpeed.ToString();
			lblDownload.Text = bytesReceivedSpeed.ToString();
			//+" KB/s"
			double upload = Convert.ToDouble(lblUpload.Text) / 100;
			double download = Convert.ToDouble(lblDownload.Text) / 100;
			InternetChart.ChartAreas[0].AxisY.Minimum = 0;
			InternetChart.ChartAreas[0].AxisY.Interval = 12.5;
			if (upload >= 0 && upload <= 100 && download >= 0 && download <= 100)
			{
				InternetChart.Series["UploadSpeed"].Points.AddY(upload);
				InternetChart.Series["LoadSpeed"].Points.AddY(download);
			}
			while (InternetChart.Series[0].Points.Count > 60)
			{
				InternetChart.Series[0].Points.RemoveAt(0);
				InternetChart.Series[1].Points.RemoveAt(0);
			}
			//Edit ListBox INtInfo with informationn Internet connection

			IntInfo.BeginUpdate();
			IntInfo.Items.Add("Speed Line :" + (nicArr[cmbInterface.SelectedIndex].Speed / 1000000).ToString() + " MB/sec");
			IntInfo.Items.Add(lblInterfaceType.Text = "InterfaceType :" + nicArr[cmbInterface.SelectedIndex].NetworkInterfaceType.ToString());
			IntInfo.Items.Add("Bytes Received :" + lblBytesReceived.Text);
			IntInfo.Items.Add("Bytes Sent :" + lblBytesSent.Text);
			IntInfo.Items.Add(string.Format("Usage Network: {0:0.00}%", download));
			IntInfo.Items.Add("Upload   Speed :" + bytesSentSpeed.ToString() + " KB/s");
			IntInfo.Items.Add("Download Speed :" + bytesReceivedSpeed.ToString() + " KB/s");
			IntInfo.Items.Add("Host name: " + Host);
			IntInfo.Items.Add("IP: " + ip.ToString());
			IntInfo.EndUpdate();

		}
		public void InitializeNetworkInterface()
		{
			// Grab all local interfaces to this computer
			nicArr = NetworkInterface.GetAllNetworkInterfaces();

			// Add each interface name to the combo box
			for (int i = 0; i < nicArr.Length; i++)
				cmbInterface.Items.Add(nicArr[i].Name);

			// Change the initial selection to the first interface
			cmbInterface.SelectedIndex = 0;
		}


	}
}
