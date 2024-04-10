namespace Comarch20240410.Cwiczenia.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak masz na imię?");
            string? imie = Console.ReadLine();

            Console.WriteLine("Ile masz lat?");
            string? wiekTekst = Console.ReadLine();
            int wiekLiczba = int.Parse(wiekTekst!);

            string wynik = "Witaj " + imie + ", masz " + wiekLiczba + " lat.";
            Console.WriteLine(wynik);
        }
    }
}
