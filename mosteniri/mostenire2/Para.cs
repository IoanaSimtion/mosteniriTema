using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosteniri.mostenire2
{
    public class Para:Fruct
    {
        private string tipPara;

        public Para()
        {

        }

        public Para(string tipPara)
        {
            this.tipPara = tipPara;
        }

        public string TipPara
        {
            get { return tipPara; }
            set { tipPara = value; }
        }
    }
}
