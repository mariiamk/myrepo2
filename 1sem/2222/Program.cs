using System;

namespace Application
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
            Console.WriteLine("MyMethod3 ");
            return n + m;
        }

        public static void Main(string[] args)
        {
            MainClass.MyMethod1();
            MainClass.MyMethod2(10);
            int a = MainClass.MyMethod3(10, 20);
            Console.WriteLine(a);








            /*
            Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine(Math.Pow(3, 4));
            Console.WriteLine(Math.Pow(2, 5));
            Console.WriteLine(Math.Pow(4, 3));
            Console.WriteLine(Math.Round(56.776));
            */
            /*
             сгенерировать и вывести случайную маленькую букву латинского алфавита
             */
            //Random random = new Random();
            //int n = (char)random.Next('a', 'z');
            //Console.WriteLine(n);

            //char a1 = 'a';
            //Console.WriteLine(a1);
            //Console.WriteLine((int)a1);
            //Console.WriteLine(a1 + 1);
            //Console.WriteLine((char)(a1 + 1));
            //Console.WriteLine((char)100);
        }
    }
}
