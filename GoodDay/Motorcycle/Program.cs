using System;
using System.Collections.Generic;

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
            moto2.Model = Console.ReadLine();

            Console.WriteLine("3 мотоцикл: Введите производителя:");
            moto2.Manufacturer = Console.ReadLine();

            Console.WriteLine("3 мотоцикл: Введите год выпуска:");
            moto2.Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3 мотоцикл: Введите пробег:");
            moto2.Mileage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3 мотоцикл: Введите объем:");
            motoEngine2.Сapacity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3 мотоцикл: Введите мощность:");
            motoEngine2.Power = Convert.ToDouble(Console.ReadLine());


            List<Motorcycle> listMotorcycle = new List<Motorcycle>();
            listMotorcycle.Add(moto);

            List<Motorcycle> listMotorcycle1 = new List<Motorcycle>();
            listMotorcycle1.Add(moto1);

            List<Motorcycle> listMotorcycle2 = new List<Motorcycle>();
            listMotorcycle2.Add(moto2);


            List<Motorcycle.Engine> listEngine = new List<Motorcycle.Engine>();
            listEngine.Add(motoEngine);

            List<Motorcycle.Engine> listEngine1 = new List<Motorcycle.Engine>();
            listEngine1.Add(motoEngine1);

            List<Motorcycle.Engine> listEngine2 = new List<Motorcycle.Engine>();
            listEngine2.Add(motoEngine2);


            Console.WriteLine($"1 Мотоцикл(Производитель): {0}, Модель: {1}, Пробег: {2}, Год: {3}\nДвигатель(Объем): {4}, Мощность: {5}"
                , listMotorcycle[1], listMotorcycle[0], listMotorcycle[3], listMotorcycle[2], listEngine[0], listEngine[1]);

            Console.WriteLine($"2 Мотоцикл(Производитель): {0}, Модель: {1}, Пробег: {2}, Год: {3}\nДвигатель(Объем): {4}, Мощность: {5}"
                , listMotorcycle1[1], listMotorcycle1[0], listMotorcycle1[3], listMotorcycle1[2], listEngine1[0], listEngine1[1]);

            Console.WriteLine($"3 Мотоцикл(Производитель): {0}, Модель: {1}, Пробег: {2}, Год: {3}\nДвигатель(Объем): {4}, Мощность: {5}"
                , listMotorcycle2[1], listMotorcycle2[0], listMotorcycle2[3], listMotorcycle2[2], listEngine2[0], listEngine2[1]);
        }
    }
}