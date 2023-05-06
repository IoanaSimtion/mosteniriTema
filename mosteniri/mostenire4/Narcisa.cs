using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire4
{
    public class Narcisa:Floare
    {
        public string culoarePetale;

        public Narcisa()
        {

        }

        public Narcisa(string culoarePetale)
        {
            this.culoarePetale = culoarePetale;
        }

        public string CuloarePetale
        {
            get { return culoarePetale; }
            set { culoarePetale = value; }
        }

    }
}
