﻿namespace VendingMachine
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
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Coins";
			// 
			// labelCoins
			// 
			this.labelCoins.AutoSize = true;
			this.labelCoins.Location = new System.Drawing.Point(58, 13);
			this.labelCoins.Name = "labelCoins";
			this.labelCoins.Size = new System.Drawing.Size(41, 15);
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
			this.checkBoxAcceptMoney.Size = new System.Drawing.Size(105, 19);
			this.checkBoxAcceptMoney.TabIndex = 3;
			this.checkBoxAcceptMoney.Text = "Accept money";
			this.checkBoxAcceptMoney.UseVisualStyleBackColor = true;
			this.checkBoxAcceptMoney.CheckedChanged += new System.EventHandler(this.checkBoxAcceptMoney_CheckedChanged);
			// 
			// VendingMachineMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 394);
			this.Controls.Add(this.checkBoxAcceptMoney);
			this.Controls.Add(this.listBoxReceived);
			this.Controls.Add(this.labelCoins);
			this.Controls.Add(this.label1);
			this.Name = "VendingMachineMainForm";
			this.Text = "VendingMachineMainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelCoins;
		private System.Windows.Forms.ListBox listBoxReceived;
		private System.Windows.Forms.CheckBox checkBoxAcceptMoney;
	}
}

