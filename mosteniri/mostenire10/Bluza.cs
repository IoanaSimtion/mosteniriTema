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

        public Bluza(string culoare)
        {
            this.culoare = culoare;
        }

        public Bluza()
        {

        }

        public string Culoare
        {
            get { return this.culoare; }
            set { this.culoare = value; }
        }
    }
}
