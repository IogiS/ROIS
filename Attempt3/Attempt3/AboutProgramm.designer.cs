namespace MonitoringProgramm
{
	partial class AboutProgramm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProgramm));
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 8.25F);
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(85, 17);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(34, 14);
			this.label9.TabIndex = 1;
			this.label9.Text = "label9";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(91, 112);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(224, 55);
			this.label10.TabIndex = 2;
			this.label10.Text = "Welcome";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.BlueViolet;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.ForeColor = System.Drawing.SystemColors.Window;
			this.button3.Location = new System.Drawing.Point(125, 327);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(133, 29);
			this.button3.TabIndex = 10;
			this.button3.Text = "CLOSE";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// txtDescription
			// 
			this.txtDescription.BackColor = System.Drawing.Color.Black;
			this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtDescription.ForeColor = System.Drawing.Color.White;
			this.txtDescription.Location = new System.Drawing.Point(12, 192);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ReadOnly = true;
			this.txtDescription.Size = new System.Drawing.Size(385, 86);
			this.txtDescription.TabIndex = 11;
			this.txtDescription.Text = resources.GetString("txtDescription.Text");
			this.txtDescription.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Attempt3.Properties.Resources.photofacefun_com_1520368341;
			this.pictureBox2.InitialImage = global::Attempt3.Properties.Resources.photofacefun_com_1520368341;
			this.pictureBox2.Location = new System.Drawing.Point(17, 16);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(62, 59);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// AboutProgramm
			// 
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(409, 393);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.pictureBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AboutProgramm";
			this.Text = "ROIS";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox txtDescription;
	}
}