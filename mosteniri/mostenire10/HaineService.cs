using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace mosteniri.mostenire10
{
    public class HaineService
    {
        private List<Haina> haine;
        private string path = Application.StartupPath + @"\data\haine.txt";

        public HaineService()
        {
            haine = new List<Haina>();

            this.load();
        }

        public void load()
        {
            StreamReader streamReader = new StreamReader(path);
            string line = "";
            while ((line = streamReader.ReadLine())!= null){
                switch(line.Split(",")[0]){
                    case "bluza": haine.Add(new Bluza(line));
                        break;
                    case "tricou": haine.Add(new Tricou(line));
                        break;
                    default: haine.Add(new Geaca(line));
                        break;
                }
            }

            streamReader.Close();
        }

        public void descriere()
        {
            for(int i = 0; i < haine.Count; i++)
            {
                if(haine[i] is Tricou)
                {
                    Tricou tricou= (Tricou)haine[i];

                    Debug.WriteLine(tricou.descriereTricou());

                }
                if(haine[i] is Geaca)
                {
                    Geaca geaca= (Geaca)haine[i];

                    Debug.WriteLine(geaca.descriereGeaca());
                }
                if (haine[i] is Bluza)
                {
                    Bluza bluza= (Bluza)haine[i];

                    Debug.WriteLine(bluza.descriereBluza());
                }
            }
        }
    }
}
