using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comarch20240410.Cwiczenia.App.Services
{
    public class Calculator
    {
        /// <summary>
        /// Metoda do sumowania danych
        /// </summary>
        /// <param name="x">Parametr 1</param>
        /// <param name="y">Parametr 2</param>
        /// <returns>Suma parametrów 1 i 2</returns>
        public int Add(int x, int y = 0)
        {
            int wynik = x + y;
            return wynik;
        }

        internal int Subtract(int x, int y)
        {
            return x - y;
        }

        public int[] Sort(int[] tablica)
        {
            int n = tablica.Length - 1;

            // Pętla zewnętrzna przechodzi przez wszystkie elementy tablicy
            for (int i = 0; i < n; i++)
            {
                // Pętla wewnętrzna porównuje elementy i dokonuje zamiany, jeśli jest to konieczne
                for (int j = 0; j < n - i; j++)
                {
                    // Sprawdź, czy kolejne elementy są w niewłaściwej kolejności
                    if (tablica[j] > tablica[j + 1])
                    {
                        // Zamiana elementów
                        int temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                    }
                }
            }

            return tablica;
        }
    }
}
