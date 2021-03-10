using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle
{
    internal class Motorcycle
    {
        readonly Guid guid = Guid.NewGuid();
        private string _model;
        private string _manufacturer;
        private int _year;
        private double _mileage;

        public string Model
        {
            set
            {
                if (value == string.Empty)
                {
                    Console.WriteLine("Cannot be empty");
                }
                else
                {
                    _model = value;
                }
            }
            get { return _model; }
        }

        public string Manufacturer
        {
            set
            {
                if (value == string.Empty)
                {
                    Console.WriteLine("Cannot be empty");
                }
                else
                {
                    _manufacturer = value;
                }
            }
            get { return _manufacturer; }
        }

        public int Year
        {
            set
            {
                if (value != DateTime.Now.Year)
                {
                    Console.WriteLine("The year of issue must be equal to the current year");
                }
                else
                {
                    _year = value;
                }
            }
            get { return _year; }
        }

        public double Mileage
        {
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("Mileage should not exceed 100 km");
                }
                else
                {
                    _mileage = value;
                }
            }
            get { return _mileage; }
        }
        
        private void Meth()
        {

            Console.WriteLine("Factory reset");
        }

        class Engine
        {
            private double _capacity;
            private double _power;

            public double Сapacity
            {
                set
                {
                    if (value < 125 || value < 3200)
                    {
                        Console.WriteLine("Unacceptable capacity");
                    }
                    else
                    {
                        _capacity = value;
                    }
                }
                get { return _capacity; }
            }

            public double Power
            {
                set
                {
                    if (value < 50 || value < 300)
                    {
                        Console.WriteLine("Unacceptable power");
                    }
                    else
                    {
                        _power = value;
                    }
                }
                get { return _power; }
            }
        }

    }
}
