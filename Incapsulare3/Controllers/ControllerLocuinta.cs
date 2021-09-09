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

        public int Index(string material)
        {
            for (int i = 0; i < locuinte.Count; i++)
            {
                if (locuinte[i].getMaterial().Equals(material))
                {
                    return i;
                }

            }
            Console.WriteLine("Index not found");
            return -1;
        }
        public bool Add(Locuinta locuinta)
        {
            int pozitia = Index(locuinta.getMaterial());
            if (pozitia == -1)
            {
                this.locuinte.Add(locuinta);
                Console.WriteLine("Item added!");
                return true;    
            }
         Console.WriteLine("Item exists!");
            return false;
        }

    }
}
