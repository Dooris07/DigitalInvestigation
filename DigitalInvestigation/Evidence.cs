using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Investigation
{
	internal class Evidence
	{
		private int id;
		private string type;
		private string description;
		private int reliability;

		public Evidence(int id, string type, string description, int reliability)
		{
			this.id = id;
			this.type = type;
			this.description = description;
			this.reliability = reliability;
		}

		public int Id { get => id; }
		public string Type { get => type; }
		public string Description { get => description; set => description = value; }
		public int Reliability { get => reliability; set => reliability = value; }

		public override string ToString()
		{
			return $"Bizonyíték {id}:{type}:{description}:{reliability}";
		}
	}
}
