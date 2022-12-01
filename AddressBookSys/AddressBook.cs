using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_Batch222
{
    internal class Addressbook
    {
        public static void Main(string[] args)
        {
            Address address = new Address();
            address.Entry();
            address.Edit();
        }
    }
}


