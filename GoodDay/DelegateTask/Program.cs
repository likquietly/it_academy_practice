namespace DelegateTask
{
    delegate bool MyDelegateMotorcycle(Motorcycle obj);
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle[] arr = new Motorcycle[5];

            arr[0] = new Motorcycle { Model = "Minsk X250", MadeIn = "China", Odometer = 6_000 };
            arr[1] = new Motorcycle { Model = "Honda CB500F", MadeIn = "Japan", Odometer = 11_500 };
            arr[2] = new Motorcycle { Model = "BMW G1200R", MadeIn = "Germany", Odometer = 20_000 };
            arr[3] = new Motorcycle { Model = "Triumph Tiger 800", MadeIn = "China", Odometer = 30_000 };
            arr[4] = new Motorcycle { Model = "Honda CB1100RR", MadeIn = "Japan", Odometer = 26_000 };

            Motorcycle moto = new();
            moto = FirstOrDefault(arr, ValueOdometr);
            moto = FirstOrDefault(arr, MadeIn);
            moto = FirstOrDefault(arr, OdometrMadeIn);
        }

        public static bool ValueOdometr(Motorcycle moto)
        {
            return moto.Odometer >= 50_000;
        }

        public static bool MadeIn(Motorcycle moto)
        {
            return moto.MadeIn.Equals("China");
        }

        public static bool OdometrMadeIn(Motorcycle moto)
        {
            return moto.MadeIn.Equals("Japan") && moto.Odometer >= 25_000;
        }

        public Motorcycle FirstOrDefault(Motorcycle[] arr, MyDelegateMotorcycle motoDel)
        {
            var result = new Motorcycle();

            foreach (var moto in arr)
            {
                if (motoDel(moto))
                    result = moto;
            }
            return result;
        }
    }
}
