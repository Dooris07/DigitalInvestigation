using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalInvestigation
{
	internal class Users
	{
		private string name;
		private int id;
		private string position;

		public Users(string name, int id, string position)
		{
			this.name = name;
			this.id = id;
			this.position = position;
		}

		public string Name { get => name; set => name = value; }
		public int Id { get => id; }
		public string Position { get => position; set => position = value; }
	}
}
