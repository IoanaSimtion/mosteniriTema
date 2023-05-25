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

        public Geaca(int greutate)
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
