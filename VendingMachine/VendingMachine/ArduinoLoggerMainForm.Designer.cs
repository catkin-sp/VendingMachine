namespace VendingMachine
{
	partial class ArduinoLoggerMainForm
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
			this.listBoxReceived = new System.Windows.Forms.ListBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			this.comboBoxPorts = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBoxReceived
			// 
			this.listBoxReceived.FormattingEnabled = true;
			this.listBoxReceived.ItemHeight = 20;
			this.listBoxReceived.Location = new System.Drawing.Point(24, 106);
			this.listBoxReceived.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBoxReceived.Name = "listBoxReceived";
			this.listBoxReceived.Size = new System.Drawing.Size(940, 464);
			this.listBoxReceived.TabIndex = 2;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(634, 43);
			this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(112, 35);
			this.buttonStart.TabIndex = 4;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonStop
			// 
			this.buttonStop.Enabled = false;
			this.buttonStop.Location = new System.Drawing.Point(756, 43);
			this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(112, 35);
			this.buttonStop.TabIndex = 5;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// comboBoxPorts
			// 
			this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPorts.FormattingEnabled = true;
			this.comboBoxPorts.Location = new System.Drawing.Point(444, 46);
			this.comboBoxPorts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxPorts.Name = "comboBoxPorts";
			this.comboBoxPorts.Size = new System.Drawing.Size(180, 28);
			this.comboBoxPorts.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(370, 51);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Port:";
			// 
			// ArduinoLoggerMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1002, 606);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxPorts);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.listBoxReceived);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ArduinoLoggerMainForm";
			this.Text = "Arduino Logger v2016.0609";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.VendingMachineMainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ListBox listBoxReceived;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.ComboBox comboBoxPorts;
		private System.Windows.Forms.Label label2;
	}
}

