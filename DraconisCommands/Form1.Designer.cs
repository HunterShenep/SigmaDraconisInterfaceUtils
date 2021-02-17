
namespace DraconisCommands
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSaveSteam64orUsername = new System.Windows.Forms.Button();
			this.lblSteam64orUsername = new System.Windows.Forms.Label();
			this.txtSteam64orUsername = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.comboServers = new System.Windows.Forms.ComboBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(13, 13);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(775, 425);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.AllowDrop = true;
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(767, 399);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Tickets";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.panel1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(767, 399);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Settings";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.Controls.Add(this.btnSaveSteam64orUsername);
			this.panel1.Controls.Add(this.lblSteam64orUsername);
			this.panel1.Controls.Add(this.txtSteam64orUsername);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(326, 381);
			this.panel1.TabIndex = 0;
			// 
			// btnSaveSteam64orUsername
			// 
			this.btnSaveSteam64orUsername.Location = new System.Drawing.Point(231, 63);
			this.btnSaveSteam64orUsername.Name = "btnSaveSteam64orUsername";
			this.btnSaveSteam64orUsername.Size = new System.Drawing.Size(75, 23);
			this.btnSaveSteam64orUsername.TabIndex = 2;
			this.btnSaveSteam64orUsername.Text = "Save";
			this.btnSaveSteam64orUsername.UseVisualStyleBackColor = true;
			this.btnSaveSteam64orUsername.Click += new System.EventHandler(this.saveSteam64orUsername);
			// 
			// lblSteam64orUsername
			// 
			this.lblSteam64orUsername.AutoSize = true;
			this.lblSteam64orUsername.Location = new System.Drawing.Point(12, 21);
			this.lblSteam64orUsername.Name = "lblSteam64orUsername";
			this.lblSteam64orUsername.Size = new System.Drawing.Size(112, 13);
			this.lblSteam64orUsername.TabIndex = 1;
			this.lblSteam64orUsername.Text = "Steam64 or Username";
			// 
			// txtSteam64orUsername
			// 
			this.txtSteam64orUsername.Location = new System.Drawing.Point(15, 37);
			this.txtSteam64orUsername.Name = "txtSteam64orUsername";
			this.txtSteam64orUsername.Size = new System.Drawing.Size(291, 20);
			this.txtSteam64orUsername.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Beige;
			this.panel2.Controls.Add(this.comboServers);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Location = new System.Drawing.Point(6, 9);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(755, 45);
			this.panel2.TabIndex = 1;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.panel3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(767, 399);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Gainsboro;
			this.panel3.Location = new System.Drawing.Point(220, 177);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(326, 45);
			this.panel3.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(67, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 28);
			this.button1.TabIndex = 0;
			this.button1.Text = "Admin Mode";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// comboServers
			// 
			this.comboServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboServers.FormattingEnabled = true;
			this.comboServers.ItemHeight = 20;
			this.comboServers.Location = new System.Drawing.Point(10, 9);
			this.comboServers.Name = "comboServers";
			this.comboServers.Size = new System.Drawing.Size(51, 28);
			this.comboServers.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Sigma Draconis | Command Helper";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSaveSteam64orUsername;
		private System.Windows.Forms.Label lblSteam64orUsername;
		private System.Windows.Forms.TextBox txtSteam64orUsername;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ComboBox comboServers;
	}
}

