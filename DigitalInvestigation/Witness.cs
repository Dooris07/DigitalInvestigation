using Digital_Investigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalInvestigation
{
	internal class Witness
	{
		private Person person;
		private string description;
		private DateTime date;

		public Witness(Person person, string description, DateTime date)
		{
			this.person = person;
			this.description = description;
			this.date = date;
		}

		public string Description { get => description; set => description = value; }
		public DateTime Date { get => date; set => date = value; }
		internal Person Person { get => person; set => person = value; }

		public override string ToString()
		{
			return $"Tanú adatai:{person}\nVallomás ideje és leírása:\n{date}\n{description}";
		}
	}
}
