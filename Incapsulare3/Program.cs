using Incapsulare3.Controllers;
using System;
//using static Incapsulare3.Controllers.ControllerFruct;
namespace Incapsulare3
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerFruct controller = new ControllerFruct();
            //controller.printAllFruits();

            Fruct fr   = controller.printFruitSmallestPrice();

            controller.print1Fruit(fr);

            fr = controller.maxGramaj();
            controller.print1Fruit(fr);


            controller.printNameWeight(fr);
            double sumaPreturilor = controller.sumaFruits();
            Console.WriteLine("Suma preurilor fructelor: " + sumaPreturilor);

            bool comestibil = controller.isComestibil();
            if (comestibil == true)
            {
                Console.WriteLine("Toate fructele sunt comestibile.");
            }
            else
            {
                Console.WriteLine("Nu toate fructele sunt comestibile.");
            }

            double avg = controller.avgPreturi();
            Console.WriteLine("Media preturilor este: " + Math.Round(avg, 2));



            
        }
    }
}
