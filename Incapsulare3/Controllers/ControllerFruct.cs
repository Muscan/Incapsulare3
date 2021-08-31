using System;
using System.Collections.Generic;
using System.Text;


namespace Incapsulare3.Controllers
{
    class ControllerFruct
    {
        private List<Fruct> fructe;

        public ControllerFruct()
        {
            fructe = new List<Fruct>();

            Fruct fruct1 = new Fruct("Mar", 100.1, true, 10);
            fruct1.setTara("Polonia");
            Fruct fruct2 = new Fruct("Capsuna", 20);
            Fruct fruct3 = new Fruct("Fructul interzis", 15.22, false, 7);


            fructe.Add(fruct1);
            fructe.Add(fruct2);
            fructe.Add(fruct3);
        }
        public void printAllFruits()
        {
            for (int i = 0; i < fructe.Count; i++)
            {
                Console.WriteLine(fructe[i].descriereFruct());

            }
        }

        public Fruct printFruitSmallestPrice()
        {
            Fruct pretMinim = fructe[0];
            for (int i = 1; i < fructe.Count; i++)
            {
                if (fructe[i].getPret() < pretMinim.getPret())
                {
                    pretMinim = fructe[i];
                }
                
            }
            return pretMinim;
        }

        public void print1Fruit(Fruct fruct)
        {
            Console.WriteLine(fruct.descriereFruct());
        }

        public Fruct maxGramaj()
        {
            Fruct gramajMax = fructe[0];//100
            for (int i = 1; i < fructe.Count; i++)
            {
                if (fructe[i].getGreutate() > gramajMax.getGreutate())
                {
                    gramajMax = fructe[i];
                }

            }
            return gramajMax;
          
        }
        public void printNameWeight(Fruct fruct)
        {
            Console.WriteLine(fruct.getNume() + " " + fruct.getGreutate());
        }

        public double sumaFruits()

        {
            double suma = 0;
            for (int i = 0; i < fructe.Count; i++)
            {
                suma += fructe[i].getPret();
            }
            return suma;
        }

        public bool isComestibil()
        {
            for (int i = 0; i < fructe.Count; i++)
            {
                if (fructe[i].getIsComestibil() == false)
                {
                    return false;
                }    
            }
            return true;

        }

        public double avgPreturi()
        {
            double avg = 0;
            avg = sumaFruits() / fructe.Count;
            return avg;
        }
        
    }
}
