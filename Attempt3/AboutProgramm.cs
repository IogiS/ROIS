using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringProgramm
{
	public partial class AboutProgramm : Form
	{
		public AboutProgramm()
		{

			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Form2_Load(object sender, EventArgs e)
		{
			label9.Text = "Reveal\r\nOf\r\nInformation\r\nStatistics";
			txtDescription.Text = "The program is useful to those who work or hobby related to the need to monitor the state of the computer boot. Also, a visual representation of the level of CPU utilization and all kinds of computer memory will provide significant assistance in diagnosing the problem.";
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
			
		}
	}
}
