using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************\n");
            Console.WriteLine("Testiranje klase Oruzje\n");
            Console.WriteLine("***********************\n");
            Oruzje o1 = new Oruzje("LO-1234", 13);      // konstruktor sa paramterima ce za kalibar upisati 12 (za potebe zadatka, kalibar moze biti samo 12 ii 16)
            o1.IspisO();                                // ispis objekta oruzje o1 upotrebom metode

            o1.RegBroj = "LO 516"; //pristup polju preko set svojstva
            o1.Kalibar = 15;       //upotreba set svojstva-  treba da ispise poruku o pogresnom unosu jer je dozvoljen unos samo vrednosti 16 i 12
            o1.IspisO();           //Ispis objekta o1 sa novim vrednostima polja 

            Console.WriteLine("\nRegistarski broj oruzja: " + o1.RegBroj + " kalibar: " + o1.Kalibar); // ispis vrednosti polja objekta o1 uz koriscenje get svojstva

            Oruzje o2 = new Oruzje("LO-456", 16);
            Console.WriteLine("\nRegistarski broj oruzja: " + o2.RegBroj + " kalibar: " + o2.Kalibar);

            Oruzje o3 = new Oruzje();                   // konstruktor bez parametara  upisuje "-" i  12            
            Oruzje o4 = new Oruzje("LO-7894", 12);
            Oruzje o5 = new Oruzje();

            //***************************************************************************************************************

            Console.WriteLine("*************************\n");
            Console.WriteLine("\nTestiranje klase Trofej\n");
            Console.WriteLine("*************************\n");

            Trofej t1 = new Trofej("2019/2020", "DS", 105); // konstruktor sa parametrima
            t1.IspisT();                                    //ispis polja objekta t1 upotrebom metode    
            Trofej t2 = new Trofej("2020/2021", "VU", 700); //u broj markice konstruktor ce upisati 500
            t2.IspisT();                                    //ispis polja objekta t1 upotrebom metode  

            Trofej t3 = new Trofej(); // konstruktor bes parametara upisuje 2020/2021, DS, 1 
            t3.IspisT();
            Trofej t4 = new Trofej("1975/1976", "SO", 230);
            Trofej t5 = new Trofej("1984/1985", "DS", 148);
            Trofej t6 = new Trofej("1999/2000", "LS", 279);

            t3.BrojMarkice = 600;  // svojstvo treba da ispise poruku o pogresnom unosu i dodeli ispravne vrednosti
            Console.WriteLine("\nTrofej: " + t3.LovnaGodina + " " + t3.OznakaDivljaci + " " + t3.BrojMarkice); // ispis polja objekta t3 upotrebom get svojstva
            Console.WriteLine();
            //*********************************************************************************************************
            Console.WriteLine("************************\n");
            Console.WriteLine("\nTestiranje klase Lovac\n");
            Console.WriteLine("************************\n");

            Lovac l1 = new Lovac(); //kreiranje objekta l1 konstruktorom bez parametara
            l1.IspisLovca();        // ispis polja objekta lovac upotrebom metode

            l1.ImePrezime = "Sreten Prokopic";    //upotreba set svojstva za promenu imena i prezimena u objektu l1
            l1.Godiste = 2005; // upotreba set svojstva za godiste - treba da se pojavi poruka o pogresnom unosu jer godiste ne se da bude vece od 2002
            l1.Godiste = 1999; // upotreba set svojstva za godiste
            l1.Aktivan = true; // konstruktorom bez parametara ovo polje je postavljeno na false, sada ga set svojstvom postavljam na true
            // kreiranim objektima klase Oruzje punim listu listaOruzja 
            l1.DodajOruzje(o2);
            l1.DodajOruzje(o3);
            // kreiranim objektima klase Trofej punim listu listaTrofeja
            l1.DodajTrofej(t1);
            l1.DodajTrofej(t2);
            //ispisujem polja objekta l1 upotrebom metode
            l1.IspisLovca();
            // upotrebom metoda iz klase Lovac, prebrojavam ukupan broj oruzja i ukupan broj trofeja, ne ubrajajuci oruzje bez registarsko broja i trofeje sa brojem markice 1
            l1.BrojOruzja();
            l1.BrojTrofeja();
            Console.WriteLine("\n*************************************************\n");


            VodjaGrupe vg = new VodjaGrupe("Milorad Miloradovic", 1943, true, "Jadar", "Surice");
            vg.IspisVodjaGrupe(); // ispis polja objekta VodjaGrupe - liste oruzja i trofeja su prazne
            Console.WriteLine("*************************************");

            //dodavanje objekata klase Oruzje u objekat klase VodjaGrupe
            vg.DodajOruzje(o1);
            vg.DodajOruzje(o4);
            vg.DodajOruzje(o5);
            //dodavanje objekata klase Trofej u objekat klase VodjaGrupe
            vg.DodajTrofej(t4);
            vg.DodajTrofej(t5);
            vg.DodajTrofej(t6);

            vg.IspisVodjaGrupe(); // ispis polja objekta VodjaGrupe, nakon "punjenja" liste oruzja i liste trofeja
            Console.WriteLine("*************************************");
            vg.BrojOruzja();
            vg.BrojTrofeja();

        }
    }
}
