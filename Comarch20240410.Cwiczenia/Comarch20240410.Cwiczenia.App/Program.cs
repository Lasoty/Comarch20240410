﻿using Comarch20240410.Cwiczenia.App.Services;

namespace Comarch20240410.Cwiczenia.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool czyKontynuacja = true;
            do
            {
                Console.Clear();

                Console.WriteLine("KALKULATOR v1.0.");
                Console.WriteLine("MENU: ");
                Console.WriteLine(" 1. Dodawanie");
                Console.WriteLine(" 2. Odejmowanie");

                Console.Write("Wybierz opcję: ");

                bool czyPoprawna = int.TryParse(Console.ReadLine(), out int wybor);

                if (czyPoprawna == true)
                {
                    Calculator calculator = new Calculator();
                    int x, y, wynik;

                    switch (wybor)
                    {
                        case 1:
                            Console.Write("Podaj X: ");
                            x = int.Parse(Console.ReadLine());
                            Console.Write("Podaj Y: ");
                            y = int.Parse(Console.ReadLine());
                            wynik = calculator.Add(x, y);
                            Console.WriteLine($"Wynik dodawania {x} oraz {y} to {wynik}.");
                            break;
                        case 2:
                            Console.Write("Podaj X: ");
                            x = int.Parse(Console.ReadLine());
                            Console.Write("Podaj Y: ");
                            y = int.Parse(Console.ReadLine());
                            wynik = calculator.Subtract(x, y);
                            Console.WriteLine($"Wynik odejmowania {x} oraz {y} to {wynik}.");
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
    }
}
