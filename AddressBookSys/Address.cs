using AddressBookSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_Batch222
{
    internal class Address
    {
        List<Contact> contacts = new List<Contact>();
        Contact contact;
        public void Entry()
        {
            contact = new Contact();
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
            Console.WriteLine("Enter your ZipCode");
            contact.Zip = Console.ReadLine();
            Console.WriteLine("Enter your Phone_Number");
            contact.Phone_Number = Console.ReadLine();
            Console.WriteLine("Enter your Email_Id");
            contact.Email_Id = Console.ReadLine();
            contacts.Add(contact);

            foreach (var Contact in contacts)
            {
                Console.WriteLine("---------Contact Details--------");
                Console.WriteLine(Contact.ToString());
            }
        }
    }
}