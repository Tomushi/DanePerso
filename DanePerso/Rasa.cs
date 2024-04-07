using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanePerso
{
    internal class Rasa
    {
        internal List<Rasa> rasas = new List<Rasa>();
        internal void DodajRase(Rasa nowaRasa)
    }

    internal void PokazRasy()
    {
        if (rasas.Count == 0)
        {
            Console.WriteLine("Brak zarejestrownaych ras, sprawdz labolatorium NewGen.");
            return;
        }

        foreach (Rasa rasas in Mody)
        {
            Rasa.WyswietlDaneRasowe();
        }
    }
}
