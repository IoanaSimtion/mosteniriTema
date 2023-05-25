using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire8
{
    public class Instrument
    {
        private string tipInstrument;
        private int pret;
        private string denumire;

        public Instrument(string tipInstrument, int pret, string denumire)
        {
            this.tipInstrument = tipInstrument;
            this.pret = pret;
            this.denumire = denumire;
        }

        public Instrument()
        {

        }

        public string TipInstrument
        {
            get { return this.tipInstrument; }
            set { this.tipInstrument = value; }
        }

        public int Pret
        {
            get { return this.pret; }
            set { this.pret = value; }
        }

        public string Denumire
        {
            get { return this.denumire; }
            set { this.denumire = value; }
        }
    }
}
