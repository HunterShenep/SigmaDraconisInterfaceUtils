
namespace DraconisCommands
{
	partial class GridBackupData
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
			this.dvgGridBackups = new System.Windows.Forms.DataGridView();
			this.lblTopAlert = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dvgGridBackups)).BeginInit();
			this.SuspendLayout();
			// 
			// dvgGridBackups
			// 
			this.dvgGridBackups.AllowUserToOrderColumns = true;
			this.dvgGridBackups.AllowUserToResizeRows = false;
			this.dvgGridBackups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dvgGridBackups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgGridBackups.Location = new System.Drawing.Point(2, 34);
			this.dvgGridBackups.Name = "dvgGridBackups";
			this.dvgGridBackups.Size = new System.Drawing.Size(597, 198);
			this.dvgGridBackups.TabIndex = 1;
			this.dvgGridBackups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_CellClick);
			// 
			// lblTopAlert
			// 
			this.lblTopAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTopAlert.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.lblTopAlert.Location = new System.Drawing.Point(-27, 0);
			this.lblTopAlert.Name = "lblTopAlert";
			this.lblTopAlert.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTopAlert.Size = new System.Drawing.Size(626, 23);
			this.lblTopAlert.TabIndex = 2;
			this.lblTopAlert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// GridBackupData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 235);
			this.Controls.Add(this.lblTopAlert);
			this.Controls.Add(this.dvgGridBackups);
			this.Name = "GridBackupData";
			this.Text = "Draconis Commands | Grid Backup Parse";
			this.Load += new System.EventHandler(this.GridBackupData_Load);
			((System.ComponentModel.ISupportInitialize)(this.dvgGridBackups)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dvgGridBackups;
		private System.Windows.Forms.Label lblTopAlert;
	}
}