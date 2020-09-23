using System;

namespace rand
{
    class MainClass
    {
        public static Random rnd = new Random();
        public static int my = 10;
        public static int MyMethod1()
        {
            my = 100;
            return 11;
        }

        public static void MyMethod2()
        {
            Console.WriteLine("FROM M2");
        }

        public static int MyMethod3(int a, int b)
        {
            return a + b;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine((int)(9.6 + 0.5));
            Console.WriteLine((int)(7.1 + 0.5));
            Console.WriteLine(Math.Round(9.8));
            Console.WriteLine(Math.Round(7.1));

            //int a;
            //if (!int.TryParse(Console.ReadLine(), out a))
            //{
            //    Console.WriteLine("error");
            //    return;
            //}
            //if (a <= 0)
            //{
            //    Console.WriteLine("exit");
            //    return;
            //}


            //Console.WriteLine(Math.Sqrt(5));
            //Console.WriteLine(Math.Pow(2, 5));

            //int a = MainClass.MyMethod1();
            //Console.WriteLine(a);
            //MainClass.MyMethod2();
            //Console.WriteLine(MainClass.MyMethod3(a, 20));
            //Random rnd = new Random();
            //Console.WriteLine(rnd.Next(-100, 10)); // (a, b) -> [a, b)
            //Console.WriteLine(rnd.NextDouble());
            //Console.WriteLine(rnd.Next(-10, 10) + rnd.NextDouble()); // [-10, 10)
            // [a, b) double
            // int [a, b) + [0, 1)
            //char a = (char)rnd.Next('a', 'z' + 1);
            //Console.WriteLine(a);
            //string str = "Proga";
            //Console.WriteLine((int)str[0]);

            // выделить генеарцию строки в метод, сгенерировать в мэйне 10 случайных строк
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(MainClass.Generate());
            //}
        }

        public static string Generate()
        {
            string str = "";
            int len = rnd.Next(3, 10);
            // for(A; B; C)
            // A - инициализатор, 1 раз, перед первой итерации
            // B - критерий останова, всегда, перед каждой итерацией
            // C - увеличитель,  выполняется всегда, но после каждой итерации
            for (int i = 0; i < len; i++)
            {
                str += (char)rnd.Next('a', 'z' + 1);
            }

            return str;
        }

    }
}
