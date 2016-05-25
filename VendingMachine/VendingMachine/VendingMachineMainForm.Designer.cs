namespace VendingMachine
{
	partial class VendingMachineMainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.labelCoins = new System.Windows.Forms.Label();
			this.listBoxReceived = new System.Windows.Forms.ListBox();
			this.checkBoxAcceptMoney = new System.Windows.Forms.CheckBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			this.comboBoxPorts = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Coins";
			// 
			// labelCoins
			// 
			this.labelCoins.AutoSize = true;
			this.labelCoins.Location = new System.Drawing.Point(58, 13);
			this.labelCoins.Name = "labelCoins";
			this.labelCoins.Size = new System.Drawing.Size(35, 13);
			this.labelCoins.TabIndex = 1;
			this.labelCoins.Text = "label2";
			// 
			// listBoxReceived
			// 
			this.listBoxReceived.FormattingEnabled = true;
			this.listBoxReceived.Location = new System.Drawing.Point(16, 82);
			this.listBoxReceived.Name = "listBoxReceived";
			this.listBoxReceived.Size = new System.Drawing.Size(628, 290);
			this.listBoxReceived.TabIndex = 2;
			// 
			// checkBoxAcceptMoney
			// 
			this.checkBoxAcceptMoney.AutoSize = true;
			this.checkBoxAcceptMoney.Location = new System.Drawing.Point(12, 41);
			this.checkBoxAcceptMoney.Name = "checkBoxAcceptMoney";
			this.checkBoxAcceptMoney.Size = new System.Drawing.Size(101, 21);
			this.checkBoxAcceptMoney.TabIndex = 3;
			this.checkBoxAcceptMoney.Text = "Accept money";
			this.checkBoxAcceptMoney.UseVisualStyleBackColor = true;
			this.checkBoxAcceptMoney.CheckedChanged += new System.EventHandler(this.checkBoxAcceptMoney_CheckedChanged);
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(423, 28);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 23);
			this.buttonStart.TabIndex = 4;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonStop
			// 
			this.buttonStop.Enabled = false;
			this.buttonStop.Location = new System.Drawing.Point(504, 28);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(75, 23);
			this.buttonStop.TabIndex = 5;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// comboBoxPorts
			// 
			this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPorts.FormattingEnabled = true;
			this.comboBoxPorts.Location = new System.Drawing.Point(296, 30);
			this.comboBoxPorts.Name = "comboBoxPorts";
			this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
			this.comboBoxPorts.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(247, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Port:";
			// 
			// VendingMachineMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 394);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxPorts);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.checkBoxAcceptMoney);
			this.Controls.Add(this.listBoxReceived);
			this.Controls.Add(this.labelCoins);
			this.Controls.Add(this.label1);
			this.Name = "VendingMachineMainForm";
			this.Text = "VendingMachineMainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.VendingMachineMainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelCoins;
		private System.Windows.Forms.ListBox listBoxReceived;
		private System.Windows.Forms.CheckBox checkBoxAcceptMoney;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.ComboBox comboBoxPorts;
		private System.Windows.Forms.Label label2;
	}
}

