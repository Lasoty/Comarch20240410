using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comarch20240410.Cwiczenia.App.Model
{
    internal class Car
    {
        private int fuelLevel;

        public Car()
        {

        }

        public Car(string maker, string model)
        {
            Maker = maker;
            Model = model;
        }

        public string Maker { get; private set; }

        public string Model { get; set; }

        public int FuelLevel
        {
            get
            {
                Console.WriteLine($"Odczytano wartość FuelLevel: {fuelLevel}");
                return fuelLevel;
            }

            set
            {
                fuelLevel = value;
                Console.WriteLine($"Zapisano wartość FuelLevel: {value}");
            }
        }

        public Car Car2 { get; set; }
    }
}
