using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs3
{
	// Lambda expressions [d]
	// Extension method [d]
	// Expression tree
	// Anonymous type [d]
	// LINQ
	// Implicit type (var) [d]
	// Auto properties [d]

	class Program3
	{
		static void Main( string[] args )
		{
			var d = "defgh";
			var chars = d.Chars();
			foreach (var c in chars)
			{
				Console.WriteLine("char = {0}, {1}", c, 1);
			}
			Console.ReadLine();
		}
		   

	}

	public static class StringExtensions
	{
		public static char[] Chars(this string Source)
		{
			return Source.ToCharArray();
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
