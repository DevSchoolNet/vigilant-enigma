using System;
using System.Collections.Generic;

using System.Collections;

namespace cs2
{
	// Generics
	// Anonymous method
	// Nullable type
	// Partial class
	public partial class Program2
	{
		private static int? missingInt;
		static void Main( string[] args )
		{
			
			if (missingInt.HasValue)
				Console.WriteLine(missingInt.Value);
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

		public Human(Gender Gender)
			: base(Gender)
		{
		}
	}
}
