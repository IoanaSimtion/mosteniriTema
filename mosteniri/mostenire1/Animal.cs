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
    }
}
