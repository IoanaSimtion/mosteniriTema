using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire8
{
    public class Toba:Instrument
    {
        private int greutate;

        public Toba()
        {

        }
        public Toba(int greutate)
        {
            this.greutate = greutate;
        }

        public int Greutate
        {
            get { return this.greutate; }
            set { this.greutate = value; }
        }
    }
}
