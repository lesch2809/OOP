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
            dgvContacts.DataSource = contactList.Contacts;
        }

        
    }
}
