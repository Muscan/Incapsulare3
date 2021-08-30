using System;
using System.Collections.Generic;
using System.Text;

namespace Incapsulare3
{
    class Fruct
    {
        private string numeFruct;
        private double greutate;
        private bool isComestibil;
        private int pret;
        private string tara;//il folosesc doar intr-un get si set tara
    
        public Fruct(string nume, double greutate, bool isComestibil, int pret)
        {
            this.numeFruct = nume;
            this.greutate = greutate;
            this.isComestibil = isComestibil;
            this.pret = pret;
        }

        //constructor pentru pret si nume
        public Fruct(string nume, int pret)
        {
            this.numeFruct = nume;
            this.pret = pret;
        }
        public Fruct() { }

        public void setNume(string paramNume)
        {
            this.numeFruct = paramNume;

        }

        public string getNume()
        {
            return this.numeFruct;
        }

        public void setGreutate(double greutate)
        {
            this.greutate = greutate;
        }

        public double getGreutate()
        {
            return this.greutate;
        }

        public void setIsComestibil(bool isComestibil)
        {
            this.isComestibil = isComestibil;
        }
        public bool getIsComestibil()
        {
            return this.isComestibil;
        }

        public void setPret(int pret)
        {
            this.pret = pret;
        }

        public int getPret()
        {
            return this.pret;
        }

        public void setTara(string tara)
        {
            this.tara = tara;
        }
        public string getTara()
        {
            return this.tara;
        }

        public string descriereFruct()
        {
            string propFruct = "";
            propFruct += "Nume fruct: " + this.numeFruct + "\n";
            propFruct += "Greutate: " + this.greutate + "\n";
            propFruct += "Is comestibil: " + this.isComestibil + "\n";
            propFruct += "Pret: " + this.pret + "\n";
            return propFruct;
        }

    }


}
