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

        //public Tricou(string model)
        //{
        //    this.model = model;
        //}

        public Tricou(string properties) : base(properties)
        {
            string[] propr = properties.Split(",");

            this.model = propr[4];
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string descriereTricou()
        {
            string text = base.descriereHaina();

            text += "Model tricou: " + this.model + "\n";

            return text;
        }
    }
}
