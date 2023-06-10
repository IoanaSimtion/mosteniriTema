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

        //public FilmSF(string numeProtagonist)
        //{
        //    this.numeProtagonist = numeProtagonist;
        //}

        public FilmSF(string properties) : base(properties)
        {
            string[] propr = properties.Split(",");

            this.numeProtagonist = propr[4];
        }
        public string NumeProtagonist
        {
            get { return this.numeProtagonist; }
            set { this.numeProtagonist = value; }
        }

        public string descriereFilmSF()
        {
            string text = base.descriereFilm();

            text += "Nume protagonist film SF: " + this.numeProtagonist + "\n";

            return text;
        }
    }
}
