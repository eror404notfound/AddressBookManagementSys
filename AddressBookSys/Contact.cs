using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSys
{
    internal class Contact
    {
        public string first_Name { get; set; }
        public string last_Name { get; set; }
        public string present_Address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string email_Id { get; set; }
        public string phone_Number { get; set; }
        public string zip { get; set; }
        public bool Index { get; internal set; }
        public int Id { get; internal set; }
        public override string ToString()
        {
            return "FirstName: " + this.first_Name + " \nLastName: " + this.last_Name + " \nPresent Address: " + this.present_Address + " \nCity: " + this.city + " \nState: " + this.state + " \nZipcode: " + this.zip + " \nPhoneNumber: " + this.phone_Number + " \nEmail: " + this.email_Id;
        }
    }
}

 

        
        
    


        


    

