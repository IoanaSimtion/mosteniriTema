using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire2
{
    public class Fruct
    {
        private int greutate;
        private string tip;
        private string aroma;

        public Fruct(int greutate, string tip, string aroma)
        {
            this.greutate = greutate;
            this.tip = tip;
            this.aroma = aroma;
        }

        public Fruct()
        {

        }

        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }

        public int Greutate
        {
            get { return greutate;}
            set { greutate = value; }
        }

        public string Aroma
        {
            get { return aroma; }
            set { aroma = value; }
        }
    }
}
