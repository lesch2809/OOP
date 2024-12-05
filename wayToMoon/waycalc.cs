using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wayToMoon
{
    public partial class waycalc : Form
    {
        public waycalc()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            Mondreise m = new Mondreise();
                m.speedKmh = (Convert.ToDouble(km_h.Text));
            if (in_days.Checked == true)
            {
                m.resualt = m.GetTravelDurationDays(m.speedKmh);
            }
            if (in_h.Checked == true)
            {
                m.resualt = m.GetTravelDurationHours(m.speedKmh);
            }
            textBox1.Text = m.resualt.ToString();
        }
    }
}
