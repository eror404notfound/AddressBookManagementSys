using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSys
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
        public override string ToString()
        {
            return "FirstName: " + this.First_Name + " \nLastName: " + this.Last_Name
                                    + " \nPresent Address: " + this.Present_Address + " \nCity: " + this.City + " \nState: "
                                    + this.State + " \nZipcode: " + this.Zip + " \nPhoneNumber: "
                                    + this.Phone_Number + " \nEmail: " + this.Email_Id;
        }


    }
}
