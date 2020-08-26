using System;
using System.Collections.Generic;
using System.Text;

namespace Krystek_Lab_8_5
{
	class AboveDeck : Application_Base
	{
		// Create Above Deck specific application properties.
		public int yearsBoatingExperience;
		public string nationality;

		// Create constructor to collect TV show and base application properties.
		public AboveDeck(int yearsBoatingExperience, string nationality,
		string firstName, string lastName, DateTime dateOfBirth, string address, string city, string state, int zipCode, string phoneNumber, string emailAddress)
			: base(firstName, lastName, dateOfBirth, address, city, state, zipCode, phoneNumber, emailAddress)
		{
			this.yearsBoatingExperience = yearsBoatingExperience;
			this.nationality = nationality;
		}

		// Create method to override accept application text for this tv show.
		public override void Accept()
		{
			isAccepted = true;
			Console.WriteLine("Welcome, " + firstName + "! You've been ACCEPTED to be on \"Above Deck\"!");
		}
	}
}
