namespace Comarch20240410.Cwiczenia.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KALKULATOR v1.0.");
            Console.WriteLine("MENU: ");
            Console.WriteLine(" 1. Dodawanie");
            Console.WriteLine(" 2. Odejmowanie");

            Console.Write("Wybierz opcję: ");

            bool czyPoprawna = int.TryParse(Console.ReadLine(), out int wybor);

            if (czyPoprawna == true)
            {
                switch (wybor)
                {
                    case 1:
                        Console.WriteLine("Dodawanie.");
                        break;
                    case 2:
                        Console.WriteLine("Odejmowanie.");
                        break;

                    default:
                        Console.WriteLine("Podana wartość jest poza zakresem.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Podana wartość jest nieprawidłowa");
            }
        }
    }
}
