using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comarch20240410.Cwiczenia.App.Services
{
    public class Calculator
    {
        public int Add(int x, int y)
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
