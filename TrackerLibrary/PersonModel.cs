﻿namespace TrackerLibrary
{
    /// <summary>
    /// Represents a single person.
    /// </summary>
    internal class PersonModel
    {
        public PersonModel(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// The first name of this person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of this person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The e-mail address to contact this person with.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The phone number to text to this person.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
