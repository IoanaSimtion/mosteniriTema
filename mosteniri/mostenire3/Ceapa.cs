using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire3
{
    public class Ceapa : Leguma
    {
        private string tipCeapa;

        public Ceapa()
        {

        }
        public Ceapa(string tipCeapa)
        {
            this.tipCeapa = tipCeapa;
        }

        public string TipCeapa
        {
            get { return tipCeapa; }
            set { tipCeapa = value; }    
        }
    }
}
