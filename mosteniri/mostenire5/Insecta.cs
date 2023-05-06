using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire5
{
    public class Insecta
    {
        private int dimensiune;
        private string tip;

        public Insecta()
        {

        }

        public Insecta(int dimensiune, string tip)
        {
            this.dimensiune = dimensiune;
            this.tip = tip;
        }

        public int Dimensiune
        {
            get { return dimensiune; }
            set { dimensiune = value; }
        }

        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }
    }
}
