namespace AddressBookSystem
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using System.Threading.Tasks;

    public class DBOperations
    {
        public void AddContact(Contact contact)
        {
            SqlConnection sqlConnection = DBConnection.GetConnection();
            try
            {
                using (sqlConnection)
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("dbo.spAddNewContact", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@first_name", contact.firstName);
                    sqlCommand.Parameters.AddWithValue("@last_name", contact.lastName);
                    sqlCommand.Parameters.AddWithValue("@address", contact.address);
                    sqlCommand.Parameters.AddWithValue("@city", contact.city);
                    sqlCommand.Parameters.AddWithValue("@state", contact.state);
                    sqlCommand.Parameters.AddWithValue("@zip", contact.zip);
                    sqlCommand.Parameters.AddWithValue("@phone_number", contact.phoneNumber);
                    sqlCommand.Parameters.AddWithValue("@email", contact.email);
                    sqlCommand.Parameters.AddWithValue("@contact_type", contact.contactType);
                    sqlCommand.Parameters.AddWithValue("@address_book_name", contact.addressBookName);
                    sqlCommand.Parameters.AddWithValue("@date_added", contact.dateAdded);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public void AddContactListToDBWithoutThread(List<Contact> contactList)
        {
            contactList.ForEach(contact =>
            {
                Console.WriteLine("Contact being added" + contact.firstName);
                this.AddContact(contact);
                Console.WriteLine("Contact added: " + contact.firstName);
            });
        }

        public void AddContactListToDBWithThread(List<Contact> contactList)
        {
            contactList.ForEach(contact =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Contact Being added" + contact.firstName);
                    this.AddContact(contact);
                    Console.WriteLine("Contact added: " + contact.firstName);
                });
                thread.Start();
            });
        }

    }
}