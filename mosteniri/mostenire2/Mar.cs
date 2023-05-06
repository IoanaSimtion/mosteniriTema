using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire2
{
    public class Mar:Fruct
    {
        public string culoare;

        public Mar()
        {

        }

        public Mar(string culoare)
        {
            this.culoare = culoare;
        }

        public string Culoare
        {
            get { return culoare; }
            set { culoare = value; }
        }
    }
}
