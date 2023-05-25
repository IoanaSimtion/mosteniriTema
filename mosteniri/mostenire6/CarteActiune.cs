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

        public CarteActiune(string nume)
        {
            this.nume = nume;
        }

        public CarteActiune()
        {

        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }
    }
}
