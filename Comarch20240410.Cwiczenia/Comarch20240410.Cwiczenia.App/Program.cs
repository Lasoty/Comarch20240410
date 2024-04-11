using Comarch20240410.Cwiczenia.App.Services;

namespace Comarch20240410.Cwiczenia.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool czyKontynuacja = true;
            do
            {
                ShowMenu();

                Console.Write("Wybierz opcję: ");

                bool czyPoprawna = int.TryParse(Console.ReadLine(), out int wybor);

                if (czyPoprawna == true)
                {
                    Calculator calculator = new Calculator();
                    int x, y, result;

                    switch (wybor)
                    {
                        case 1:
                            GetXY(out x, out y);
                            result = calculator.Add(x, y);
                            Console.WriteLine($"Wynik dodawania {x} oraz {y} to {result}.");
                            break;
                        case 2:
                            GetXY(out x, out y);
                            result = calculator.Subtract(x, y);
                            Console.WriteLine($"Wynik odejmowania {x} oraz {y} to {result}.");
                            break;
                        case 3:
                            Console.WriteLine("Podaj elementy tablicy (rozdzielone spacjami)");
                            string userInput = Console.ReadLine();
                            string[] sNumbers = userInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            int[] input = new int[sNumbers.Length];

                            for (int i = 0; i < sNumbers.Length; i++)
                            {
                                input[i] = int.Parse(sNumbers[i]);
                            }

                            calculator.Sort(input);
                            Console.Write($"Wynik: [{string.Join(", ", input)}]");
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

                Console.ReadLine();

                Console.Clear();
                Console.Write("Czy chcesz wykonać nową operację? [T | n]: ");
                var wyborNaKoniec = Console.ReadKey();
                czyKontynuacja = wyborNaKoniec.Key != ConsoleKey.N;
            } while (czyKontynuacja);
        }

        private static void GetXY(out int x, out int y)
        {
            Console.Write("Podaj X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Podaj Y: ");
            y = int.Parse(Console.ReadLine());
        }

        private static void ShowMenu()
        {
            Console.Clear();

            Console.WriteLine("KALKULATOR v1.0.");
            Console.WriteLine("MENU: ");
            Console.WriteLine(" 1. Dodawanie");
            Console.WriteLine(" 2. Odejmowanie");
            Console.WriteLine(" 3. Sortowanie");
        }
    }
}
