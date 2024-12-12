using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Contact c  = new Contact();
            if(textBox_name == null)
            {
                throw new Exception("Name is empty");
            }
            if (textBox_phone == null)
            {
                throw new Exception("Phone number is empty");
            }
        }
    }
}
