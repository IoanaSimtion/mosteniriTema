using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire1
{
    public class Caine:Animal
    {
        private string rasa;
        private int pret;

        public Caine()
        {

        }

        public Caine(string rasa, int pret)
        {
            this.rasa = rasa;
            this.pret = pret;
        }

        public string Rasa
        {
            get { return rasa; }
            set { rasa = value; }
        }

        public int Pret
        {
            get { return pret; }
            set { pret = value; }
        }
    }
}
