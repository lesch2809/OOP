using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dice
{
    public partial class dice : Form
    {
        public dice()
        {
            InitializeComponent();
            
        }
        Wuerfel w = new Wuerfel();
        private void button1_Click(object sender, EventArgs e)
        {
            
            num.Text = Convert.ToString(w.Werfen());
            numold.Text = Convert.ToString(w.LetzterWurf);
            
        }
    }
}
