using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Oruzje
    {
        private string regBroj;
        private int kalibar;

        //konstruktor
        public Oruzje() //bez parametara 
        {
            regBroj = "-";
            kalibar = 12;
        }

        public Oruzje(string regBroj, int kalibar) //sa oaranetrima
        {
            if (regBroj == null)
                this.regBroj = "-";
            else
                this.regBroj = regBroj;

            if (kalibar == 12 || kalibar == 16)
                this.kalibar = kalibar;
            else
                this.kalibar = 12;
        }

        //svojstva
        public string RegBroj // kada se zeli promena vrednosti koju je dao konstruktor, da se ne unese null vrednost
        {
            get { return regBroj; }
            set
            {
                if (value == null)
                    Console.WriteLine("Nispravan unos registarskog broja oruzja!");
                else
                    regBroj = value;
            }
        }
        public int Kalibar // kada se zeli promena vrednosti koju je dao konstruktor, da se unese pogresna vrednost
        {
            get { return kalibar; }
            set
            {
                if (value != 12 && value != 16)
                    Console.WriteLine("Neispravan kalibar!");
                else
                    kalibar = value;
            }
        }
        //metode
        public void IspisO()
        {
            if (regBroj != "-")
            {
                string o = regBroj + " " + kalibar;
                Console.WriteLine(o);
            }
        }

    }

}
