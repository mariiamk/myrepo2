using System;

namespace sem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Hello "+ name);

            Console.ReadKey();
            */
            string sa = Console.ReadLine();
            //int a = int.Parse(sa);
            int a;
            bool ba = int.TryParse(sa, out a);

            //int b = int.Parse(Console.ReadLine());
            int b;
            string sb = Console.ReadLine();
            bool bb = int.TryParse(sb, out b);

            Console.WriteLine(ba);
            Console.WriteLine(bb);

            if (ba && bb)
            {
                Console.WriteLine(a + b);
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
