using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire5
{
    public class Fluture:Insecta
    {
        private string culoareAripi;

        public Fluture()
        {

        }

        public Fluture(string culoareAripi)
        {
            this.culoareAripi = culoareAripi;
        }

        public string CuloareAripi
        {
            get { return culoareAripi; }
            set { culoareAripi = value; }
        }
    }
}
