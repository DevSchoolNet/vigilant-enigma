namespace cs1
{
	public class Vertebrate
	{
		public Vertebrate(Gender gender)
		{
			Gender = gender;
		}

		/// <summary>Serves as a hash function for a particular type. </summary>
		/// <returns>A hash code for the current <see cref="T:System.Object" />.</returns>
		public override int GetHashCode()
		{
			return Name.GetHashCode()^Age.GetHashCode();
		}

		public string Name { get; set; }

		public int Age { get; set; }

		public Gender Gender { get; set; }

		protected internal int Suma { set; get; }
	
	}
}