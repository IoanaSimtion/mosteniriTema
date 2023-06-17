using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire1
{
    public class Pisica:Animal
    {
        private string rasaPisica;
        private string culoareBlana;

        public Pisica(string rasaPisica, string culoareBlana)
        {
            this.rasaPisica = rasaPisica;
            this.culoareBlana = culoareBlana;
        }

        public Pisica()
        {

        }

        public Pisica(string properties) : base(properties)
        {
            string[] propr = properties.Split(",");

            this.rasaPisica = propr[4];
            this.culoareBlana = propr[5];
        }

        public string RasaPisica
        {
            get { return rasaPisica; }
            set { rasaPisica = value; }
        }

        public string CuloareBlana
        {
            get { return culoareBlana; }
            set { culoareBlana = value; }
        }

        public override string ToString()
        {
            string text = base.ToString();

            text += "Rasa pisica: " + this.rasaPisica + "\n";
            text += "Culoare blana pisica: " + this.culoareBlana + "\n";

            return text;
        }
    }
}
