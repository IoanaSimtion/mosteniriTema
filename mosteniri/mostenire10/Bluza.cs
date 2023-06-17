using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire10
{
    public class Bluza :Haina
    {
        private string culoare;

        //public Bluza(string culoare)
        //{
        //    this.culoare = culoare;
        //}

        public Bluza()
        {

        }

        public Bluza(string properties) : base(properties)
        {
            string[] propr = properties.Split(",");

            this.culoare = propr[4];
        }

        public string Culoare
        {
            get { return this.culoare; }
            set { this.culoare = value; }
        }

        public override string ToString()
        {
            string text = base.ToString();

            text += "Culoare bluza: " + this.culoare + "\n";

            return text;
        }
    }
}
