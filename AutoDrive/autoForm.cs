using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDrive
{
    public partial class autoForm : Form
    {
        Auto ak_auto; 
        

        public autoForm()
        {
            InitializeComponent();
            comboBox1.Items.Add(new Auto("Porsche", 250));
            comboBox1.Items.Add(new Auto("Opel", 90));
            comboBox1.Items.Add(new Auto("Ferrari", 370));
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            ak_auto.Auftanken();

             tankBar.Value = ak_auto.Tank;      
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (ak_auto.AutoAn == true)
            {
                ak_auto.SchaltetMotorAus();
                MessageBox.Show("Auto ist an2");
            }
            else
            {
                ak_auto.StarteMotor();
                MessageBox.Show("Auto ist an");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ak_auto = (Auto)comboBox1.SelectedItem;
            textBoxSpeed.Text = ak_auto.Geschwindigkeit.ToString();
            tankBar.Value = ak_auto.Tank;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ak_auto.GibGas();
            textBoxSpeed.Text = ak_auto.Geschwindigkeit.ToString();
            tankBar.Value = ak_auto.Tank;
            textBox2.Text = ak_auto.Gang.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ak_auto.Bremsen();
            textBoxSpeed.Text = ak_auto.Geschwindigkeit.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hup, Hup!");
        }
    }
}
