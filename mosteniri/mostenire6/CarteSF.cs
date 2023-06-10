using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire6
{
    public class CarteSF : Carte
    {
        private int numarCititori;

        public CarteSF()
        {

        }

        //public CarteSF(int numarCititori)
        //{
        //    this.numarCititori = numarCititori;
        //}

        public CarteSF(string properties) : base(properties)
        {
            string[] propr=properties.Split(",");

            this.NumarCititori=Int32.Parse(propr[4]);
        }

        public int NumarCititori
        {
            get { return this.numarCititori; }
            set { this.numarCititori = value; }
        }

        public string descriereCarteSF()
        {
            string text = base.descriereCarte();

            text += "Numar cititori carte SF: " + this.NumarCititori.ToString() + "\n";

            return text;
        }
    }
}
