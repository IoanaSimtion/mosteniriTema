using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire8
{
    public class Chitara : Instrument
    {
        private int numarCorzi;

        public Chitara()
        {

        }

        public Chitara(int numarCorzi)
        {
            this.numarCorzi = numarCorzi;
        }

        public int NumarCorzi
        {
            get { return this.numarCorzi; }
            set { this.numarCorzi = value; }
        }
    }
}
