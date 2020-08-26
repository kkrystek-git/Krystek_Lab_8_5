using System;

namespace Krystek_Lab_8_5
{
	class Program
	{
		// =========================================================================
		// Name:	Keith Krystek
		// Date:	08.26.2020
		// Class: SD1104-A - Full Stack C# Development - Sona Patel - 7 / 11 / 2020
		//
		// Assignment: Lab 8_5
		// =========================================================================

		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");


			// Submit Application for HouseHunter TV Show
			HouseHunter omar = new HouseHunter("Full Stack Web Developer", 100000, 6, 3, 2, "Omar", "Smith", new DateTime(1975, 2, 4),
				"111 Bravo Way", "Los Angeles", "CA", 90001, "888-233-1234", "omar.smith@hotmail.com");
			omar.Submit();

			// Submit Application for Paradise Island TV Show
			ParadiseIsland patti = new ParadiseIsland("Female", "Carl", 2, "Patti", "Johnson", new DateTime(1994, 5, 4), "211 Love Rd",
				"Los Angeles", "CA", 90001, "988-444-1234", "patti.johnson@gmail.com");
			patti.Submit();

			// Submit Application for Above Deck TV Show.
			AboveDeck captian = new AboveDeck( 20, "American", "Captian", "Lee", new DateTime(1964, 7, 12), "311 Bravo Way", "Los Angeles",
				"CA", 90001, "711-333-1234", "captian@gmail.com");
			captian.Submit();


			// Check status of variables for applications.
			Console.WriteLine(" ");
			Console.WriteLine(omar.firstName + " - Submitted=" + omar.isSubmitted + " - Accepted=" + omar.isAccepted);
			Console.WriteLine(patti.firstName + " - Submitted=" + patti.isSubmitted + " - Accepted=" + patti.isAccepted);
			Console.WriteLine(captian.firstName + " - Submitted=" + captian.isSubmitted + " - Accepted=" + captian.isAccepted);

			// Accept applications.
		    Console.WriteLine(" ");
			omar.Accept();
			patti.Accept();
			captian.Accept();

			// Check status of variables for applications.
			Console.WriteLine(" ");
			Console.WriteLine(omar.firstName + " - Submitted=" + omar.isSubmitted + " - Accepted=" + omar.isAccepted);
			Console.WriteLine(patti.firstName + " - Submitted=" + patti.isSubmitted + " - Accepted=" + patti.isAccepted);
			Console.WriteLine(captian.firstName + " - Submitted=" + captian.isSubmitted + " - Accepted=" + captian.isAccepted);

		}
	}
}
