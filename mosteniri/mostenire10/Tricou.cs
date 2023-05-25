using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire10
{
    public class Tricou : Haina
    {
        private string model;

        public Tricou()
        {

        }

        public Tricou(string model)
        {
            this.model = model;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
    }
}
