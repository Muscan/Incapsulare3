using System;
using System.Collections.Generic;
using System.Text;

namespace Incapsulare3.Controllers
{
    class ControllerPlanta
    {
        private List<Planta> plante;
        public ControllerPlanta()
        {
            plante = new List<Planta>();
            Planta planta1 = new Planta(true, 121, "muscata");
            Planta planta2 = new Planta(false, 123, "trandafir", 200);
            Planta planta3 = new Planta(true, 2311, "lalea", 45);

            plante.Add(planta1);
            plante.Add(planta2);
            plante.Add(planta3);
        }

        public void PrintAllPlants()
        {
            Console.WriteLine("Descrierea plantelor:");
            for(int i = 0; i < plante.Count; i++)
            {
                Console.WriteLine(plante[i].descPlanta());
            }
        }
    }
}
