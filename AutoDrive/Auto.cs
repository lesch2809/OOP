using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDrive
{
    public class Auto
    {
        string marke;
        int leistung;
        int gang;
        int geschwindigkeit;
        int tank;
        bool autoAn;

        public string Marke
        {
            get { return marke; }
        }
        public bool AutoAn
        {
            get { return autoAn; }
        }
        public int Tank
        {
            get { return tank; }
        }
        public int Geschwindigkeit
        {
            get { return geschwindigkeit; }
        }
        public int Gang
        {
            get { return gang; }
        }

        public Auto(string marke_c, int leistung_c)
        {
            marke = marke_c;
            leistung = leistung_c;

        }
        public void Auftanken()
        {
            if (AutoAn == false)
            {
                tank = 100;
            }

            
        }
        public void Bremsen()
        {


            if (geschwindigkeit > 0)
            {
                geschwindigkeit -= 1;
            }

        }
        public void GibGas()
        {
            if (autoAn == true)
            {
                if (geschwindigkeit < leistung)
                {
                    if (tank > 0)
                    {
                        geschwindigkeit += (leistung / 50);
                        tank -= (geschwindigkeit / 100) + (leistung / 100);
                        if (tank <= 0)
                        {
                            tank = 0;
                            geschwindigkeit = 0;
                            gang = 0;
                            autoAn = false;
                            MessageBox.Show("Tank ist leer");
                        }
                        if (geschwindigkeit > 0 && geschwindigkeit < 10)
                        {
                            gang = 1;
                        }
                        if (geschwindigkeit > 10)
                        {
                            gang = 2;
                        }
                        if (geschwindigkeit > 20)
                        {
                            gang = 3;
                        }
                        if (geschwindigkeit > 40)
                        {
                            gang = 4;
                        }
                        if (geschwindigkeit > 70)
                        {
                            gang = 5;
                        }
                        if (geschwindigkeit > 101)
                        {
                            gang = 6;
                        }

                    }
                }
            }
        }
        public void Hupen()
        {
            MessageBox.Show("Hupen");
        }
        public void SchaltetMotorAus()
        {
            autoAn = false;
        }
        public void StarteMotor()
        {
            if (tank > 0)
            {
                autoAn = true;
            }
        }
        public override string ToString()
        {
            return marke + leistung;
        }

    }
}
