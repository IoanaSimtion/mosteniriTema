using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire3
{
    public class Cartof:Leguma
    {
        private string dimensiune;

        public Cartof()
        {

        }

        public Cartof(string dimensiune)
        {
            this.dimensiune = dimensiune;
        }

        public string Dimensiune
        {
            get { return dimensiune; }
            set { dimensiune = value; }
        }
    }
}
