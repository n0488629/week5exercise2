using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5exercise2
{
    internal class Program
    {
        static Dictionary<string, string> contacts = new Dictionary<string, string>(); // static dictionary
        static void Main(string[] args)
        {
            int userinput = 0;

            Console.WriteLine("Welcome to Contact Management Application"); // program title 

            while (true) // loop forever 
            {
                Console.WriteLine("1. Add Contact\n" +
                    "2. Remove Contact\n" +
                    "3. Search Contact\n" +
                    "4. Display All Contacts\n" +
                    "5. Exit\n");
                Console.Write("Enter your choice ");
                userinput = Convert.ToInt32(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        RemoveContact();
                        break;
                    case 3:
                        SearchContact();
                        break;
                    case 4:
                        DisplayContacts();
                        break;
                    case 5:
                        return;
                    default:
                        break; ;
                }
            }
        }
        static void AddContact() // method to add a contact to dictionary contacts
        {
            Console.WriteLine("Enter Contact Name: "); // prompt user for contact information/fields
            string name = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            string number = Console.ReadLine();
            
            if (!contacts.ContainsKey(name)) // if the contacts dictionary does not contain the name key
            {
                contacts.Add(name, number); // add to the dictionary
                Console.WriteLine("Contact added successfully");
            }
            else // if the name is already taken
            {
                Console.WriteLine("This name is already in the dictionary");
            }

            
        }
        static void RemoveContact() // method to remove a contact
        {
            Console.WriteLine("Enter the name of the contact you want removed");
            string name = Console.ReadLine();

            if (contacts.ContainsKey(name))
            {
                contacts.Remove(name);
                Console.WriteLine(name + " was successfully removed!");
            }
            else
            {
                Console.WriteLine(name + " was not in the contacts list");
            }
        }
        static void SearchContact()
        {
            Console.WriteLine("Enter the name of the contact you want to search for");
            string username = Console.ReadLine();
            int count = 0; // used if there is no contact with the entered name
            foreach (KeyValuePair<string, string> pair in contacts)
            {
                if (pair.Key == username) 
                {
                    Console.WriteLine("Contact name: " + pair.Key + " Phone number: " + pair.Value);
                    count++;
                }
            }

            if (count == 0) { Console.WriteLine("There is no contact with the name of " + username); }
        }
        static void DisplayContacts() 
        {
            Console.WriteLine("List of Contacts: ");
            foreach (KeyValuePair<string, string> pair in contacts) 
            { 
                Console.WriteLine("Contact name: " + pair.Key + " Phone number: " + pair.Value); 
            }
        }
    }
}
