using System.Collections.Generic;

namespace addressBook
{
    class AddressBook
    {

        Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();
        public void AddContact(Contact contact)
        {
            contacts.Add(contact.Email, contact);
        }

        public Contact GetByEmail(string email)
        {
            return contacts[email];
        }
    }
}