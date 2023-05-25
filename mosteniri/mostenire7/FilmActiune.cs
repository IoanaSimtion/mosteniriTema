using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire7
{
    public class FilmActiune:Film
    {
        private int durata;

        public FilmActiune(int durata)
        {
            this.durata = durata;
        }

        public FilmActiune()
        {

        }

        public int Durata
        {
            get { return this.durata; }
            set { this.durata = value; }
        }
    }
}
