using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire2
{
    public class Afina:Fruct
    {
        public string tipAfina;

        public Afina()
        {

        }

        public Afina(string tipAfina)
        {
            this.tipAfina = tipAfina;
        }

        public string TipAfina
        {
            get { return tipAfina; }
            set { tipAfina = value; }
        }
    }
}
