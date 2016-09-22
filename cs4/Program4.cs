using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs4
{
	// Late binding
	// Named argument [d]
	// Optional parameter [d]
	
	class Program4
	{
		static void Main( string[] args )
		{
			DoSomething("Costel", 32, 4500);
			DoSomething( Salary: 3500, Age: 32, Name: "Costel" );
		}

		
		public static void DoSomething(string Name, int Age, decimal Salary = 3500  )
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
