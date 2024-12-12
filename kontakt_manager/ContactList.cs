using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kontakt_manager
{
    public class ContactList
    {

        BindingList<Contact> contacts = new BindingList<Contact>();
        public BindingList<Contact> Contacts
        {
            get { return contacts; }
        }


        public void Clear()
        {

        }
        public void ExoportCsv(string filePath)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filePath + ".csv");
                foreach (Contact c in contacts)
                {
                    sw.WriteLine(c.Name + ";" + c.Mail + ";" + c.Phone);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                throw new Exception("fillepath is wrong.", e);
            }
        }

        public void ImportCsv(string filePath)
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader(filePath);
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] parts = line.Split(';');
                    Contact co = new Contact();
                    co.Name = parts[0];
                    co.Mail = parts[1];
                    co.Phone = parts[2];
                    contacts.Add(co);
                    line = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                throw new Exception("fillepath is wrong.", e);
            }
        }
        public void addToList(Contact c)
        {
            contacts.Add(c);
        }
        public void remove()
        {
            contacts.Clear();
        }
    }
}
