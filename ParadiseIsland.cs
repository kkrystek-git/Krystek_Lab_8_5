using System;
using System.Collections.Generic;
using System.Text;

namespace Krystek_Lab_8_5
{
	class ParadiseIsland : Application_Base
	{
		// Create Paradise Island specific application properties.
		public string gender;
		public string nameOfSigOther;
		public int yearsDating;

		// Create constructor to collect TV show and base application properties.
		public ParadiseIsland(string gender, string nameOfSigOther, int yearsDating,
			string firstName, string lastName, DateTime dateOfBirth, string address, string city, string state, int zipCode, string phoneNumber, string emailAddress)
			: base(firstName, lastName, dateOfBirth, address, city, state, zipCode, phoneNumber, emailAddress)
			{
				this.gender = gender;
				this.nameOfSigOther = nameOfSigOther;
				this.yearsDating = yearsDating;
			}

		// Create method to override accept application text for this tv show.
		public override void Accept()
			{
				isAccepted = true;
				Console.WriteLine("Welcome " + firstName + "! You've been ACCEPTED to be on \"Paradise Island\"!");
			}
	}
}
