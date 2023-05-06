using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire4
{
    public class Lalea:Floare
    {
        private int pret;

        public Lalea()
        {

        }

        public Lalea(int pret)
        {
            this.pret = pret;
        }

        public int Pret
        {
            get { return pret; }
            set { pret = value; }
        }
    }
}
