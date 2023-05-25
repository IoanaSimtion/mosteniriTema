using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire7
{
    public class Film
    {
        private string nume;
        private int an;
        private string regizor;

        public Film()
        {

        }

        public Film(string nume, int an, string regizor)
        {
            this.nume = nume;
            this.an = an;
            this.regizor = regizor;
        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        public int An
        {
            get { return this.an; }
            set { this.an = value; }
        }

        public string Regizor
        {
            get { return this.regizor; }
            set { this.regizor = value; }
        }
    }
}
