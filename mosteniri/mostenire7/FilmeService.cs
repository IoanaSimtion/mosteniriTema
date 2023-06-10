using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace mosteniri.mostenire7
{
    public class FilmeService
    {
        private List<Film> filme;
        private string path = Application.StartupPath + @"\data\filme.txt";

        public FilmeService()
        {
            filme = new List<Film>();

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
                        filme.Add(new FilmActiune(line));
                        break;
                    case "carte clasica":
                        filme.Add(new FilmRomantic(line));
                        break;
                    default:
                        filme.Add(new FilmSF(line));
                        break;
                }
            }

            streamReader.Close();
        }

        public void descriere()
        {
            for (int i = 0; i < filme.Count; i++)
            {
                if (filme[i] is FilmActiune)
                {
                    FilmActiune carteActiune = (FilmActiune)filme[i];

                    Debug.WriteLine(carteActiune.descriereFilmActiune());

                }
                if (filme[i] is FilmRomantic)
                {
                    FilmRomantic filmRomantic = (FilmRomantic)filme[i];

                    Debug.WriteLine(filmRomantic.descriereFilmRomantic());
                }
                if (filme[i] is FilmSF)
                {
                    FilmSF filmSF = (FilmSF)filme[i];

                    Debug.WriteLine(filmSF.descriereFilmSF());
                }
            }
        }
    }
}
