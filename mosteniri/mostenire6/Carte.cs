using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire6
{
    public class Carte
    {

        private string autor;
        private int an;
        private int pret;

        public Carte()
        {

        }

        public Carte(string autor, int an, int pret)
        {
            this.autor = autor;
            this.an = an;
            this.pret = pret;
        }

        public string Autor
        {
            get { return this.autor; }
            set { this.autor = value; }
        }

        public int An
        {
            get { return this.an; }
            set { this.an = value; }
        }

        public int Pret
        {
            get { return this.pret; }
            set { this.pret = value; }
        }

    }
}
