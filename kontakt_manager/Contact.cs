using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontakt_manager
{
    public class Contact
    {
        string name;
        string mail;
        string phone;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }

        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }

        }
        
    }
}

