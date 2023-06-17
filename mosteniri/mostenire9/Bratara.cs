using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire9
{
    public class Bratara : Bijuterie
    {
        private string cod;

        public Bratara()
        {

        }

        //public Bratara(string cod)
        //{
        //    this.cod = cod;
        //}

        public Bratara(string properties) : base(properties)
        {
            string[] propr = properties.Split(",");

            this.cod = propr[4];
        }

        public string Cod
        {
            get { return this.cod; }
            set { this.cod = value; }
        }

        public override string ToString()
        {
            string text = base.ToString();

            text += "Cod bratara: " + this.cod + "\n";

            return text;
        }
    }
}
