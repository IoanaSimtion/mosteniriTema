using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire10
{
    public class Haina
    {
        private string material;
        private string brand;
        private int pret;

        public Haina(string material, string brand, int pret)
        {
            this.material = material;
            this.brand = brand;
            this.pret = pret;
        }

        public Haina()
        {

        }

        public Haina(string properties)
        {
            string[] propr = properties.Split(",");

            this.material = propr[1]; 
            this.brand = propr[2];
            this.pret = Int32.Parse(propr[3]);
        }
        public string Material
        {
            get { return this.material; }
            set { this.material = value; }
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        public int Pret
        {
            get { return this.pret; }
            set { this.pret = value; }
        }

        public string descriereHaina()
        {
            string text = "";

            text += "Material: " + this.material + "\n";
            text+="Brand: "+this.brand + "\n";
            text += "Pret: " + this.pret.ToString() + "\n";

            return text;
        }
    }
}
