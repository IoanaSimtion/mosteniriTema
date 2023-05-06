using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire3
{
    public class Morcov:Leguma
    {
        private string gust;

        public Morcov()
        {

        }

        public Morcov(string gust)
        {
            this.gust = gust;
        }
        
        public string Gust
        {
            get { return gust; }
            set { gust = value; }
        }

    }
}
