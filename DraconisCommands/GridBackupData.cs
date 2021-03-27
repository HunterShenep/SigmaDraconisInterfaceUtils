using DraconisCommands.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraconisCommands
{
	public partial class GridBackupData : Form
	{
		public IEnumerable<GridBackup> Grids;
		private string player;
		private string server;

		public GridBackupData(IEnumerable<GridBackup> data, string playerr, string serverr)
		{
			InitializeComponent();
			clean();
			player = playerr;
			server = serverr;


			Grids = data.OrderByDescending(g => g.Date);
		}

		private void clean()
		{
			dvgGridBackups.Refresh();
			List<GridBackup> emptyList = new List<GridBackup>();
			Grids = emptyList;
			dvgGridBackups.DataSource = null;
			dvgGridBackups.Rows.Clear();

		}


		private void copyToClipboard(string text)
		{
			Clipboard.Clear();
			Clipboard.SetText(text);
			lblTopAlert.Text = "COPIED --> " + text;
		}

		private void dvg_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dvgGridBackups.Columns["Copy"].Index)
			{
				int row = e.RowIndex;
				string text = dvgGridBackups.Rows[row].Cells[1].Value.ToString();
				copyToClipboard(server + " gridbackuprestore \"" + player + "\" " + text + " 1");
				//Do something with your button.
			}
		}

		private void GridBackupData_Load(object sender, EventArgs e)
		{

			IEnumerable<GridBackup> newData = Grids;
			newData.OrderByDescending(g => g.Date);

			var source = new BindingSource();
			source.DataSource = newData;
			dvgGridBackups.AutoGenerateColumns = true;
			dvgGridBackups.DataSource = source;

			DataGridViewButtonColumn copyCol = new DataGridViewButtonColumn();
			copyCol.Name = "Copy";
			copyCol.Text = "Copy";
			copyCol.UseColumnTextForButtonValue = true;
			int columnIndex = 3;
			if (dvgGridBackups.Columns["copy_col"] == null)
			{
				dvgGridBackups.Columns.Insert(columnIndex, copyCol);
			}
			dvgGridBackups.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dvgGridBackups.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

		}
	}
}
