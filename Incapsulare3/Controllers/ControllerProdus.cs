using System;
using System.Collections.Generic;
using System.Text;

namespace Incapsulare3.Controllers
{
    class ControllerProdus
    {
        private List<Produs> produse;
        public ControllerProdus()
        {
            produse = new List<Produs>();
            Produs produs1 = new Produs("Eugenia", 2212, "Napolitana cu cioclata", 2.1);
            Produs produs2 = new Produs("Milka", 213, "Ciocolata cu capsiuni", 3.4);
            Produs produs3 = new Produs("Kinder", 123, "Ciocolata cu lapte", 5.6);

            produse.Add(produs1);
            produse.Add(produs2);
            produse.Add(produs3);
        }

        public void PrintAllProducts()
        {
            Console.WriteLine("Produsele sunt:");
            for (int i = 0; i < produse.Count; i++)
            {
                Console.WriteLine(produse[i].DescriereProdus());
            }
        }
    }
}
