using System;
using System.Collections.Generic;


namespace cs1
{
	using System.Collections;


	public class Program1
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

	public abstract class Mammal	: Vertebrate
	{
		private readonly Vertebrate vertebrate;

		protected Mammal(Gender gender )   : base (gender)
		{
			this.Gender = gender;
			this.Suma = 1;
		}

		public Gender Gender { get; set; }
	}

	public abstract class Human : Mammal
	{
		public ArrayList Children { set; get; }

		private string name;

		public string Name
		{
			get { return name; }

			set { name = value; }
		}

		public Human(Gender Gender)
			: base(Gender)
		{

		}
	}



}
