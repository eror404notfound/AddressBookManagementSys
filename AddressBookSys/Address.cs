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
            contact.first_Name = Console.ReadLine();
            Console.WriteLine("Enter your last_name");
            contact.last_Name = Console.ReadLine();
            Console.WriteLine("Enter your Present_address");
            contact.present_Address = Console.ReadLine();
            Console.WriteLine("Enter your City");
            contact.city = Console.ReadLine();
            Console.WriteLine("Enter your State");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter your ZipCode");
            contact.zip = Console.ReadLine();
            Console.WriteLine("Enter your Phone_Number");
            contact.phone_Number = Console.ReadLine();
            Console.WriteLine("Enter your Email_Id");
            contact.email_Id = Console.ReadLine();
            contacts.Add(contact);

        }
        public void Display()
        {
            foreach (var Contact in contacts)
            {
                Console.WriteLine("---------Contact Details--------");
                Console.WriteLine("Contact number:{0}", contacts.IndexOf(Contact) + 1);
                Console.WriteLine(Contact.ToString());
            }
        }
        public void Edit()
        {
            Console.WriteLine("Enter the name of contact do you want to edit : ");
            string name = Convert.ToString(Console.ReadLine());
            foreach (var data in contacts)
            {
                if (data.first_Name == name)
                {
                    Console.WriteLine("choose the option to change the data \n1)firstName\n2)lastName\n3)Present_Address\n4)City\n5)State\n6)Zip\n7)PhoneNumber\n8)Email_Id");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please enter the first name : ");
                            string firstName = Convert.ToString(Console.ReadLine());
                            data.first_Name = firstName;
                            break;
                        case 2:
                            Console.WriteLine("Please enter the last name : ");
                            string lastName = Convert.ToString(Console.ReadLine());
                            data.last_Name = lastName;
                            break;
                        case 3:
                            Console.WriteLine("Please enter the Address : ");
                            string address = Convert.ToString(Console.ReadLine());
                            data.present_Address = address;
                            break;
                        case 4:
                            Console.WriteLine("Please enter the city : ");
                            string City = Convert.ToString(Console.ReadLine());
                            data.city = City;
                            break;
                        case 5:
                            Console.WriteLine("Please enter the city : ");
                            string State = Convert.ToString(Console.ReadLine());
                            data.state = State;
                            break;
                        case 6:
                            Console.WriteLine("Please enter the zip Code : ");
                            string ZipCode = Convert.ToString(Console.ReadLine());
                            data.zip = ZipCode;
                            break;
                        case 7:
                            Console.WriteLine("Please enter the Phone Number : ");
                            string PhoneNumber = Convert.ToString(Console.ReadLine());
                            data.phone_Number = PhoneNumber;
                            break;
                        case 8:
                            Console.WriteLine("Please enter the email : ");
                            string Email = Convert.ToString(Console.ReadLine());
                            data.email_Id = Email;
                            break;
                        default:
                            Console.WriteLine("please choose from above options :");
                            break;
                    }
                    Console.WriteLine("\nAfter Editing Contact Details:");
                    Console.WriteLine(contact.ToString());
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Contact not found{0}", name);
                }
            }
        }
        public void AddMultipleContact()
        {
            Console.WriteLine("Enter Number of Contacts to be Added:");
            int input = Convert.ToInt32(Console.ReadLine());
            while (input > 0)
            {
                Entry();
                input--;
            }
            Display();
        }
    }
}
