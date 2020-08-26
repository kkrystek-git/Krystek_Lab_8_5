using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Compression;
using System.Text;

namespace Krystek_Lab_8_5
{
	class Application_Base
	{
		// Create base application properties.
		public string firstName;
		public string lastName;
		public DateTime dateOfBirth;
		public string address;
		public string city;
		public string state;
		public int zipCode;
		public string phoneNumber;
		public string emailAddress;
		public bool isSubmitted;
		public bool isAccepted;

		// Create constructor for base application.
		public Application_Base (string firstName, string lastName, DateTime dateOfBirth, string address, string city,
							string state, int zipCode, string phoneNumber, string emailAddress)
			{
				this.firstName = firstName;
				this.lastName = lastName;
				this.dateOfBirth = dateOfBirth;
				this.address = address;
				this.city = city;
				this.state = state;
				this.zipCode = zipCode;
				this.phoneNumber = phoneNumber;
				this.emailAddress = emailAddress;
				isSubmitted = false;
				isAccepted = false;
			}

		// Create two methods that will be used by ALL applications.
		public void Submit()
			{
				isSubmitted = true;
				Console.WriteLine(firstName + ", your application has been SUBMITTED for the show.");
			}

		public virtual void Accept()
			{
				isSubmitted = true;
				isAccepted = true;
				Console.WriteLine("Your application has been ACCEPTED for the show.");
			}
	}
}