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

        public Bijuterie(string properties)
        {
            string[] propr = properties.Split(",");

            this.material = propr[1];
            this.gramaj = Int32.Parse(propr[2]);
            this.pret = Int32.Parse(propr[3]);
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

        public override string ToString()
        {
            string text = "";

            text += "Material: " + this.material + "\n";
            text += "Gramaj: " + this.gramaj.ToString() + "\n";
            text += "Pret: " + this.pret.ToString() + "\n";

            return text;
        }
    }
}
