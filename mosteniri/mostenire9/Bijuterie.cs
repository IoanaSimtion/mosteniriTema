using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire9
{
    public class Bijuterie
    {
        private string material;
        private int gramaj;
        private int pret;

        public Bijuterie()
        {

        }

        public Bijuterie(string material, int gramaj, int pret)
        {
            this.material = material;
            this.gramaj = gramaj;
            this.pret = pret;
        }

        public string Material
        {
            get { return this.material; }
            set { this.material = value; }
        }

        public int Gramaj
        {
            get { return this.gramaj; }
            set { this.gramaj = value; }
        }

        public int Pret
        {
            get { return this.pret; }
            set { this.pret = value; }
        }
    }
}
