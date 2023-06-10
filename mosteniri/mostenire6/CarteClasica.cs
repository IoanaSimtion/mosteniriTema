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

        //public CarteClasica(string tipCoperta)
        //{
        //    this.tipCoperta = tipCoperta;
        //}

        public CarteClasica(string properties) : base(properties)
        {
            string[] propr=properties.Split(",");

            this.tipCoperta = propr[4];
        }

        public string TipCoperta
        {
            get { return this.tipCoperta; }
            set { this.tipCoperta = value; }
        }

        public string descriereCarteClasica()
        {
            string text = base.descriereCarte();

            text += "Tip coperta carte clasica: " + this.tipCoperta + "\n";

            return text;
        }
    }
}
