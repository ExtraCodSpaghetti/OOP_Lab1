class Osoba
{
    private readonly string imie; // Imie 
    private readonly string nazwisko; // Nazwisko 
    private readonly int pesel; // Pesel

    public Osoba(string imie, string nazwisko, int pesel)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.pesel = pesel;
    }

    public Osoba()
    {
        this.imie = "";
        this.nazwisko = "";
        this.pesel = 0;
    }

    public void Wyswietl()
    {
        Console.WriteLine(imie + " " + nazwisko + " " + pesel);
    }

    public override string ToString()
    {
        return imie + " " + nazwisko + " " + pesel;
    }
}

class Baza
{
    private Stack<Osoba> tab;

    public Baza()
    {
        tab = new Stack<Osoba>();
    }

    public void Dodaj(Osoba osoba)
    {
        tab.Push(osoba);
    }

    public void Wyswietl()
    {
        Console.WriteLine("Wyswietl - elementow: " + tab.Count);
        foreach (Osoba osoba in tab)
        {
            Console.WriteLine(osoba);
        }
    }

    public void Usun()
    {
        Console.WriteLine("pop -> " + tab.Pop());
    }
}

class BazaOsobaStackDemo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start");

        Osoba os1 = new Osoba("Jan", "Kowal", 1);
        Osoba os2 = new Osoba("Wanda", "Maj", 2);
        Osoba os3 = new Osoba("Ewa", "Gaj", 3);
        Osoba os4 = new Osoba("Zenon", "Hak", 4);
        Osoba os = new Osoba();

        os1.Wyswietl();
        os2.Wyswietl();
        os3.Wyswietl();

        Baza mybaza = new Baza();
        mybaza.Dodaj(os1);
        mybaza.Dodaj(os2);
        mybaza.Dodaj(os3);
        mybaza.Wyswietl();

        mybaza.Usun();
        mybaza.Wyswietl();
    }
}
