using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Investigation
{
	internal class Person
	{
		private string name;
		private int age;
		private string description;

		public Person(string name, int age, string description)
		{
			this.name = name;
			this.age = age;
			this.description = description;
		}

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
		public string Description { get => description; set => description = value; }

		public override string ToString()
		{
			return $"Neve: {this.Name}, Kora:{this.age}, Leírás:\n{this.description}";
		}
	}
}
