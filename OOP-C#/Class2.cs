using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Lovac
    {
        private string imePrezime;
        private int godiste;
        private bool aktivan;
        private List<Oruzje> listaOruzja;
        private List<Trofej> listaTrofeja;

        //konstruktori
        public Lovac()
        {
            imePrezime = "Lovac Lovcevic";
            godiste = 1921;
            aktivan = false;
            listaOruzja = new List<Oruzje>();
            listaTrofeja = new List<Trofej>();
        }
        public Lovac(string imePrezime, int godiste)
        {
            this.imePrezime = imePrezime;
            if (godiste >= 1921 && godiste <= 2002)
                this.godiste = godiste;
            else
                this.godiste = 2002;
            this.aktivan = true;
            this.listaOruzja = new List<Oruzje>();
            this.listaTrofeja = new List<Trofej>();
        }

        //svojstva
        public string ImePrezime
        {
            get { return imePrezime; }
            set { imePrezime = value; }
        }
        public int Godiste
        {
            get { return godiste; }
            set
            {
                if (value >= 1921 && value <= 2002)
                    godiste = value;
                else
                    Console.WriteLine("Neispravan unos godista!");
            }
        }
        public bool Aktivan
        {
            get { return aktivan; }
            set { aktivan = true; }
        }

        //metode
        public void DodajOruzje(Oruzje O)
        {
            listaOruzja.Add(O);
        }
        public void DodajTrofej(Trofej T)
        {
            listaTrofeja.Add(T);
        }
        public void BrojTrofeja()
        {
            int brT = 0;
            foreach (Trofej T in listaTrofeja)
                if (T.BrojMarkice != 1)  // poziva get svojstvo BrojMarkice jer zbog enkapsulacije ne moze da psitupi direktno brojMarkice
                    brT++;
            Console.WriteLine("Broj trofeja: " + brT);
        }
        public void BrojOruzja()
        {
            int brO = 0;
            foreach (Oruzje O in listaOruzja)
                if (O.RegBroj != "-") // poziva get svojstvo RegBroj jer zbog enkapsulacije ne moze da pristupi direktno regBroj
                    brO++;
            Console.WriteLine("Broj Oruzja: " + brO);
        }

        public void IspisLovca()
        {
            Console.WriteLine("Lovac " + imePrezime + " rodjen " + godiste + ". godine");
            if (aktivan == true)
            {
                Console.WriteLine("poseduje sledece oruzje:");
                foreach (Oruzje O in listaOruzja)
                    O.IspisO();
                Console.WriteLine("Lovackom udruzenju doneo je sledece trofeje:");
                foreach (Trofej T in listaTrofeja)
                    T.IspisT();
            }
            else
                Console.WriteLine(" vise nije aktivan");

        }

    }

}
