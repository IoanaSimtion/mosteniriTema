using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire1
{
    public class Urs:Animal
    {
        private string tip;
        private int varsta;

        public Urs(string tip, int varsta)
        {
            this.tip = tip;
            this.varsta = varsta;
        }

        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }

        public int Varsta
        {
            get { return varsta; }
            set { varsta = value; }
        }
    }
}
