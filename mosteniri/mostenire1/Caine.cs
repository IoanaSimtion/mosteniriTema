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

        public Caine(string properties) : base(properties)
        {
            string[] propr = properties.Split(",");

            this.rasa=propr[4];
            this.pret = Int32.Parse(propr[5]);

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

        public override string ToString()
        {
            string text = base.ToString();

            text += "Rasa caine: " + this.rasa + "\n";
            text += "Pret caine: " + this.pret + "\n";

            return text;
        }
    }
}
