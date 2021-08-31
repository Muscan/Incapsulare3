using Incapsulare3.Controllers;
using System;
//using static Incapsulare3.Controllers.ControllerFruct;
namespace Incapsulare3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------------------FRUCTE-------------------------*/
            ControllerFruct controllerFructe = new ControllerFruct();
            //controller.printAllFruits();

            Fruct fr   = controllerFructe.printFruitSmallestPrice();

            controllerFructe.print1Fruit(fr);

            fr = controllerFructe.maxGramaj();
            controllerFructe.print1Fruit(fr);


            controllerFructe.printNameWeight(fr);
            double sumaPreturilor = controllerFructe.sumaFruits();
            Console.WriteLine("Suma preurilor fructelor: " + sumaPreturilor);

            bool comestibil = controllerFructe.isComestibil();
            if (comestibil == true)
            {
                Console.WriteLine("Toate fructele sunt comestibile.");
            }
            else
            {
                Console.WriteLine("Nu toate fructele sunt comestibile.");
            }

            double avg = controllerFructe.avgPreturi();
            Console.WriteLine("Media preturilor este: " + Math.Round(avg, 2));

            /*------------------TARI-------------------------*/
            ControllerTara controllerTari = new ControllerTara();
            controllerTari.printTari();
            controllerTari.printTariEU();

            /*------------------MASINI-------------------------*/
            ControllerMasina controllerMasini = new ControllerMasina();
            controllerMasini.printAllCars();
            Masina bigEngineController = controllerMasini.masinaPuternica();
            
            Console.WriteLine("Motorul cel mai mare: " + bigEngineController.descriereMasina());

            /*------------------PLANTE-------------------------*/
            ControllerPlanta controllerPlanta = new ControllerPlanta();
            controllerPlanta.PrintAllPlants();

            /*------------------PRODUSE-------------------------*/
            ControllerProdus controllerProduse = new ControllerProdus();
            controllerProduse.PrintAllProducts();

            /*------------------LOCUINTE-------------------------*/
            ControllerLocuinta controllerLocuinte = new ControllerLocuinta();
            controllerLocuinte.PrintLocuinte();
            int nrLocuinte = controllerLocuinte.LocuinteMaterial();
            Console.WriteLine("Numarul locuintelor din caramida este: " + nrLocuinte);
        }
    }
}
