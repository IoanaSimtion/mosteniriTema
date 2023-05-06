using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire5
{
    public class Albina:Insecta
    {
        private string rol;

        public Albina()
        {

        }

        public Albina(string rol)
        {
            this.rol = rol;
        }

        public string Rol
        {
            get { return this.rol; }
            set { this.rol = value; }
        }
    }
}
