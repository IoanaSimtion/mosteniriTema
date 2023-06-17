using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace mosteniri.mostenire9
{
    public class BijuteriiService
    {
        private List<Bijuterie> bijuterii;
        private string path = Application.StartupPath + @"\data\bijuterii.txt";

        public BijuteriiService()
        {
            bijuterii = new List<Bijuterie>();

            this.load();
        }

        public void load()
        {
            StreamReader streamReader = new StreamReader(path);
            string line = "";

            while ((line = streamReader.ReadLine()) != null)
            {
                switch (line.Split(",")[0])
                {
                    case "bratara": bijuterii.Add(new Bratara(line));
                        break;
                    case "inel": bijuterii.Add(new Inel(line));
                        break;
                    default: bijuterii.Add(new Colier(line));
                        break;
                }
            }

            streamReader.Close();
        }

        public void descriere()
        {
            for(int i = 0; i < bijuterii.Count; i++)
            {
                if(bijuterii[i] is Bratara)
                {
                    Bratara bratara = (Bratara)bijuterii[i];

                    Debug.WriteLine(bratara.ToString());
                }
                if (bijuterii[i] is Colier)
                {
                    Colier colier = (Colier)bijuterii[i];

                    Debug.WriteLine(colier.ToString());
                }
                if (bijuterii[i] is Inel)
                {
                    Inel inel = (Inel)bijuterii[i];

                    Debug.WriteLine(inel.ToString());
                }
            }
        }
    }
}
