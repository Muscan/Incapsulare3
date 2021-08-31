using System;
using System.Collections.Generic;
using System.Text;

namespace Incapsulare3.Controllers
{
    class ControllerLocuinta
    {
        private List<Locuinta> locuinte;
        public ControllerLocuinta()
        {
            locuinte = new List<Locuinta>();
            Locuinta locuinta1 = new Locuinta("Caramida", 230, "Alba", 230000.23);
            Locuinta locuinta2 = new Locuinta("Lemn", 123, "Maro", 102220);
            Locuinta locuinta3 = new Locuinta("Caramida", 189, "Rosie", 210110.45);

            locuinte.Add(locuinta1);
            locuinte.Add(locuinta2);
            locuinte.Add(locuinta3);
        }

        public void PrintLocuinte()
        {
            Console.WriteLine("Descrierea locuintelor:");
            for (int i = 0; i < locuinte.Count; i++)
            {
                Console.WriteLine(locuinte[i].DescriereLocuinta());
            }
        }

        public int LocuinteMaterial()
        {
            Console.WriteLine("Locuintele din acelasi material: ");
            int contor = 0;
            for (int i = 0; i < locuinte.Count; i++)
            {
                if (locuinte[i].getMaterial() == "Caramida")
                {
                    Console.WriteLine(locuinte[i].DescriereLocuinta());
                    contor++;
                }
            }
            return contor;
        }

    }
}
