using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSys
{
    internal class Program
    {
        internal class Contact
        {
            public string First_Name { get; set; }
            public string Last_Name { get; set; }
            public string Present_Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Email_Id { get; set; }
            public string Phone_Number { get; set; }
            public string Zip { get; set; }
        }
        public static void Main(string[] args)
        {
            List<Contact> Addressbook = new List<Contact>();
            Contact contact = new Contact();
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Add a New Contact:");
            Console.WriteLine("Enter your first_name");
            contact.First_Name = Console.ReadLine();
            Console.WriteLine("Enter your last_name");
            contact.Last_Name = Console.ReadLine();
            Console.WriteLine("Enter your Present_address");
            contact.Present_Address = Console.ReadLine();
            Console.WriteLine("Enter your City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter your State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter your Email_Id");
            contact.Email_Id = Console.ReadLine();
            Console.WriteLine("Enter your Phone_Number");
            contact.Phone_Number = Console.ReadLine();
            Console.WriteLine("Enter your ZipCode");
            contact.Zip = Console.ReadLine();
            Addressbook.Add(contact);
            Console.ReadLine();
        }
    }
}
