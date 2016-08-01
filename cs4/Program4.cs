using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs4
{
	// Late binding
	// Named argument
	// Optional parameter
	
	class Program4
	{
		static void Main( string[] args )
		{
		}
	}

	public enum Gender
	{
		Female,
		Male,
	}

	public abstract class Mammal
	{
		protected Mammal( Gender Gender )
		{
			this.Gender = Gender;
		}

		public string Name { get; set; }

		public int Age { get; set; }

		public Gender Gender { get; set; }

		
	}

	public abstract class Human : Mammal
	{
		public List<Human> Children { set; get; }

		public Human( Gender Gender )
			: base( Gender )
		{
		}
		
	}
}
