
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
			this.btnTicketsClearAdminMode = new System.Windows.Forms.Button();
			this.btnTicketsAdminModeAfter = new System.Windows.Forms.Button();
			this.btnTicketsGiveScripterAccess = new System.Windows.Forms.Button();
			this.btnTicketsListOwnedGrids = new System.Windows.Forms.Button();
			this.btnTicketsListHangarContents = new System.Windows.Forms.Button();
			this.btnTicketsListGridBackups = new System.Windows.Forms.Button();
			this.btnTicketsAdminMode = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtTicketsPlayer = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblTicketsServerDesc = new System.Windows.Forms.Label();
			this.comboServers = new System.Windows.Forms.ComboBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.btnTicketsListAuthoredGrids = new System.Windows.Forms.Button();
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
			this.lblTopAlert.Location = new System.Drawing.Point(-17, 0);
			this.lblTopAlert.Name = "lblTopAlert";
			this.lblTopAlert.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTopAlert.Size = new System.Drawing.Size(794, 23);
			this.lblTopAlert.TabIndex = 1;
			this.lblTopAlert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(767, 278);
			this.tabPage3.TabIndex = 2;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.panel1);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(767, 278);
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
			this.panel1.Size = new System.Drawing.Size(368, 105);
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
			this.lblSteam64orUsername.Size = new System.Drawing.Size(159, 16);
			this.lblSteam64orUsername.TabIndex = 1;
			this.lblSteam64orUsername.Text = "Your Steam64 or Username";
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
			this.tabPage1.Size = new System.Drawing.Size(767, 225);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Tickets";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.btnTicketsListAuthoredGrids);
			this.panel4.Controls.Add(this.btnTicketsClearAdminMode);
			this.panel4.Controls.Add(this.btnTicketsAdminModeAfter);
			this.panel4.Controls.Add(this.btnTicketsGiveScripterAccess);
			this.panel4.Controls.Add(this.btnTicketsListOwnedGrids);
			this.panel4.Controls.Add(this.btnTicketsListHangarContents);
			this.panel4.Controls.Add(this.btnTicketsListGridBackups);
			this.panel4.Controls.Add(this.btnTicketsAdminMode);
			this.panel4.Location = new System.Drawing.Point(6, 60);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(755, 159);
			this.panel4.TabIndex = 6;
			// 
			// btnTicketsClearAdminMode
			// 
			this.btnTicketsClearAdminMode.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTicketsClearAdminMode.Location = new System.Drawing.Point(446, 113);
			this.btnTicketsClearAdminMode.Name = "btnTicketsClearAdminMode";
			this.btnTicketsClearAdminMode.Size = new System.Drawing.Size(150, 37);
			this.btnTicketsClearAdminMode.TabIndex = 6;
			this.btnTicketsClearAdminMode.Text = "Clear Admin";
			this.btnTicketsClearAdminMode.UseVisualStyleBackColor = true;
			this.btnTicketsClearAdminMode.Click += new System.EventHandler(this.btnTicketsClearAdminMode_Click);
			// 
			// btnTicketsAdminModeAfter
			// 
			this.btnTicketsAdminModeAfter.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTicketsAdminModeAfter.Location = new System.Drawing.Point(602, 113);
			this.btnTicketsAdminModeAfter.Name = "btnTicketsAdminModeAfter";
			this.btnTicketsAdminModeAfter.Size = new System.Drawing.Size(150, 37);
			this.btnTicketsAdminModeAfter.TabIndex = 5;
			this.btnTicketsAdminModeAfter.Text = "<- Run Me After";
			this.btnTicketsAdminModeAfter.UseVisualStyleBackColor = true;
			this.btnTicketsAdminModeAfter.Click += new System.EventHandler(this.btnTicketsAdminModeAfter_Click);
			// 
			// btnTicketsGiveScripterAccess
			// 
			this.btnTicketsGiveScripterAccess.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTicketsGiveScripterAccess.Location = new System.Drawing.Point(10, 54);
			this.btnTicketsGiveScripterAccess.Name = "btnTicketsGiveScripterAccess";
			this.btnTicketsGiveScripterAccess.Size = new System.Drawing.Size(166, 36);
			this.btnTicketsGiveScripterAccess.TabIndex = 4;
			this.btnTicketsGiveScripterAccess.Text = "Scripter Access";
			this.btnTicketsGiveScripterAccess.UseVisualStyleBackColor = true;
			this.btnTicketsGiveScripterAccess.Click += new System.EventHandler(this.btnTicketsGiveScripterAccess_Click);
			// 
			// btnTicketsListOwnedGrids
			// 
			this.btnTicketsListOwnedGrids.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTicketsListOwnedGrids.Location = new System.Drawing.Point(354, 12);
			this.btnTicketsListOwnedGrids.Name = "btnTicketsListOwnedGrids";
			this.btnTicketsListOwnedGrids.Size = new System.Drawing.Size(166, 36);
			this.btnTicketsListOwnedGrids.TabIndex = 3;
			this.btnTicketsListOwnedGrids.Text = "List Owned Grids";
			this.btnTicketsListOwnedGrids.UseVisualStyleBackColor = true;
			this.btnTicketsListOwnedGrids.Click += new System.EventHandler(this.btnTicketsListOwnedGrids_Click);
			// 
			// btnTicketsListHangarContents
			// 
			this.btnTicketsListHangarContents.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTicketsListHangarContents.Location = new System.Drawing.Point(182, 12);
			this.btnTicketsListHangarContents.Name = "btnTicketsListHangarContents";
			this.btnTicketsListHangarContents.Size = new System.Drawing.Size(166, 36);
			this.btnTicketsListHangarContents.TabIndex = 2;
			this.btnTicketsListHangarContents.Text = "List Hangar";
			this.btnTicketsListHangarContents.UseVisualStyleBackColor = true;
			this.btnTicketsListHangarContents.Click += new System.EventHandler(this.btnTicketsListHangarContents_Click);
			// 
			// btnTicketsListGridBackups
			// 
			this.btnTicketsListGridBackups.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTicketsListGridBackups.Location = new System.Drawing.Point(10, 12);
			this.btnTicketsListGridBackups.Name = "btnTicketsListGridBackups";
			this.btnTicketsListGridBackups.Size = new System.Drawing.Size(166, 36);
			this.btnTicketsListGridBackups.TabIndex = 1;
			this.btnTicketsListGridBackups.Text = "List Grid Backups";
			this.btnTicketsListGridBackups.UseVisualStyleBackColor = true;
			this.btnTicketsListGridBackups.Click += new System.EventHandler(this.btnTicketsListGridBackups_Click);
			// 
			// btnTicketsAdminMode
			// 
			this.btnTicketsAdminMode.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTicketsAdminMode.Location = new System.Drawing.Point(10, 113);
			this.btnTicketsAdminMode.Name = "btnTicketsAdminMode";
			this.btnTicketsAdminMode.Size = new System.Drawing.Size(166, 37);
			this.btnTicketsAdminMode.TabIndex = 0;
			this.btnTicketsAdminMode.Text = "Admin Mode";
			this.btnTicketsAdminMode.UseVisualStyleBackColor = true;
			this.btnTicketsAdminMode.Click += new System.EventHandler(this.btnTicketsAdminMode_click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Beige;
			this.panel2.Controls.Add(this.txtTicketsPlayer);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.lblTicketsServerDesc);
			this.panel2.Controls.Add(this.comboServers);
			this.panel2.Location = new System.Drawing.Point(6, 9);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(755, 45);
			this.panel2.TabIndex = 1;
			// 
			// txtTicketsPlayer
			// 
			this.txtTicketsPlayer.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTicketsPlayer.Location = new System.Drawing.Point(213, 10);
			this.txtTicketsPlayer.Name = "txtTicketsPlayer";
			this.txtTicketsPlayer.Size = new System.Drawing.Size(141, 27);
			this.txtTicketsPlayer.TabIndex = 5;
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
			this.lblTicketsServerDesc.Location = new System.Drawing.Point(360, 12);
			this.lblTicketsServerDesc.Name = "lblTicketsServerDesc";
			this.lblTicketsServerDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTicketsServerDesc.Size = new System.Drawing.Size(392, 23);
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
			this.tabControl1.Size = new System.Drawing.Size(775, 254);
			this.tabControl1.TabIndex = 0;
			// 
			// btnTicketsListAuthoredGrids
			// 
			this.btnTicketsListAuthoredGrids.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTicketsListAuthoredGrids.Location = new System.Drawing.Point(526, 12);
			this.btnTicketsListAuthoredGrids.Name = "btnTicketsListAuthoredGrids";
			this.btnTicketsListAuthoredGrids.Size = new System.Drawing.Size(166, 36);
			this.btnTicketsListAuthoredGrids.TabIndex = 7;
			this.btnTicketsListAuthoredGrids.Text = "List Created Grids";
			this.btnTicketsListAuthoredGrids.UseVisualStyleBackColor = true;
			this.btnTicketsListAuthoredGrids.Click += new System.EventHandler(this.btnTicketsListAuthoredGrids_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 280);
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
		private System.Windows.Forms.Button btnTicketsClearAdminMode;
		private System.Windows.Forms.Button btnTicketsAdminModeAfter;
		private System.Windows.Forms.Button btnTicketsGiveScripterAccess;
		private System.Windows.Forms.Button btnTicketsListOwnedGrids;
		private System.Windows.Forms.Button btnTicketsListHangarContents;
		private System.Windows.Forms.Button btnTicketsListGridBackups;
		private System.Windows.Forms.Button btnTicketsAdminMode;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtTicketsPlayer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTicketsServerDesc;
		private System.Windows.Forms.ComboBox comboServers;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button btnTicketsListAuthoredGrids;
	}
}

