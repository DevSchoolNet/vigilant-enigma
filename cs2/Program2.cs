using System;
using System.Collections.Generic;

using System.Collections;

namespace cs2
{
	// Generics [d]
	// Anonymous method [d]
	// Nullable type [d]
	// Partial class [d]
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

	public class Transaction
	{

		public int Id { get; set; }

		public double Amount { get; set; }

		public string PayerAccount { get; set; }

		public string BeneficiaryAccount { get; set; }

	}

	public class CancelTransaction : Transaction
	{
		public bool CanBeCanceled { get; set; }

		public string CancelReason { get; set; }
	}

}
