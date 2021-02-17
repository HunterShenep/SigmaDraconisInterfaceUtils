
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
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblTopAlert = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSaveSteam64orUsername = new System.Windows.Forms.Button();
			this.lblSteam64orUsername = new System.Windows.Forms.Label();
			this.txtSteam64orUsername = new System.Windows.Forms.TextBox();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel4 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnTicketsAdminMode = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblTicketsServerDesc = new System.Windows.Forms.Label();
			this.comboServers = new System.Windows.Forms.ComboBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Gainsboro;
			this.panel3.Location = new System.Drawing.Point(220, 177);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(326, 45);
			this.panel3.TabIndex = 2;
			// 
			// lblTopAlert
			// 
			this.lblTopAlert.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblTopAlert.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.lblTopAlert.Location = new System.Drawing.Point(-21, 0);
			this.lblTopAlert.Name = "lblTopAlert";
			this.lblTopAlert.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTopAlert.Size = new System.Drawing.Size(794, 23);
			this.lblTopAlert.TabIndex = 1;
			this.lblTopAlert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(767, 281);
			this.tabPage3.TabIndex = 2;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.panel1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(767, 281);
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
			this.btnSaveSteam64orUsername.Click += new System.EventHandler(this.saveSteam64orUsername_click);
			// 
			// lblSteam64orUsername
			// 
			this.lblSteam64orUsername.AutoSize = true;
			this.lblSteam64orUsername.Location = new System.Drawing.Point(12, 21);
			this.lblSteam64orUsername.Name = "lblSteam64orUsername";
			this.lblSteam64orUsername.Size = new System.Drawing.Size(131, 16);
			this.lblSteam64orUsername.TabIndex = 1;
			this.lblSteam64orUsername.Text = "Steam64 or Username";
			// 
			// txtSteam64orUsername
			// 
			this.txtSteam64orUsername.Location = new System.Drawing.Point(15, 37);
			this.txtSteam64orUsername.Name = "txtSteam64orUsername";
			this.txtSteam64orUsername.Size = new System.Drawing.Size(291, 21);
			this.txtSteam64orUsername.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.AllowDrop = true;
			this.tabPage1.Controls.Add(this.panel4);
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(767, 278);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Tickets";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.button6);
			this.panel4.Controls.Add(this.button5);
			this.panel4.Controls.Add(this.button4);
			this.panel4.Controls.Add(this.button3);
			this.panel4.Controls.Add(this.button2);
			this.panel4.Controls.Add(this.button1);
			this.panel4.Controls.Add(this.btnTicketsAdminMode);
			this.panel4.Location = new System.Drawing.Point(6, 60);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(755, 215);
			this.panel4.TabIndex = 6;
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(446, 175);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(150, 37);
			this.button6.TabIndex = 6;
			this.button6.Text = "Clear Admin";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(602, 175);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(150, 37);
			this.button5.TabIndex = 5;
			this.button5.Text = "Run Me After";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(10, 54);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(166, 36);
			this.button4.TabIndex = 4;
			this.button4.Text = "Scripter Access";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(354, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(166, 36);
			this.button3.TabIndex = 3;
			this.button3.Text = "List Owned Grids";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(182, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(166, 36);
			this.button2.TabIndex = 2;
			this.button2.Text = "List Hangar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(10, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 36);
			this.button1.TabIndex = 1;
			this.button1.Text = "List Grid Backups";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnTicketsAdminMode
			// 
			this.btnTicketsAdminMode.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTicketsAdminMode.Location = new System.Drawing.Point(3, 175);
			this.btnTicketsAdminMode.Name = "btnTicketsAdminMode";
			this.btnTicketsAdminMode.Size = new System.Drawing.Size(150, 37);
			this.btnTicketsAdminMode.TabIndex = 0;
			this.btnTicketsAdminMode.Text = "Admin Mode";
			this.btnTicketsAdminMode.UseVisualStyleBackColor = true;
			this.btnTicketsAdminMode.Click += new System.EventHandler(this.btnTicketsAdminMode_click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Beige;
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.lblTicketsServerDesc);
			this.panel2.Controls.Add(this.comboServers);
			this.panel2.Location = new System.Drawing.Point(6, 9);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(755, 45);
			this.panel2.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(213, 10);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(141, 27);
			this.textBox1.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(142, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Player:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Server: ";
			// 
			// lblTicketsServerDesc
			// 
			this.lblTicketsServerDesc.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblTicketsServerDesc.Location = new System.Drawing.Point(503, 12);
			this.lblTicketsServerDesc.Name = "lblTicketsServerDesc";
			this.lblTicketsServerDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTicketsServerDesc.Size = new System.Drawing.Size(249, 23);
			this.lblTicketsServerDesc.TabIndex = 2;
			this.lblTicketsServerDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboServers
			// 
			this.comboServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboServers.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboServers.FormattingEnabled = true;
			this.comboServers.ItemHeight = 24;
			this.comboServers.Location = new System.Drawing.Point(83, 9);
			this.comboServers.Name = "comboServers";
			this.comboServers.Size = new System.Drawing.Size(51, 32);
			this.comboServers.TabIndex = 2;
			this.comboServers.SelectedIndexChanged += new System.EventHandler(this.updateTicketsServerDesc);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(2, 26);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(775, 307);
			this.tabControl1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 333);
			this.Controls.Add(this.lblTopAlert);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Sigma Draconis | Command Helper";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabPage2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblTopAlert;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSaveSteam64orUsername;
		private System.Windows.Forms.Label lblSteam64orUsername;
		private System.Windows.Forms.TextBox txtSteam64orUsername;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnTicketsAdminMode;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTicketsServerDesc;
		private System.Windows.Forms.ComboBox comboServers;
		private System.Windows.Forms.TabControl tabControl1;
	}
}

