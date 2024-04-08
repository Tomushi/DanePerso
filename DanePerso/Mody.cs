using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanePerso
{
    internal class Mody
    {
        internal string FirstName { get; set; }
        internal string Name { get; set; }
        internal string Age { get; set; }
        internal string Shoes { get; set; }
        internal string Sex { get; set; }
        internal string Spieces { get; set; }
        internal string Region { get; set; }
        internal string Power { get; set; }
        internal string Modyfications { get; set; }
        internal int TimeOfModyfication { get; set; }
        public string TimeOfModyfication1 { get; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        internal Mody(string firstName, string name, string age, string shoes, string sex, string spieces, string region, string power, string modyfications, int timeOfModyfication)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            FirstName = firstName;
            Name = name;
            Age = age;
            Shoes = shoes;
            Sex = sex;
            Spieces = spieces;
            Region = region;
            Power = power;
            Modyfications = modyfications;
            TimeOfModyfication = timeOfModyfication;
        }

        public Mody(string firstName, string name, string age, string shoes, string sex, string spieces, string region, string power, string modyfications, string timeOfModyfication)
        {
            FirstName = firstName;
            Name = name;
            Age = age;
            Shoes = shoes;
            Sex = sex;
            Spieces = spieces;
            Region = region;
            Power = power;
            Modyfications = modyfications;
            TimeOfModyfication1 = timeOfModyfication;        
        }

        public void WyswietlDaneRasowe()
        {
                Console.WriteLine($"First Name: {FirstName},Name {Name}, Age {Age}, Shoes {Shoes}, Sex {Sex}, Spieces {Spieces}, Region {Region}, Power {Power}, Time of modyfication {TimeOfModyfication}");
        }
    }
}
