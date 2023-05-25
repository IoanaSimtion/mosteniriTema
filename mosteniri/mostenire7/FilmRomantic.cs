using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire7
{
    public class FilmRomantic:Film
    {
        private int vizionari;

        public FilmRomantic()
        {

        }
        public FilmRomantic(int vizionari)
        {
            this.vizionari = vizionari;
        }

        public int Vizionari
        {
            get { return this.vizionari; }
            set { this.vizionari = value; }
        }
    }
}
