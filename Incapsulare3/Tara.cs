using System;
using System.Collections.Generic;
using System.Text;

namespace Incapsulare3
{
    class Tara
    {
        private string nume;
        private double suprafata;
        private bool isUE;
        private int populatie;
   
        public Tara(string nume, double suprafata, bool isUE, int populatie)
        {
            this.nume = nume;
            this.suprafata = suprafata;
            this.isUE = isUE;
            this.populatie = populatie;
        }
        public Tara(string nume, bool isUE)
        {
            this.nume = nume;
            this.isUE = isUE;
        }
        public Tara()
        {

        }

        public void setNume(string nume)
        {
            this.nume = nume;

        }
        public string getNume()
        {
            return this.nume;
        }

        public void setSuprafata(double suprafata)
        {
            this.suprafata = suprafata;
        }

        public double getSuprafata()
        {
            return this.suprafata;
        }

        public void setIsUE(bool isUE)
        {
            this.isUE = isUE;
        }

        public bool getIsUE()
        {
            return this.isUE;
        }

        public void setPopulatie(int populatie)
        {
            this.populatie = populatie;

        }

        public int getPopulatie()
        {
            return this.populatie;
        }

        public string descriereTara()
        {
            string descTara = "";
   
            descTara += "Nume tara: " + this.nume + "\n";
            descTara += "Suprafata: " + this.suprafata + "\n";
            descTara += "IS UE member: " + this.isUE + "\n";
            descTara += "Populatie: " + this.populatie + "\n";
            
            return descTara;
        }
    }

    
}
