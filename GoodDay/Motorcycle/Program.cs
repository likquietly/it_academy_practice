using System;

namespace Motorcycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new();
            Motorcycle moto1 = new();
            Motorcycle moto2 = new();

            Motorcycle.Engine motoEngine = new();
            Motorcycle.Engine motoEngine1 = new();
            Motorcycle.Engine motoEngine2 = new();

            Console.WriteLine("1 мотоцикл: Введите модель:");
            moto.Model = Console.ReadLine();

            Console.WriteLine("1 мотоцикл: Введите производителя:");
            moto.Manufacturer = Console.ReadLine();

            Console.WriteLine("1 мотоцикл: Введите год выпуска:");
            moto.Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1 мотоцикл: Введите пробег:");
            moto.Mileage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1 мотоцикл: Введите объем:");
            motoEngine.Сapacity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1 мотоцикл: Введите мощность:");
            motoEngine.Power = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("2 мотоцикл: Введите модель:");
            moto1.Model = Console.ReadLine();

            Console.WriteLine("2 мотоцикл: Введите производителя:");
            moto1.Manufacturer = Console.ReadLine();

            Console.WriteLine("2 мотоцикл: Введите год выпуска:");
            moto1.Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2 мотоцикл: Введите пробег:");
            moto1.Mileage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2 мотоцикл: Введите объем:");
            motoEngine1.Сapacity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2 мотоцикл: Введите мощность:");
            motoEngine1.Power = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("3 мотоцикл: Введите модель:");
            moto.Model = Console.ReadLine();

            Console.WriteLine("3 мотоцикл: Введите производителя:");
            moto.Manufacturer = Console.ReadLine();

            Console.WriteLine("3 мотоцикл: Введите год выпуска:");
            moto.Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3 мотоцикл: Введите пробег:");
            moto.Mileage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3 мотоцикл: Введите объем:");
            motoEngine.Сapacity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3 мотоцикл: Введите мощность:");
            motoEngine.Power = Convert.ToDouble(Console.ReadLine());

            Motorcycle[] mass = new Motorcycle[4];

            for (int i = 0; i < Motorcycle.Length; i++)
            {

            }
        }
    }
}
