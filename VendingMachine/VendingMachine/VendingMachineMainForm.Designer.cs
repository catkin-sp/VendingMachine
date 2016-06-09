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
			this.labelConnectionState = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Coins";
			// 
			// labelCoins
			// 
			this.labelCoins.AutoSize = true;
			this.labelCoins.Location = new System.Drawing.Point(87, 20);
			this.labelCoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelCoins.Name = "labelCoins";
			this.labelCoins.Size = new System.Drawing.Size(51, 20);
			this.labelCoins.TabIndex = 1;
			this.labelCoins.Text = "label2";
			// 
			// listBoxReceived
			// 
			this.listBoxReceived.FormattingEnabled = true;
			this.listBoxReceived.ItemHeight = 20;
			this.listBoxReceived.Location = new System.Drawing.Point(24, 186);
			this.listBoxReceived.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBoxReceived.Name = "listBoxReceived";
			this.listBoxReceived.Size = new System.Drawing.Size(940, 384);
			this.listBoxReceived.TabIndex = 2;
			// 
			// checkBoxAcceptMoney
			// 
			this.checkBoxAcceptMoney.AutoSize = true;
			this.checkBoxAcceptMoney.Location = new System.Drawing.Point(18, 63);
			this.checkBoxAcceptMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxAcceptMoney.Name = "checkBoxAcceptMoney";
			this.checkBoxAcceptMoney.Size = new System.Drawing.Size(136, 24);
			this.checkBoxAcceptMoney.TabIndex = 3;
			this.checkBoxAcceptMoney.Text = "Accept money";
			this.checkBoxAcceptMoney.UseVisualStyleBackColor = true;
			this.checkBoxAcceptMoney.CheckedChanged += new System.EventHandler(this.checkBoxAcceptMoney_CheckedChanged);
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
			// labelConnectionState
			// 
			this.labelConnectionState.AutoSize = true;
			this.labelConnectionState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelConnectionState.Location = new System.Drawing.Point(370, 115);
			this.labelConnectionState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelConnectionState.Name = "labelConnectionState";
			this.labelConnectionState.Size = new System.Drawing.Size(0, 29);
			this.labelConnectionState.TabIndex = 8;
			// 
			// VendingMachineMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1002, 606);
			this.Controls.Add(this.labelConnectionState);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxPorts);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.checkBoxAcceptMoney);
			this.Controls.Add(this.listBoxReceived);
			this.Controls.Add(this.labelCoins);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "VendingMachineMainForm";
			this.Text = "Vending Machine v2016.0609";
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
		private System.Windows.Forms.Label labelConnectionState;
	}
}

