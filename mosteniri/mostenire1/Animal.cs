using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire1
{
    public class Animal
    {
        private string grupa;
        private int greutate;
        private string mediuDeViata;


        public Animal()
        {

        }

        public Animal(string grupa, int greutate, string mediu)
        {
            this.grupa = grupa;
            this.greutate = greutate;
            this.mediuDeViata = mediu;
        }

        public Animal(string properties)
        {
            string[] propr = properties.Split(",");

            this.grupa=propr[1];
            this.greutate = Int32.Parse(propr[2]);
            this.mediuDeViata = propr[3];
        }

        public string Grupa
        {
            get { return this.grupa; }
            set { this.grupa = value; }
        }

        public int Greutate
        {
            get { return this.greutate; }
            set { this.greutate = value; }
        }

        public string MediuDeViata
        {
            get { return this.mediuDeViata; }
            set { this.mediuDeViata = value; }
        }

        public string descriereAnimal()
        {
            string text = "";

            text += "Grupa: " + this.grupa + "\n";
            text += "Greutate: " + this.greutate + "\n";
            text += "Mediu de viata: " + this.mediuDeViata + "\n";

            return text;
        }
    }
}
