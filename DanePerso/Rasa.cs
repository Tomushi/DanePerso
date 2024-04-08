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
        private string? firstName;
        private object? name;
        private string? age;
        private string? shoes;
        private string? sex;
        private string? spieces;
        private string? region;
        private string? power;
        private string? modyfications;
        private int timeOfModyfication;
        private IEnumerable<Mody> rasa;

        public Rasa()
        {
        }

        public Rasa(string? firstName, object? name, string? age, string? shoes, string? sex, string? spieces, string? region, string? power, string? modyfications, int timeOfModyfication)
        {
            this.firstName = firstName;
            this.name = name;
            this.age = age;
            this.shoes = shoes;
            this.sex = sex;
            this.spieces = spieces;
            this.region = region;
            this.power = power;
            this.modyfications = modyfications;
            this.timeOfModyfication = timeOfModyfication;
        }

        public static int Count { get; private set; }

        internal void DodajRase(Rasa nowaRasa)
        {
            rasas.Add(nowaRasa);
            Console.WriteLine($"Dodano rase: {nowaRasa.rasas}");
        }
        internal void PokazRasy()
        {
            if (rasas.Count == 0)
            {
                Console.WriteLine("Brak zarejestrownaych ras, sprawdz w labolatorium NewGen.");
                return;
            }

            foreach (Mody mody in rasa)
            {
                mody.WyswietlDaneRasowe();
            }
        }
    }
}
