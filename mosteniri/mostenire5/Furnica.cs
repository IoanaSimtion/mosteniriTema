using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire5
{
    public class Furnica:Insecta
    {
        private int dimensiune;

        public Furnica()
        {

        }

        public Furnica(int dimensiune)
        {
            this.dimensiune = dimensiune;
        }

        public int Dimensiune
        {
            get { return dimensiune; }
            set { dimensiune = value; }
        }
    }
}
