using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire6
{
    public class CarteClasica:Carte
    {
        private string tipCoperta;

        public CarteClasica()
        {

        }

        public CarteClasica(string tipCoperta)
        {
            this.tipCoperta = tipCoperta;
        }

        public string TipCoperta
        {
            get { return this.tipCoperta; }
            set { this.tipCoperta = value; }
        }
    }
}
