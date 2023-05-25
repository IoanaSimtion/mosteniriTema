using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire9
{
    public class Bratara : Bijuterie
    {
        private string cod;

        public Bratara()
        {

        }

        public Bratara(string cod)
        {
            this.cod = cod;
        }

        public string Cod
        {
            get { return this.cod; }
            set { this.cod = value; }
        }
    }
}
