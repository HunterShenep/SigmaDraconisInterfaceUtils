using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraconisCommands.Models
{


	class Servers
	{
		public string serverID { get; set; }
		public string desc { get; set; }

		public Servers(string serverID, string desc)
		{
			this.serverID = serverID;
			this.desc = desc;
		}

		public static List<Servers> getServers()
		{
			List<Servers> theServers = new List<Servers>();
			theServers.Add(new Servers("o1", "Lobby | sendsO1"));
			theServers.Add(new Servers("o2", "Space | sendsO2"));
			theServers.Add(new Servers("o3", "Ares, Okeanos | sendsO3"));
			theServers.Add(new Servers("o4", "Pertam | sendsO4"));
			theServers.Add(new Servers("o5", "Space (Ares, Vrachos, Sigma Draconis) | sendsO5"));
			theServers.Add(new Servers("o6", "Space (Safina) | sendsO6"));
			theServers.Add(new Servers("o7", "Space (Abraxas, Safina) | sendsO7"));
			theServers.Add(new Servers("o8", "Space (Okeanos, Abraxas) | sendsO8"));
			theServers.Add(new Servers("o9", "Space (Pertam, Thanian) | sendsO9"));
			theServers.Add(new Servers("i0", "Nebula Sector | sends10"));
			theServers.Add(new Servers("i1", "Vrachos/Waystations | sends11"));
			theServers.Add(new Servers("i2", "Thanian | sends12"));
			theServers.Add(new Servers("i4", "Outer Belts | sends14"));
			theServers.Add(new Servers("fk", "Main Cluster Globa"));
			theServers.Add(new Servers("D1", "DI Lobby | TDRAC01"));
			theServers.Add(new Servers("D2", "Space / Part of Purgatory | TDRAC02"));
			theServers.Add(new Servers("D3", "East Purgatory | TDRAC03"));
			theServers.Add(new Servers("D4", "West Purgatory | TDRAC04"));
			theServers.Add(new Servers("D5", "Other Planets | TDRAC05"));

			return theServers;
		}

	}


}
