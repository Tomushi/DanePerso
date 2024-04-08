using DanePerso;
using System.Xml.Linq;

ZapisDoPliku pliki = new ZapisDoPliku();
Rasa rasa = new Rasa();

Rasa Mody = new();

bool czyKontynuowac = true;

Console.WriteLine("Witaj w miedzywymiarowym systemie rejestracji.");

while (czyKontynuowac)

{
    Console.WriteLine("Wybierw dostepna opcje:");
    Console.WriteLine("1. Dodaj Istote");
    Console.WriteLine("2. Pokaz liste Istot");
    Console.WriteLine("3. Zakoncz program");
    Console.WriteLine("Wybierz opcje i potwierdz wciskajac Enter");

    string operacja = Console.ReadLine();

    object name = null;
    int timeOfModyfication;
    switch (operacja)
    {
        case "1":
            Console.WriteLine("Prosze podaj swoje nazwisko.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Podaj swoje imie.");
            string Name = Console.ReadLine();
            Console.WriteLine("Jaki jest twoj wiek?");
            string age = Console.ReadLine();
            Console.WriteLine("Wspisz swoj rozmiar buta.");
            string shoes = Console.ReadLine();
            Console.WriteLine("Podaj swoja plec.");
            string sex = Console.ReadLine();
            Console.WriteLine("Podaj swoj gatunek.");
            string spieces = Console.ReadLine();
            Console.WriteLine("Z jakiego regionu pochodzisz?");
            string region = Console.ReadLine();
            Console.WriteLine("Jaka moc posiadasz?");
            string power = Console.ReadLine();
            Console.WriteLine("Jakie modyfikacje posiadasz?");
            string modyfications = Console.ReadLine();
            Console.WriteLine("Wpisz date modyfikacji");
            string timeOfModyficationTekst = Console.ReadLine();
            int.TryParse(timeOfModyficationTekst, out timeOfModyfication);
            Console.WriteLine("Kazda odpowiedz potwierdz Enterem");


            new Rasa().DodajRase(new Rasa(firstName, name, age, shoes, sex, spieces, region, power, modyfications, timeOfModyfication));
            break;

        case "2":
            Mody.PokazRasy();
            break;

        case "3":
            czyKontynuowac = false;
            Console.WriteLine("Zamykam program");
            break;

        default:
            Console.WriteLine("Bledna opcja, sprobuj ponownie");
            break;

    }
}

