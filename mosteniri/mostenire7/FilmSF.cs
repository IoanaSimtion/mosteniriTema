using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire7
{
    public class FilmSF:Film
    {
        private string numeProtagonist;

        public FilmSF()
        {

        }

        public FilmSF(string numeProtagonist)
        {
            this.numeProtagonist = numeProtagonist;
        }

        public string NumeProtagonist
        {
            get { return this.numeProtagonist; }
            set { this.numeProtagonist = value; }
        }
    }
}
