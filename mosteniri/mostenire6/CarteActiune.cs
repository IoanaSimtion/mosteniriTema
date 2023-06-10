using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire6
{
    public class CarteActiune:Carte
    {
        private string nume;

        //public CarteActiune(string nume)
        //{
        //    this.nume = nume;
        //}

        public CarteActiune(string properties) : base(properties)
        {
            string[] propr=properties.Split(",");

            this.nume=propr[4];
        }
        public CarteActiune()
        {

        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        public string descriereCarteActiune()
        {
            string text = base.descriereCarte();

            text += "Nume carte actiune: " + this.nume + "\n";

            return text;
        }
    }
}
