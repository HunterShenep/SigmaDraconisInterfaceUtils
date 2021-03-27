﻿using DraconisCommands.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraconisCommands
{
	public partial class Form1 : Form
	{
		public static string Steam64ou;
		public static List<string> servers = new List<string>();
		public List<GridBackup> Grids = new List<GridBackup>();
		public IEnumerable<GridBackup> IEGrids;


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string specificFolder = Path.Combine(folder, "SpaceEngineers");
			Directory.CreateDirectory(specificFolder);
			string filePath = folder + "\\DraconisUtils.cfg";

			try
			{
				StreamReader textIn = new StreamReader(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read));
				while(textIn.Peek() != -1)
				{
					//Console.WriteLine();
					Steam64ou = textIn.ReadLine();
					txtSteam64orUsername.Text = Steam64ou;
					Console.WriteLine(Steam64ou);
					
				}
				textIn.Close();

				if(Steam64ou == null)
				{
					Steam64ou = "";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Uh oh");
			}

			foreach(Servers s in Servers.getServers())
			{
				comboServers.Items.Add(s.serverID);
			}

			
		}


		//######################### NONE Windows Button/Item related methods #########################
		//######################### NONE Windows Button/Item related methods #########################
		//######################### NONE Windows Button/Item related methods #########################

		//Self explanatory COPY TO CLIPBOARD
		private void copyToClipboard(string text)
		{
			Clipboard.Clear();
			Clipboard.SetText(text);
			//DateTime now = DateTime.Now;
			//String time = now.Hour.ToString() + ":" + now.Minute.ToString();
			lblTopAlert.Text = "COPIED --> " + text;
		}

		private void alertMessage(string text)
		{
			lblTopAlert.Text = text;
		}

		private string getPlayer()
		{
			try
			{
				if (txtTicketsPlayer.Text == null)
				{
					return "\"\"";
				}
				else
				{
					return txtTicketsPlayer.Text.ToString();
				}
			}
			catch (NullReferenceException ex)
			{
				return "";
			}
		}
		private string getSelectedServer()
		{

			try
			{
				if (comboServers.SelectedItem == null)
				{
					return "?";
				}
				else
				{
					return comboServers.SelectedItem.ToString();
				}
			}
			catch (NullReferenceException ex)
			{
				return "";
			}
		}

		private void saveSteam64orUsername_click(object sender, EventArgs e)
		{

			string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string specificFolder = Path.Combine(folder, "SpaceEngineers");
			Directory.CreateDirectory(specificFolder);


			string filePath = folder + "\\DraconisUtils.cfg";
			try { 
				StreamWriter textOut = new StreamWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write));
				textOut.Write(txtSteam64orUsername.Text.ToString());
				textOut.Close();
				alertMessage("Username or Steam64 saved");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Uh oh");
			}
		}


		//Update the message to the right of server selected
		private void updateTicketsServerDesc(object sender, EventArgs e)
		{
			List<Servers> theServers = new List<Servers>();
			theServers = Servers.getServers();

			lblTicketsServerDesc.Text = theServers[comboServers.SelectedIndex].desc;
		}



		//######################### BUTTON METHODS #########################@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
		//######################### BUTTON METHODS #########################@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
		//######################### BUTTON METHODS #########################@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

		//Set yourself to admin mode BUTTON 
		private void btnTicketsAdminMode_click(object sender, EventArgs e)
		{
			copyToClipboard(getSelectedServer() + " admin setrank \"" + Steam64ou + "\" 4");
		}

		//Set yourself back to scriptor
		private void btnTicketsClearAdminMode_Click(object sender, EventArgs e)
		{
			copyToClipboard(getSelectedServer() + " admin setrank \"" + Steam64ou + "\" 1");
			
		}




		private void btnTicketsAdminModeAfter_Click(object sender, EventArgs e)
		{
			copyToClipboard("fk" + " admin clearadminsettings \"" + Steam64ou + "\"");
		}

		private void btnTicketsListGridBackups_Click(object sender, EventArgs e)
		{
			copyToClipboard(getSelectedServer() + " gridbackup list \"" + getPlayer() + "\"");
		}

		private void btnTicketsListHangarContents_Click(object sender, EventArgs e)
		{
			if (getSelectedServer().Equals("fk")){

				copyToClipboard("o5 hm list \"" + getPlayer() + "\"");
				MessageBox.Show("Server: fk is not necessary for this command. Copied o5 instead. (Hangars are synced anyways)", "Uh oh");
			}
			else
			{
				copyToClipboard(getSelectedServer() + " hmlist \"" + getPlayer() + "\"");
			}
		}

		private void btnTicketsListOwnedGrids_Click(object sender, EventArgs e)
		{
			copyToClipboard(getSelectedServer() + " listgridsowner \"" + getPlayer() + "\"");
		}

		private void btnTicketsListAuthoredGrids_Click(object sender, EventArgs e)
		{
			copyToClipboard(getSelectedServer() + " listgridsauthor \"" + getPlayer() + "\"");
		}

		private void btnTicketsGiveScripterAccess_Click(object sender, EventArgs e)
		{
			copyToClipboard(getSelectedServer() + " admin setrank \"" + getPlayer() + "\" 1");
		}


		private void xelaButton_Click(object sender, EventArgs e)
		{
			Button pressed = (Button)sender;
			if (pressed.Name.Equals(btnXelaScripter.Name))
			{
				copyToClipboard("/t scripter");
			}
			else if (pressed.Name.Equals(btnXela64.Name))
			{
				copyToClipboard("/t sid64");
			}
			else if (pressed.Name.Equals(btnXelaName.Name))
			{
				copyToClipboard("/t name");
			}
			else if (pressed.Name.Equals(btnXelaSupply.Name))
			{
				copyToClipboard("/t supply");
			}
			else if (pressed.Name.Equals(btnXelaLoadCrash.Name))
			{
				copyToClipboard("/t loadcrash");
			}
			else if (pressed.Name.Equals(btnXelaConnTrouble.Name))
			{
				copyToClipboard("/t conntrouble");
			}
			else if (pressed.Name.Equals(btnXelaFixship.Name))
			{
				copyToClipboard("/t fixship");
			}
			else if (pressed.Name.Equals(btnXelaSdnn.Name))
			{
				copyToClipboard("/t sdnn");
			}
			else if (pressed.Name.Equals(btnXelaClustering.Name))
			{
				copyToClipboard("/t clustering");
			}
		}

		private void btnGridBackupParse_Click(object sender, EventArgs e)
		{
			string pastedText = txtGridBackupPaste.Text;
			string[] lines = pastedText.Split(new[] { "\r\n", "\r", "\n"}, StringSplitOptions.None);
			lblBackupStatus.Text = lines.Count().ToString();



			foreach (string s in lines)
			{
				//Retrieve gridname
				int firstSpace = 0;
				firstSpace = s.IndexOf(" ", 0);
				int firstUnderscore = 0;
				firstUnderscore = s.IndexOf("_");
				string gridName = s.Substring((firstSpace+1), (firstUnderscore-(firstSpace+1)));

				//Retrieve GridID
				int dash = s.IndexOf("-", firstUnderscore);
				string tempTemp = s.Substring(0, firstUnderscore);
				int lengthBeforeUnderscore = tempTemp.Length;
				string GridIDstring = s.Substring((firstUnderscore + 1), (dash-(firstUnderscore)-2));

				//Retrieve DateTime
				string dateTime = s.Substring((dash +2), ((s.Length - dash)-2));
				DateTime theDate = DateTime.ParseExact(dateTime, "yyyy-MM-dd HH:mm:ss", null);

				GridBackup grid = new GridBackup()
				{
					GridName = gridName,
					GridID = long.Parse(GridIDstring),
					Date = theDate
				};
				Grids.Add(grid);
			}

			IEGrids = Grids
				.OrderBy(g => g.Date);

			foreach(GridBackup g in IEGrids)
			{
				txtTest.Text += g.GridName + " " + g.GridID + " >>>>> " + g.Date.ToString();
				txtTest.AppendText(Environment.NewLine);
			}

		}

		private void txtGridBackupPaste_TextChanged(object sender, EventArgs e)
		{

		}
	}
}

