using DraconisCommands.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

		private void alertMessage(string msg)
		{
			DateTime now = DateTime.Now;
			String time = now.Hour.ToString() + ":" + now.Minute.ToString();
			lblTopAlert.Text = time + " | " + msg;
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


		private void btnTicketsAdminMode_click(object sender, EventArgs e)
		{
			alertMessage(comboServers.SelectedItem.ToString() + " admin setrank \"" + Steam64ou + "\" 4 -> Copied");
		}

		private void updateTicketsServerDesc(object sender, EventArgs e)
		{
			List<Servers> theServers = new List<Servers>();
			theServers = Servers.getServers();

			lblTicketsServerDesc.Text = theServers[comboServers.SelectedIndex].desc;
		}
	}
}

