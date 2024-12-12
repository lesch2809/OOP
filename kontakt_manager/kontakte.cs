using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kontakt_manager
{
    public partial class kontakte : Form
    {
        ContactList contactList = new ContactList();
        public kontakte()
        {
            InitializeComponent();

            dataGridView1.DataSource = contactList.Contacts;
        }
        private void delet_button_Click(object sender, EventArgs e)
        {
            ContactList contactList = new ContactList();
        }
        private void create_button_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            if (textBox_name == null)
            {
                throw new Exception("Name is empty");
            }
            if (textBox_phone == null)
            {
                throw new Exception("Phone number is empty");
            }
            c.Mail = textBox_mail.Text;
            c.Name = textBox_name.Text;
            c.Phone = textBox_phone.Text;
            contactList.addToList(c);
            textBox_mail.Text = "";
            textBox_name.Text = "";
            textBox_phone.Text = "";
        }


    }
}
