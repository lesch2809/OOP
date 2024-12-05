using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawTree
{
    public partial class DrawTree : Form
    {
        public DrawTree()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            draw Tree = new draw();
            Tree.stammhohe = Convert.ToInt32(textBox2.Text);
            Tree.stammbreite = Convert.ToInt32(textBox4.Text);
            Tree.kronenhohe = Convert.ToInt32(textBox3.Text);
            textBox1.Text = Tree.krone(Tree.stammhohe, Tree.stammbreite, Tree.kronenhohe);
        }
    }
}
