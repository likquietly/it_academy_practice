using System;
using System.Reflection;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, world";
            string newStr = str.NewString();
            Console.WriteLine(newStr);

            Type productType = typeof(Product);
            Type ctorParam = typeof(string);

            ConstructorInfo ctor = productType.GetTypeInfo().DeclaredConstructors.First(ctor => ctor.GetParametrs);
        }
    }
}
