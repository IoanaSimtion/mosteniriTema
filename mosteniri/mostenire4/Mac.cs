using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire4
{
    public class Mac:Floare
    {
        private int inaltme;

        public Mac()
        {

        }

        public Mac(int inaltme)
        {
            this.inaltme = inaltme;
        }

        public int Inaltme
        {
            get { return inaltme; }
            set { inaltme = value; }
        }
    }
}
