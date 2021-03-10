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

            object[] mass = new object[6];
            mass[0] = moto.Model;
            mass[1] = moto.Manufacturer;
            mass[2] = moto.Year;
            mass[3] = moto.Mileage;
            mass[4] = motoEngine.Сapacity;
            mass[5] = motoEngine.Power;

            object[] mass1 = new object[6];
            mass[0] = moto1.Model;
            mass[1] = moto1.Manufacturer;
            mass[2] = moto1.Year;
            mass[3] = moto1.Mileage;
            mass[4] = motoEngine1.Сapacity;
            mass[5] = motoEngine1.Power;

            object[] mass2 = new object[6];
            mass[0] = moto2.Model;
            mass[1] = moto2.Manufacturer;
            mass[2] = moto2.Year;
            mass[3] = moto2.Mileage;
            mass[4] = motoEngine2.Сapacity;
            mass[5] = motoEngine2.Power;

            Console.WriteLine($"1 Мотоцикл(Производитель): {0}, Модель: {1}, Пробег: {2}, Год: {3}\nДвигатель(Объем): {4}, Мощность: {5}"
                , moto.Manufacturer, moto.Model, moto.Mileage, moto.Year, motoEngine.Сapacity, motoEngine.Power);

            Console.WriteLine($"2 Мотоцикл(Производитель): {0}, Модель: {1}, Пробег: {2}, Год: {3}\nДвигатель(Объем): {4}, Мощность: {5}"
                , moto1.Manufacturer, moto1.Model, moto1.Mileage, moto1.Year, motoEngine1.Сapacity, motoEngine1.Power);

            Console.WriteLine($"3 Мотоцикл(Производитель): {0}, Модель: {1}, Пробег: {2}, Год: {3}\nДвигатель(Объем): {4}, Мощность: {5}"
                , moto2.Manufacturer, moto2.Model, moto2.Mileage, moto2.Year, motoEngine2.Сapacity, motoEngine2.Power);
        }
    }
}
