﻿namespace AddressBookSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Object of contact class stores all information of a contact
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Variables to store first name, last name, address, city, state, zip, phone number and email 
        /// Easy to understand with given names
        /// </summary>
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string contactType { get; set; }
        public string addressBookName { get; set; }
        public DateTime dateAdded { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        public Contact()
        {
            this.firstName = "";
            this.lastName = "";
            this.address = "";
            this.city = "";
            this.state = "";
            this.zip = "";
            this.phoneNumber = "";
            this.email = "";
            this.contactType = "";
            this.addressBookName = "";
            this.dateAdded = Convert.ToDateTime("1/1/2022");
        }
    }
}