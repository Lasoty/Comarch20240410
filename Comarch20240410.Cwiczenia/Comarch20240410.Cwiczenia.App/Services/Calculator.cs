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
    }
}
