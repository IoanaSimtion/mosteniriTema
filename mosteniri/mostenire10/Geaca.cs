using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire10
{
    public class Geaca : Haina
    {
        private int greutate;

        public Geaca()
        {

        }

        //public Geaca(int greutate)
        //{
        //    this.greutate = greutate;
        //}

        public Geaca(string properties) : base(properties)
        {
            string[] propr = properties.Split(",");

            this.greutate = Int32.Parse(propr[4]);

        }

        public int Greutate
        {
            get { return this.greutate; }
            set { this.greutate = value; }
        }

        public override string ToString()
        {
            string text = base.ToString();

            text += "Greutate gecaca: " + this.greutate.ToString() + "\n";

            return text;
        }
    }
}
