using System;
using System.Reflection;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1
            string str = "Hello, world";
            string newStr = str.NewString();
            Console.WriteLine(newStr);

            //task 2
            Type productType = typeof(Product);

            Console.WriteLine("Конструкторы:");
            foreach (ConstructorInfo ctor in productType.GetConstructors())
            {
                Console.Write(productType.Name + " (");
                // получаем параметры конструктора
                ParameterInfo[] parameters = ctor.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");

                object obj = ctor.Invoke(parameters);

                FieldInfo fieldInfo = obj.GetType().GetTypeInfo().GetDeclaredField("_id");
                fieldInfo.SetValue(obj, 999);

                PropertyInfo propInfo = obj.GetType().GetTypeInfo().GetDeclaredProperty("Name");
                propInfo.SetValue(obj, "Iphone 12 Pro");

                FieldInfo fieldInfo2 = obj.GetType().GetTypeInfo().GetDeclaredField("ProductType");
                fieldInfo2.SetValue(obj, "TelePhone");
            }
        }
    }
}