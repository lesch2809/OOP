using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Rect
{
    public partial class Rect : Form
    {
        public Rect()
        {
            InitializeComponent();
        }

        
        public void button1_Click(object sender, EventArgs e)
        {
            Rechteck r = new Rechteck();
            r.Height = Convert.ToDouble(lenght.Text);
            r.Lentgh = Convert.ToDouble(heigth.Text);
            ausgabe.Text = Convert.ToString(r.GetArea(r.height, r.lenght));
        }
    }
}
