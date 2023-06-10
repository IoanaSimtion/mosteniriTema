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
        public Colier(string properties) : base(properties)
        {
            string[] propr = properties.Split(",");

            this.lungime = Int32.Parse(propr[4]);
        }
        public int Lungime
        {
            get { return this.lungime; }
            set { this.lungime = value; }
        }

        public string descriereColier()
        {
            string text = base.descriereBijuterie();

            text += "Lungime colier: " + this.lungime + "\n";

            return text;
        }
    }
}
