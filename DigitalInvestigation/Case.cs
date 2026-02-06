using Digital_Investigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DigitalInvestigation
{
	internal class Case
	{
		private int id;
		private string title;
		private string description;
		private string status;
		private List<Evidence> evidence;
		private List<Person> people;


		public Case(int id, string title, string description, string status, List<Case> evidence, List<Case> people)
		{
			this.id = id;
			this.title = title;
			this.description = description;
			this.status = status;
			this.evidence = evidence;
			this.people = people;
		}

		public int Id { get => id; }
		public string Title { get => title; set => title = value; }
		public string Description { get => description; set => description = value; }
		public string Status { get => status; set => status = value; }
		internal List<Case> Evidence { get => evidence; set => evidence = value; }
		internal List<Case> People { get => people; set => people = value; }

		public void CaseStatusManager()
		{
			Console.WriteLine("Mire szeretné megváltoztatni az ügy állapotát?");
			string valtoztatas = Console.ReadLine();
			if (valtoztatas == status)
			{
				Console.WriteLine($"Az ügy állapota eddig is {valtoztatas} volt.");
			}
			else
			{
				this.status = valtoztatas;
			}

		}
	}
}
