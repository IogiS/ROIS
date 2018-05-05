using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Drawing;
using System.IO;
using System.Text;
using ZXing;

namespace MonitoringProgramm
{
	public partial class MainForm : Form
	{
		CPUMonitor _cpum;
		RAMMonitor _ramm;
		UpdateNetwork _UpNet;
		static HardwareInfo _hardI = new HardwareInfo();
		public NetworkInterface[] nicArr;
		VideoCard _vCard;
		DiskMonitor _diskMon;
		SystemInfo _sysInf;
		public MainForm()
		{


			InitializeComponent();

			_cpum = new CPUMonitor(lBTempCPU, pCPU, lblCPU, CPUchart, cores, CPUSettings, CPUName);
			_ramm = new RAMMonitor(pRAM, pRAMGB, lblRAM, RamUsageGB, RAMChart, RAMChartGB, instRAM, InsRAM);
			_UpNet = new UpdateNetwork(InternetChart, IntInfo, cmbInterface, lblBytesReceived, lblBytesSent, lblSpeed, lblInterfaceType, lblUpload, lblDownload, nicArr);
			_vCard = new VideoCard(videoInfo, VideoName);
			_diskMon = new DiskMonitor(lbDiskMon, pDiskС, pDiskD, lblDiskC, lblDiskD, chartDiskC, chartDiskD, HardDriveName, letterDisksys, letterDiskWork);
			_sysInf = new SystemInfo(lVDiskMon);

			lbls();
			internet();

			_UpNet.InitializeNetworkInterface();
			_vCard.GPUMInf();
			_diskMon.DiskInfo();
			_sysInf.ShowSystemInfo();
		}

		double instRAM = Math.Round(Convert.ToDouble(new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory) / 1073741824);

		public byte cores = Convert.ToByte(_hardI.GetHardwareInfo("Win32_Processor", "NumberOfCores"));
		public void lbls()
		{
			_cpum.CPUlabels();
			_ramm.Ramlbl();
			lblBytesReceived.Text = "0";
			lblBytesSent.Text = "0";
			_diskMon.Disklbl();
		}

		private void timer3_Tick(object sender, EventArgs e)
		{	
			_UpNet.UpdateNetworkInterface();
		}
		private void timer2_Tick(object sender, EventArgs e)
		{
			_diskMon.Usage();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			_ramm.Usage();
		}
		private void timer0_Tick(object sender, EventArgs e)
		{
			_cpum._monitorCPU();
			_cpum.Usage();
		}
		private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
		{
			Graphics g;
			string sText;
			int iX;
			float iY;

			SizeF sizeText;
			TabControl ctlTab;

			ctlTab = (TabControl)sender;

			g = e.Graphics;

			sText = ctlTab.TabPages[e.Index].Text;
			sizeText = g.MeasureString(sText, ctlTab.Font);
			iX = e.Bounds.Left + 6;
			iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;
			g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY);
		}

		public void internet()
		{
			InternetConnection inet = new InternetConnection();
			inet.Init();
			InternerBox.Items.Add("Internet connection: " + inet.IsInternetConnected);
			InternerBox.Items.Add("In an offline: " + inet.IsOffline);
			InternerBox.Items.Add("Via modem: " + inet.IsUsingModem);
			InternerBox.Items.Add("By LAN: " + inet.IsUsingLAN);
			InternerBox.Items.Add("A proxy is used: " + inet.IsUsingProxy);
			InternerBox.Items.Add("Is RAS installed: " + inet.IsRasEnabled);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			timer0.Start();
		}

