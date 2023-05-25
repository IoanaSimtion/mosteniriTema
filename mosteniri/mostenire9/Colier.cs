using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire9
{
    public class Colier : Bijuterie
    {
        private int lungime;

        public Colier(int lungime)
        {
            this.lungime = lungime;
        }

        public Colier()
        {

        }

        public int Lungime
        {
            get { return this.lungime; }
            set { this.lungime = value; }
        }
    }
}
