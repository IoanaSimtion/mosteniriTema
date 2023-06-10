using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace mosteniri.mostenire6
{
    public class CartiService
    {
        private List<Carte> carti;
        private string path = Application.StartupPath + @"\data\carti.txt";

        public CartiService()
        {
            carti = new List<Carte>();

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
                    case "carte actiune":
                        carti.Add(new CarteActiune(line));
                        break;
                    case "carte clasica":
                        carti.Add(new CarteClasica(line));
                        break;
                    default:
                        carti.Add(new CarteSF(line));
                        break;
                }
            }

            streamReader.Close();
        }

        public void descriere()
        {
            for (int i = 0; i < carti.Count; i++)
            {
                if (carti[i] is CarteActiune)
                {
                    CarteActiune carteActiune = (CarteActiune)carti[i];

                    Debug.WriteLine(carteActiune.descriereCarteActiune());

                }
                if (carti[i] is CarteClasica)
                {
                    CarteClasica carteClasica = (CarteClasica)carti[i];

                    Debug.WriteLine(carteClasica.descriereCarteClasica());
                }
                if (carti[i] is CarteSF)
                {
                    CarteSF carteSF = (CarteSF)carti[i];

                    Debug.WriteLine(carteSF.descriereCarteSF());
                }
            }
        }
    }
}
