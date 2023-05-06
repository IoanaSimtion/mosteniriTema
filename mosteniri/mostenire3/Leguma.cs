using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire3
{
    public class Leguma
    {
        private string tipLeguma;
        private int greutate;
        private int pret;

        public Leguma()
        {

        }

        public Leguma(string tipLeguma, int greutate, int pret)
        {
            this.tipLeguma = tipLeguma;
            this.greutate = greutate;
            this.pret = pret;
        }

        public string TipLeguma
        {
            get { return tipLeguma; }
            set { tipLeguma = value; }
        }

        public int Greutate
        {
            get { return greutate; }
            set { greutate = value; }
        }

        public int Pret
        {
            get { return pret; }
            set { pret = value; }
        }
    }
}
