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

        public FilmRomantic(string properties) : base(properties)
        {
            string[] propr = properties.Split(",");

            this.vizionari = Int32.Parse(propr[4]);
        }

        public int Vizionari
        {
            get { return this.vizionari; }
            set { this.vizionari = value; }
        }

        public string descriereFilmRomantic()
        {
            string text = base.descriereFilm();

            text += "Vizionari film romantic: " + this.vizionari.ToString() + "\n";

            return text;
        }
    }
}
