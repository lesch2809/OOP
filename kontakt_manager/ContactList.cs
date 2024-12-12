using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kontakt_manager
{
    public class ContactList
    {

       BindingList<Contact> Contacts = new BindingList<Contact>();
        
        

        public void Clear()
        {

        }
        public void ExoportCsv(string filePath)
        {

        }

        public void ImportCsv(string filePath)
        {

        }
        public void addToList(Contact c)
        {
            Contacts.Add(c);

        }
    }
}
