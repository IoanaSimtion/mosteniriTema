using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire8
{
    public class Harpa:Instrument
    {
        private int aniVechime;

        public Harpa()
        {

        }

        public Harpa(int aniVechime)
        {
            this.aniVechime = aniVechime;
        }

        public int AniVechime
        {
            get { return this.aniVechime; }
            set { this.aniVechime = value; }
        }
    }
}
