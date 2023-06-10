using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire9
{
    public class Inel : Bijuterie
    {
        private string brand;

        public Inel()
        {

        }

        //public Inel(string brand)
        //{
        //    this.brand = brand;
        //}

        public Inel(string properties) : base(properties)
        {
            string[] propr = properties.Split(",");

            this.brand = propr[4];
        }
        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        public string descriereInel()
        {
            string text = base.descriereBijuterie();

            text += "Cod inel: " + this.GetHashCode + "\n";

            return text;
        }
    }
}
