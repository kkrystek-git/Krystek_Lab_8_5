using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Krystek_Lab_8_5
{
	// Create Dream House Hunter specific application properties.
	class HouseHunter: Application_Base
	{
		public string jobTitle;
		public int currentAnnualIncome;
		public int monthLookingToBuyHouse;
		public int numBedrooms;
		public int numBathrooms;
	
		// Create constructor to collect TV show and base application properties.
		public HouseHunter(string jobTitle, int currentAnnualIncome, int monthLookingToBuyHouse, int numBedrooms, int numBathrooms,
			string firstName, string lastName, DateTime dateOfBirth, string address, string city, string state, int zipCode, string phoneNumber, string emailAddress)
			: base(firstName, lastName,  dateOfBirth,  address,  city, state,  zipCode,  phoneNumber,  emailAddress)
			{
				this.jobTitle = jobTitle;
				this.currentAnnualIncome = currentAnnualIncome;
				this.monthLookingToBuyHouse = monthLookingToBuyHouse;
				this.numBedrooms = numBedrooms;
				this.numBathrooms = numBathrooms;
			}

		// Create method to override accept application text for this tv show.
		public override void Accept()
			{
				isAccepted = true;
				Console.WriteLine("Welcome " + firstName + "! You've been ACCEPTED to be on \"Dream House Hunters\"!");
			}
	}
}
