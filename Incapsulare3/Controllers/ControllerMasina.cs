using System;
using System.Collections.Generic;
using System.Text;

namespace Incapsulare3.Controllers
{
    class ControllerMasina
    {
        private List<Masina> masini;
        public ControllerMasina()
        {
            masini = new List<Masina>();
            Masina masina1 = new Masina("Lada", 1200, 1200, "Alba", 1901, "Fata stanga");
            Masina masina2 = new Masina("Dacia", 10000, 1999, "Rosie", 2021, "AWD");
            Masina masina3 = new Masina("Audi", 7844, 3333, "Gri", 2006, "AWD FWD 4*4");

            masini.Add(masina1);
            masini.Add(masina2);
            masini.Add(masina3);
            

        }
        public void printAllCars()
        {
            Console.WriteLine("Descrierea masinii: ");
            for (int i = 0; i < masini.Count; i++)
            {
                Console.WriteLine(masini[i].descriereMasina());

            }
        }
        public Masina masinaPuternica()
        {
            Masina bigEngine = masini[0];
            for (int i = 1; i < masini.Count; i++)
            {
                if (bigEngine.getMotor() < masini[i].getMotor())
                {
                    bigEngine = masini[i];
                }

            }
            return bigEngine;
        }
    }
}
