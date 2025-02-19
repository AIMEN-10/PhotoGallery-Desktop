using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
	public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Path { get; set; }  // Image path
		public string Gender { get; set; } // "M" or "F"

		public Person(int id, string name, string path, string gender)
		{
			Id = id;
			Name = name;
			Path = path;
			Gender = gender;
		}
	}

}
