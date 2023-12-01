using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kellogg_ERQueue
{
	internal class Patient
	{
		public string LastName { get; }
		public string FirstName { get; }
		public DateOnly DOB { get; }
		public int Priority { get; }

		public Patient(string lastname, string firstname, string dob, int priority)
		{
			LastName = lastname;
			FirstName = firstname;
			DOB = DateOnly.Parse(dob);
			Priority = priority;

			int age = 2023 - DOB.Year;
			if (age < 21 || age >= 65)
				priority = 1;
			
		}

		public override string ToString()
		{
			return $"{LastName}, {FirstName}, {DOB}, {Priority}";		
		}
	}
}
