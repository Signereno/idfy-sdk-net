using System;

namespace Signicat.Express.IdentificationV2
{
    /// <summary>
    /// Details about the identified user. Only available if session has status `success`.
    /// </summary>
    public class Identity
    {
        /// <summary>
        /// The user's unique ID from the eID provider.
        /// </summary>
        public string ProviderId { get; set; }

        /// <summary>
        /// Full name.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Middle name.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// National identification number.
        /// </summary>
        public string Nin { get; set; }
        
        /// <summary>
        /// Phone number.
        /// </summary>
        public string PhoneNumber { get; set; }
        
        /// <summary>
        /// Email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Information about the organization the user represents.
        /// </summary>
        public Organization Organization { get; set; }
    }
}