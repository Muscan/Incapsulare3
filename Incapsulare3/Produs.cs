using System;
using System.Collections.Generic;
using System.Text;

namespace Incapsulare3
{
    class Produs
    {
        private string nume;
        private int id;
        private string descriere;
        private double pret;

        public Produs(string nume, int id, string descriere, double pret)
        {

            this.nume = nume;
            this.id = id;
            this.descriere = descriere;
            this.pret = pret;
        }

        public void setProdus(string nume)

        {
            this.nume = nume;

        }

        public string getProdus()
        {
            return this.nume;
        }


        public void setId(int id)
        {
            this.id = id;

        }

        public int getId()
        {
            return this.id;
        }

        public void setPret(double pret)

        {
            this.pret = pret;

        }

        public double getPret()
        {
            return this.pret;
        }


        public string DescriereProdus()
        {
            string  descProdus= "";
            descProdus += "Produs: " + this.nume + "\n";
            descProdus += "Id: " + this.id + "\n";
            descProdus += "Descriere: " + this.descriere + "\n";
            descProdus += "Pret: " + this.pret + "\n";

            return descProdus;
        }
    }
}
