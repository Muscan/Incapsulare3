using System;
using System.Collections.Generic;
using System.Text;
using Incapsulare3.Controllers;

namespace Incapsulare3.Controllers
{
    class ControllerTara
    {
        private List<Tara> tari;

        public ControllerTara()//constructor
        {
            tari = new List<Tara>();

            Tara tara1 = new Tara("Romania", 238397, true, 19186201);
            Tara tara2 = new Tara("USA", false);
            Tara tara3 = new Tara("UK", false);
            Tara tara4 = new Tara("Germania", 800000, true, 80000000);
            Tara tara5 = new Tara("Italia", 400000, true, 40000000);

            tari.Add(tara1);
            tari.Add(tara2);
            tari.Add(tara3);
            tari.Add(tara4);
            tari.Add(tara5);
        }

        public void printTari()
        {
            for (int i = 0; i < tari.Count; i++)
            {
                Console.WriteLine(tari[i].descriereTara());
            }
        }
        //print all countries which are in eu(nane and surface)
        public void printTariEU()
        {
            Console.WriteLine("Tari care sunt in EU: ");
            for (int i = 0; i < tari.Count; i++)
            {
                if (tari[i].getIsUE() == true)
                {
                    Console.WriteLine(tari[i].getNume() +' '+tari[i].getSuprafata());
                }
            }
        }
    }
}
