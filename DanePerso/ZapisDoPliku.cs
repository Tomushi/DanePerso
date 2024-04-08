using DanePerso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DanePerso
{
    public class SciezkaDoPliku : IZapis
    {
        private string sciezkaDoPliku = "dane_ras.txt";

        void IZapis.ZapiszRasy(List<Rasa> rasas)
        {
            using StreamWriter writer = new(sciezkaDoPliku);
        }

        List<Rasa> IZapis.ZaladujRasy
        {
            get
            {
                List<Rasa> rasas = new List<Rasa>();
            }
        }

        void IZapis.ZapisRasy(List<Rasa> rasas) => throw new NotImplementedException();
    }
}