		public void SaveInFile()
		{
			SaveFileDialog savefile = new SaveFileDialog();
			StringBuilder builder = new StringBuilder();
			// set a default file name
			savefile.FileName = "unknown.txt";
			// set filters - this can be done in properties as well
			savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

			if (savefile.ShowDialog() == DialogResult.OK)
			{
				StreamWriter writer = new StreamWriter(savefile.FileName);
				foreach (ListViewItem item in _sysInf.lVDiskMon.Items)
				{
					foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
					{
						builder.Append(subItem.Text).Append(" ");
					}
					writer.WriteLine(builder.ToString());
					builder.Clear();
				}
				writer.Close();
			}
		}
		public void SaveInQRcode()
		{
			ZXing.QrCode.QrCodeEncodingOptions opt = new ZXing.QrCode.QrCodeEncodingOptions
			{
				CharacterSet = "utf-8",
				Height = 200,
				Width = 200
			};
			IBarcodeWriter writer = new BarcodeWriter
			{
				Format = BarcodeFormat.QR_CODE,
				Options = opt
			};
			try
			{
				SaveFileDialog savefile = new SaveFileDialog();
				StringBuilder builder = new StringBuilder();
				// set a default file name
				savefile.FileName = "unknown.bmp";
				// set filters - this can be done in properties as well
				savefile.Filter = "Bitmap (*.bmp)|*.bmp|All files (*.*)|*.*";

				if (savefile.ShowDialog() == DialogResult.OK)
				{
					string barstr = "";
					foreach (ListViewItem item in _sysInf.lVDiskMon.Items)
					{
						foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
						{
							builder.Append(subItem.Text).Append(" ");
						}
						barstr += "\n" + builder.ToString();
						builder.Clear();

						//var barcodeWriter = new BarcodeWriter();

						// set the barcode format
						//writer.Format = BarcodeFormat.QR_CODE;


						// write text and generate a 2-D barcode as a bitmap
						writer.Write(barstr).Save(savefile.FileName);

					}
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}
		public void OpenQR()
		{

			IBarcodeReader barcodeReader = new BarcodeReader();
			try
			{
				OpenFileDialog load = new OpenFileDialog(); //  load будет запрашивать у пользователя место, из которого он хочет загрузить файл.
				if (load.ShowDialog() == System.Windows.Forms.DialogResult.OK) // //если пользователь нажимает в обозревателе кнопку "Открыть".
				{
					pictureBox2.ImageLocation = load.FileName; // в pictureBox'e открывается файл, который был по пути, запрошенном пользователем.
				}
				else
				{
					return;
				}
				load.Filter = "Bitmap (*.bmp)|*.bmp|All files (*.*)|*.*";

				// create an in memory bitmap
				var barcodeBitmap = (Bitmap)Bitmap.FromFile(load.FileName);
				// decode the barcode from the in memory bitmap
				var barcodeResult = barcodeReader.Decode(barcodeBitmap);
				// output results to console
				textBox1.Text = barcodeResult?.Text;

				MessageBox.Show($"Barcode format: {barcodeResult?.BarcodeFormat}");
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}
		private void SaveQR_Click_1(object sender, EventArgs e)
		{
			SaveInQRcode();
		}
		private void OpenQ_Click(object sender, EventArgs e)
		{
			OpenQR();
		}
		private void SaveTXT_Click_1(object sender, EventArgs e)
		{
			SaveInFile();
		}
		private void hightToolStripMenuItem_Click(object sender, EventArgs e)
		{
			timer0.Interval = 500;
			timer1.Interval = 500;
			timer2.Interval = 500;
			timer3.Interval = 500;
		}
		private void lowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			timer0.Interval = 5000;
			timer1.Interval = 5000;
			timer2.Interval = 5000;
			timer3.Interval = 5000;
		}
		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CPUchart.Series[0].Points.Clear();
			RAMChart.Series[0].Points.Clear();
			RAMChartGB.Series[0].Points.Clear();
			chartDiskC.Series[0].Points.Clear(); 
			chartDiskD.Series[0].Points.Clear();
			InternetChart.Series[0].Points.Clear();
			InternetChart.Series[1].Points.Clear();
		}
		private void averageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			timer0.Interval = 1000;
			timer1.Interval = 1000;
			timer2.Interval = 1000;
			timer3.Interval = 1000;
		}
		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			timer0.Stop();
			timer1.Stop();
			timer2.Stop();
			timer3.Stop();

			if (tabControl1.SelectedIndex == 0)
			{
				timer0.Start();
			}
			if (tabControl1.SelectedIndex == 1)
			{
				timer1.Start();
			}
			if (tabControl1.SelectedIndex == 3)
			{
				timer2.Start();
			}
			if (tabControl1.SelectedIndex == 4)
			{
				timer3.Start();
			}
		}
		private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutProgramm f2 = new AboutProgramm();
			f2.Show();
		}


	}
}