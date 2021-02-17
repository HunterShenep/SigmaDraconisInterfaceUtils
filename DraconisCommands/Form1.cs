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

			//Servers
			servers.Add(" ");
			servers.Add("o1");
			servers.Add("o2");
			servers.Add("o3");
			servers.Add("o4");
			servers.Add("o5");
			servers.Add("o6");
			servers.Add("o7");
			servers.Add("o8");
			servers.Add("o9");
			servers.Add("i0");
			servers.Add("i1");
			servers.Add("i2");
			servers.Add("i4");
			servers.Add("1");
			servers.Add("2");
			servers.Add("3");
			servers.Add("4");
			servers.Add("5");
			for(int i = 0; i < servers.Count; i++)
			{
				comboServers.Items.Add(servers[i]);
			}

		}
		private void saveSteam64orUsername(object sender, EventArgs e)
		{

			string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string specificFolder = Path.Combine(folder, "SpaceEngineers");
			Directory.CreateDirectory(specificFolder);


			string filePath = folder + "\\DraconisUtils.cfg";
			try { 
				StreamWriter textOut = new StreamWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write));
				textOut.Write(txtSteam64orUsername.Text.ToString());
				textOut.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Uh oh");
			}
		}

		private void tabPage3_Click(object sender, EventArgs e)
		{

		}
	}
}

