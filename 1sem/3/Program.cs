using System;

namespace Application
{
    /*
    Написать метод для вычисления площади и длины окружности, радиус которой
    задает вещественный параметр. 
    В основной программе, вводя значения радиуса, с помощью обращения к методу,
    вычислять площадь и длину окружности. При вводе применять метод double.TryParse()
    и проверять корректность введенного значения. При выводе использовать форматную
    строку метода WriteLine(). Окончание работы программы – ввод нулевого или
    отрицательного значения радиуса.    
    */
    class MainClass
    {
        public static double S(double r)
        {
            return Math.PI * r * r;
        }

        public static double L(double r)
        {
            return 2 * Math.PI * r;
        }

        public static void Main(string[] args)
        {
            int x = 10;
            int y = 30;

            if (x > y)
            {
                int temp = x;
                x = y;
                y = temp;
            }

            int max = (x > y) ? x : y;
            Console.WriteLine(max);

            //double radius;
            //if (!double.TryParse(Console.ReadLine(), out radius) || radius <=0)
            //{
            //    Console.WriteLine("error");
            //    return;
            //}

            //double s = MainClass.S(radius);
            //Console.WriteLine(s.ToString("f2"));
            //double l = MainClass.L(radius);
            //Console.WriteLine($"radius - {radius:f2}; length - {l:f3}");
        }
    }
}
