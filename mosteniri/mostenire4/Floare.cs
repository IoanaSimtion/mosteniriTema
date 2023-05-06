using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire4
{
    public class Floare
    {
        private string parfum;
        private string tipFloare;

        public Floare()
        {

        }
        public Floare(string parfum, string tipFloare)
        {
            this.parfum = parfum;
            this.tipFloare = tipFloare;
        }

        public string Parfum
        {
            get { return parfum; }
            set { parfum = value; }
        }

        public string TipFloare
        {
            get { return tipFloare; }
            set { tipFloare = value; }
        }
    }
}
