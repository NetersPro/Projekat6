using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class VodjaGrupe : Lovac  //vodja grupe je lovac pa imamo nasledjivanje
    {
        private string loviste;
        private string zbornoMesto;

        //konstruktor
        public VodjaGrupe(string vdimePrezime,
                          int vdgodiste,
                          bool vdaktivan,
                          string vdloviste,
                          string vdzbornoMesto)

            : base(vdimePrezime, vdgodiste) // poziv konsruktora Lovac sa dva parametra 
        {
            loviste = vdloviste;
            zbornoMesto = vdzbornoMesto;
            vdaktivan = true;
        }

        //metode
        public void IspisVodjaGrupe()
        {
            Console.WriteLine("Vodja grupe za loviste " + loviste + " i zborno mesto " + zbornoMesto + " je:");
            base.IspisLovca();
        }
    }

}
