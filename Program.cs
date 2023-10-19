using System.Reflection;
using System;

namespace task1910
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] Basket = new Fruit[]
            {
            new Apple { Price = 1.0, Sort = new string[] { "sari", "yasil" }, VitaminA = 8.0, VitaminB = 6.0 },
            new Pineapple { Price = 2.5, Sort = new string[] { "ananas1", "ananas2" }, VitaminE = 3.0, VitaminD = 2.0 },
            new Orange { Price = 0.75, Sort = new string[] { "mandalin", "apilsin" }, VitaminC = 50.0 }
        };

            foreach (var fruit in Basket)
            {
                Type fruitType = fruit.GetType();
                Console.WriteLine($"Type: {fruitType.Name}");

                FieldInfo[] fields = fruitType.GetFields();
                foreach (var field in fields)
                {
                    object value = field.GetValue(fruit);
                    Console.WriteLine($"{field.Name}: {value}");
                }
                Console.WriteLine();
            }
        }
        public abstract class Fruit
        {
            public double Price { get; set; }
            public string[] Sort { get; set; }

            public abstract void Taste();
        }

        public class Apple : Fruit
        {
            public double VitaminA { get; set; }
            public double VitaminB { get; set; }

            public override void Taste()
            {
                Console.WriteLine("sirin turs .");
            }
        }

        public class Pineapple : Fruit
        {
            public double VitaminE { get; set; }
            public double VitaminD { get; set; }

            public override void Taste()
            {
                Console.WriteLine("sirin qeribe  dad.");
            }
        }

        public class Orange : Fruit
        {
            public double VitaminC { get; set; }

            public override void Taste()
            {
                Console.WriteLine("sitrus meyvedi dadin izah elemedim daha.");
            }
        }
    }
}