using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskTwo
{
    internal class Content
    {
        List<User> contacts = new List<User>();
        //add
        public void AddContacts(string firstName, string lastName, string phoneNumber)
        {
            User newContact = new User(firstName, lastName, phoneNumber);
            contacts.Add(newContact);
            Console.WriteLine($"⦁ Contact for {firstName} {lastName} added successfully!");
        }
        //Editing existing contacts 
        public void EditContacts( string phoneNumber)
        {
            User contact = FindContactByPhone(phoneNumber);
            if (contact != null)
            {
                Console.WriteLine($"Current details: {contact.FirstName} {contact.LastName}, Phone: {contact.PhoneNumber}");
                Console.Write("Enter new first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter new last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter new phone number: "); 
                string newPhone = Console.ReadLine(); //string 

                contact.FirstName = firstName;
                contact.LastName = lastName;
                contact.PhoneNumber = newPhone;
                
                Console.WriteLine("Contact updated successfully.");
            }
            else
            {
                Console.WriteLine("Error: Contact not found.");
            }
        }

        // delete by phone 
        public void DeleteContact(string phoneNumber)
        {
            User contact = FindContactByPhone(phoneNumber);
            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine($"Contact with phone number {phoneNumber} deleted successfully.");
            }
            else
            {
                Console.WriteLine("Error: Contact not found.");
            }
        }
        //⦁	Displaying 
        public void DisplayAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts available.");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    contact.DisplayContact();
                }
            }
        }

        public User FindContactByPhone(string phoneNumber)
        {
            foreach (var contact in contacts)
            {
                if (contact.PhoneNumber == phoneNumber)
                {
                    return contact;
                }
            }
            return null;
        }
    }
}
