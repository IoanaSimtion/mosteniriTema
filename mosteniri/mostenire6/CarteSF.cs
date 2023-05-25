using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire6
{
    public class CarteSF:Carte
    {
        private int numarCititori;

        public CarteSF()
        {

        }

        public CarteSF(int numarCititori)
        {
            this.numarCititori = numarCititori;
        }

        public int NumarCititori
        {
            get { return this.numarCititori; }
            set { this.numarCititori = value; }
        }
    }
}
