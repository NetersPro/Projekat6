using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Trofej
    {
        private string lovnaGodina;
        private string oznakaDivljaci;
        private int brojMarkice;

        //konstruktor
        public Trofej()
        {
            lovnaGodina = "2020/2021";
            oznakaDivljaci = "DS";
            brojMarkice = 1;
        }
        public Trofej(string lovnaGodina, string oznakaDivljaci, int brojMarkice)
        {
            this.lovnaGodina = lovnaGodina;
            this.oznakaDivljaci = oznakaDivljaci;
            if (brojMarkice < 0 || brojMarkice > 500)
                this.brojMarkice = 1;
            else
                this.brojMarkice = brojMarkice;
        }

        //svojstva
        public string LovnaGodina
        {
            get { return lovnaGodina; }
        }

        public string OznakaDivljaci
        {
            get { return oznakaDivljaci; }
        }

        public int BrojMarkice
        {
            get { return brojMarkice; }
            set
            {
                if (value < 1 || value > 500)
                    Console.WriteLine("Neispravan unos broja markice");
                else
                    brojMarkice = value;
            }
        }
        //metode
        public void IspisT()
        {

            if (brojMarkice != 1)
            {
                string t = lovnaGodina + " " + oznakaDivljaci + " " + brojMarkice;
                Console.WriteLine(t);
            }
        }

    }

}
