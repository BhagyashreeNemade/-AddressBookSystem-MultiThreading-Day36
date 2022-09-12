using AddressBookSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AddressBookSystemMSTest
{
    [TestClass]
    public class TestDBOperations
    {
        public List<Contact> AddingDataToList()
        {
            List<Contact> contactDetails = new List<Contact>();

            contactDetails.Add(new Contact() { firstName = "A1", lastName = "B1", address = "KZH", city = "JNA", state = "HAR", zip = "120101", phoneNumber = "NA", email = "bn.a@g.com", contactType = "p",addressBookName = "q", dateAdded = Convert.ToDateTime("1-1-2022") });
            contactDetails.Add(new Contact() { firstName = "A2", lastName = "B2", address = "KZH", city = "JNA", state = "HAR", zip = "120101", phoneNumber = "NA", email = "bn.a@g.com", contactType = "p", addressBookName = "q", dateAdded = Convert.ToDateTime("1-1-2022") });
            contactDetails.Add(new Contact() { firstName = "A3", lastName = "B3", address = "KZH", city = "JNA", state = "HAR", zip = "120101", phoneNumber = "NA", email = "bn.a@g.com", contactType = "p", addressBookName = "q", dateAdded = Convert.ToDateTime("1-1-2022") });
            contactDetails.Add(new Contact() { firstName = "A4", lastName = "B4", address = "KZH", city = "JNA", state = "HAR", zip = "120101", phoneNumber = "NA", email = "bn.a@g.com", contactType = "p", addressBookName = "q", dateAdded = Convert.ToDateTime("1-1-2022") });
            contactDetails.Add(new Contact() { firstName = "A5", lastName = "B5", address = "KZH", city = "JNA", state = "HAR", zip = "120101", phoneNumber = "NA", email = "bn.a@g.com", contactType = "p", addressBookName = "q", dateAdded = Convert.ToDateTime("1-1-2022") });
            contactDetails.Add(new Contact() { firstName = "A6", lastName = "B6", address = "KZH", city = "JNA", state = "HAR", zip = "120101", phoneNumber = "NA", email = "bn.a@g.com", contactType = "p", addressBookName = "q", dateAdded = Convert.ToDateTime("1-1-2022") });
            contactDetails.Add(new Contact() { firstName = "A7", lastName = "B7", address = "KZH", city = "JNA", state = "HAR", zip = "120101", phoneNumber = "NA", email = "bn.a@g.com", contactType = "p", addressBookName = "q", dateAdded = Convert.ToDateTime("1-1-2022") });
            contactDetails.Add(new Contact() { firstName = "A8", lastName = "B8", address = "KZH", city = "JNA", state = "HAR", zip = "120101", phoneNumber = "NA", email = "bn.a@g.com", contactType = "p", addressBookName = "q", dateAdded = Convert.ToDateTime("1-1-2022") });
            return contactDetails;
        }
        [TestMethod]
        public void CompareTimesOfAddingWithOrWithoutThreading()
        {
            List<Contact> contactList = AddingDataToList();
            DBOperations dBOperations = new DBOperations();
            DateTime t1 = DateTime.Now;
            dBOperations.AddContactListToDBWithoutThread(contactList);
            DateTime t2 = DateTime.Now;
            Console.WriteLine("Time taken while adding to list without threading: " + (t2 - t1));

            DateTime t3 = DateTime.Now;
            dBOperations.AddContactListToDBWithThread(contactList);
            DateTime t4 = DateTime.Now;
            Console.WriteLine("Time taken while adding to list with threading: " + (t4 - t3));
        }
    }
}
