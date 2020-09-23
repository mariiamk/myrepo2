using System;

namespace task
{
    class MainClass
    {
        public static void MyMethod1()
        {
            Console.WriteLine("MyMethod1");
        }

        public static void MyMethod2(int n)
        {
            Console.WriteLine("MyMethod2 " + n);
        }

        public static int MyMethod3(int n, int m)
        {
            Console.WriteLine("MyMethod3");
            return n + m;
        }

        public static void Main(string[] args)
        {
            MainClass.MyMethod1();
            MainClass.MyMethod2(5);
            MainClass.MyMethod2(15);
            int a = MainClass.MyMethod3(5, 15);
            Console.WriteLine(a);
            //Random random = new Random();
            //int number = random.Next(30, 100);
            //Console.WriteLine(number);

            //Random random = new Random();
            //char number = (char)random.Next('a', 'z');
            //Console.WriteLine(number);

            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine((char)n);


            //Console.WriteLine(Math.Pow(5, 2));
            //Console.WriteLine(Math.Pow(4, 3));
            //Console.WriteLine(Math.Sqrt(25));
            //Console.WriteLine(Math.Round(56.7));
        }
    }
}
