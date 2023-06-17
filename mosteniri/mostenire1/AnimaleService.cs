using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace mosteniri.mostenire1
{
    public class AnimaleService
    {
        private List<Animal> animale;
        private string path = Application.StartupPath + @"\data\animale.txt";

        public AnimaleService()
        {
            animale = new List<Animal>();

            this.load();

        }

        public void load()
        {
            StreamReader streamReader = new StreamReader(path);
            string line = "";
            while((line = streamReader.ReadLine())!= null){
                switch (line.Split(",")[0]){
                    case "caine": animale.Add(new Caine(line));
                        break;
                    case "pisica": animale.Add(new Pisica(line));
                        break;
                    default: animale.Add(new Urs(line));
                        break;
                }
            }

            streamReader.Close();
        }


        public void afisareDescriere()
        {
            for(int i = 0; i < animale.Count; i++)
            {
                if (animale[i] is Caine)
                {
                    Caine caine = (Caine)animale[i];

                    Debug.WriteLine(caine.ToString());
                }
                if(animale[i] is Pisica)
                {
                    Pisica pisica = (Pisica)animale[i];

                    Debug.WriteLine(pisica.ToString());
                }
                if (animale[i] is Urs)
                {
                    Urs urs = (Urs)animale[i];

                    Debug.WriteLine(urs.ToString());
                }
            }
        }
    }
}
